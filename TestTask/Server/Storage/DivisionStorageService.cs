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
        private readonly Repository<Division> _repository;
        private readonly IStorage<Division> _storage;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем подразделений
        /// </summary>
        public DivisionStorageService(Repository<Division> repository, IStorage<Division> storage, UnitOfWork unitOfWork) : base(repository, storage, unitOfWork)
        {
            _repository = repository;
            _storage = storage;
        }

        /// <summary>
        /// Получение подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        public Division Get(int id)
        {
            try
            {
                return _storage.Any()
                    ? _storage.Get(id)
                    : _repository.Get(id);
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
                var parentDivision = _storage.Get((int)division.DivisionId);
                parentDivision.SubDivisions.Add(division);
                _storage.Replace(parentDivision);
            }

            var subDivisions = _storage.GetAll(d => d.DivisionId == division.Id);

            foreach (var subDivision in subDivisions)
            {
                if (division.SubDivisions.Any(d => d.Id == subDivision.Id))
                    continue;

                subDivision.DivisionId = null;
                subDivision.ParentDivision = null;
                _storage.Replace(subDivision);
            }

            foreach (var subDivision in division.SubDivisions)
            {
                subDivision.DivisionId = division.Id;
                subDivision.ParentDivision = division;
                _storage.Replace(subDivision);
            }
        }

        public override void Delete(int id)
        {
            var division = Get(id);
            division.DivisionId = null;
            division.ParentDivision = null;
            SaveAndUpdate(division);

            var subDivisions = GetAll(d => d.DivisionId == division.Id);

            foreach (var subDivision in subDivisions)
            {
                subDivision.DivisionId = null;
                subDivision.ParentDivision = null;
                SaveAndUpdate(subDivision);
            }

            base.Delete(id);
        }
    }
}