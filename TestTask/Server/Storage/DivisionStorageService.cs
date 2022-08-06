using System;
using System.Linq;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Сервис по работе с хранилищем подразделений
    /// </summary>
    public class DivisionStorageService : StorageService<Division>, IDivisionStorageService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Cache _cache;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем подразделений
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        /// <param name="cache">Класс, имеющий хранилища списков подразделений</param>
        public DivisionStorageService(UnitOfWork unitOfWork, Cache cache) : base(unitOfWork, cache)
        {
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        /// <summary>
        /// Получение подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        public Division Get(int id)
        {
            try
            {
                return _cache.DivisionStorage.Any()
                    ? _cache.DivisionStorage.Get(id)
                    : _unitOfWork.DivisionRepository.Get(id);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        /// <summary>
        /// Созранение и обновление подразделения из хранилища записью entity
        /// </summary>
        /// <param name="division">Обновленное подразделение, которое нужно сохранить и заменить в хранилище</param>
        public override void SaveAndUpdate(Division division)
        {
            base.SaveAndUpdate(division);

            if (division.DivisionId != null)
            {
                var parentDivision = _cache.DivisionStorage.Get((int)division.DivisionId);
                parentDivision.SubDivisions.Add(division);
                _cache.DivisionStorage.Replace(parentDivision);
            }

            var subDivisions = _cache.DivisionStorage.GetAll(d => d.DivisionId == division.Id);

            foreach (var subDivision in subDivisions)
            {
                if (division.SubDivisions.Any(d => d.Id == subDivision.Id))
                    continue;

                subDivision.DivisionId = null;
                subDivision.ParentDivision = null;
                _cache.DivisionStorage.Replace(subDivision);
            }

            foreach (var subDivision in division.SubDivisions)
            {
                subDivision.DivisionId = division.Id;
                subDivision.ParentDivision = division;
                _cache.DivisionStorage.Replace(subDivision);
            }
        }
    }
}