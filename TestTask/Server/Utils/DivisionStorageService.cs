using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Utils
{
    /// <summary>
    /// Сервис по работе с хранилищем подразделений
    /// </summary>
    public class DivisionStorageService : IStorageService<Division>
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly Cache _cache;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем подразделений
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        /// <param name="cache">Класс, имеющий хранилища списков записей</param>
        public DivisionStorageService(UnitOfWork unitOfWork, Cache cache)
        {
            _unitOfWork = unitOfWork;
            _cache = cache;
        }

        /// <summary>
        /// Получение списка подразделений
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        /// <param name="forceFromDb">Принудительно искать подразделения в бд</param>
        public IEnumerable<Division> GetAll(Expression<Func<Division, bool>> filter = null, bool forceFromDb = false)
        {
            if (_cache.DivisionStorage.Any() && !forceFromDb)
                return _cache.DivisionStorage.GetAll(filter?.Compile());

            var divisions = _unitOfWork.DivisionRepository.GetWithChildren(filter);

            if (filter is null)
                _cache.DivisionStorage.Fill(divisions);

            return divisions;
        }

        /// <summary>
        /// Получение подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        /// <param name="forceFromDb">Принудительно искать подразделение в бд</param>
        public Division Get(int id, bool forceFromDb = false)
        {
            try
            {
                return _cache.DivisionStorage.Any() && !forceFromDb
                    ? _cache.DivisionStorage.Get(id)
                    : _unitOfWork.DivisionRepository.Get(id);
            }
            catch (ArgumentException)
            {
                return null;
            }
        }

        /// <summary>
        /// Добавление подразделения в хранилище
        /// </summary>
        /// <param name="division">Подразделение, которую нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленного подразделения</returns>
        public int Add(Division division)
        {
            var entity = _unitOfWork.DivisionRepository
                .Add(division).Entity;

            _unitOfWork.Save();

            _cache.DivisionStorage.Add(entity);

            return entity.Id;
        }

        /// <summary>
        /// Обновление подразделения из хранилища записью entity
        /// </summary>
        /// <param name="division">Обновленное подразделение, которое нужно заменить в хранилище</param>
        public void Update(Division division)
        {
            if (_cache.DivisionStorage.Any())
                _cache.DivisionStorage.Replace(division);
        }

        /// <summary>
        /// Созранение и обновление подразделения из хранилища записью entity
        /// </summary>
        /// <param name="division">Обновленное подразделение, которое нужно сохранить и заменить в хранилище</param>
        public void SaveAndUpdate(Division division)
        {
            _unitOfWork.DivisionRepository.Update(division);
            _unitOfWork.Save();

            if (_cache.DivisionStorage.Any())
                _cache.DivisionStorage.Replace(division);

        }

        /// <summary>
        /// Созранение подразделения из хранилища записью entity
        /// </summary>
        public void Save()
        {
            _unitOfWork.Save();
        }

        /// <summary>
        /// Удаление подразделения
        /// </summary>
        /// <param name="id">Идентификатор, по которому нуэно удалить подразделение</param>
        public void Delete(int id)
        {
            var division = Get(id, true);
            _unitOfWork.DivisionRepository.Delete(division);
            _unitOfWork.Save();

            _cache.DivisionStorage.Remove(id);
        }
    }
}