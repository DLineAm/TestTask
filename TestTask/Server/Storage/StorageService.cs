using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TestTask.Server.DAL;
using TestTask.Shared;

namespace TestTask.Server.Storage
{
    /// <summary>
    /// Класс, содержащий базовые методы для работы с хранилищем
    /// </summary>
    /// <typeparam name="T">Тип модели, используемый в хранилище</typeparam>
    public class StorageService<T> where T : class, IIdentity, new()
    {
        private readonly Repository<T> _repository;
        private readonly IStorage<T> _storage;
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем
        /// </summary>
        public StorageService(Repository<T> repository, IStorage<T> storage, UnitOfWork unitOfWork)
        {
            _repository = repository;
            _storage = storage;
            _unitOfWork = unitOfWork;
        }
        
        /// <summary>
        /// Получение списка записей
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _storage.Any() 
                ? _storage.GetAll(filter?.Compile()) 
                : GetFromDbAndFillCache();
        }

        /// <summary>
        /// Добавление записи в хранилище
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленной записи</returns>
        public int Add(T entity)
        {
            var entry = _repository.Add(entity).Entity;

            _unitOfWork.Save();

            _storage.Add(entity);

            return entry.Id;
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="id">Идентификатор, по которому нужно удалить запись</param>
        public virtual void Delete(int id)
        {
            _repository.Delete(id);
            _unitOfWork.Save();

            _storage.Remove(id);
        }

        /// <summary>
        /// Созранение и обновление записи из хранилища записью entity
        /// </summary>
        /// <param name="entity">Обновленная запись, которую нужно сохранить и заменить в хранилище</param>
        public virtual void SaveAndUpdate(T entity)
        {
            _repository.Update(entity);
            _unitOfWork.Save();

            if (!_storage.Any()) return;

            _storage.Replace(entity);
        }

        /// <summary>
        /// Заполнение хранилища списком записей
        /// </summary>
        public void FillCache()
        {
            GetFromDbAndFillCache();
        }

        private IEnumerable<T> GetFromDbAndFillCache()
        {
            var entities = _repository.GetWithChildren().ToList();

            foreach (var entity in entities)
            {
                _storage.Add(entity);
            }

            return entities;
        }
    }
}