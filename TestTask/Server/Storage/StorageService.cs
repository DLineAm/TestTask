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
        private readonly UnitOfWork _unitOfWork;
        private readonly Cache _cache;

        /// <summary>
        /// Конструктор сервиса по работе с хранилищем
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        /// <param name="cache">Класс, имеющий хранилища списков сотрудников</param>
        public StorageService(UnitOfWork unitOfWork, Cache cache)
        {
            _unitOfWork = unitOfWork;
            _cache = cache;
        }
        
        /// <summary>
        /// Получение списка записей
        /// </summary>
        /// <param name="filter">Возможный фильтр</param>
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            var storage = _cache.GetStorage<T>();

            return storage.Any() 
                ? storage.GetAll(filter?.Compile()) 
                : GetFromDbAndFillCache();
        }

        /// <summary>
        /// Добавление записи в хранилище
        /// </summary>
        /// <param name="entity">Запись, которую нужно добавить в хранилище</param>
        /// <returns>Идентификатор добавленной записи</returns>
        public int Add(T entity)
        {
            var entry = _unitOfWork.GetRepository<T>().Add(entity).Entity;

            _unitOfWork.Save();

            _cache.GetStorage<T>().Add(entity);

            return entry.Id;
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="id">Идентификатор, по которому нужно удалить запись</param>
        public void Delete(int id)
        {
            _unitOfWork.GetRepository<T>().Delete(id);
            _unitOfWork.Save();

            _cache.GetStorage<T>().Remove(id);
        }

        /// <summary>
        /// Созранение и обновление записи из хранилища записью entity
        /// </summary>
        /// <param name="entity">Обновленная запись, которую нужно сохранить и заменить в хранилище</param>
        public virtual void SaveAndUpdate(T entity)
        {
            _unitOfWork.GetRepository<T>().Update(entity);
            _unitOfWork.Save();

            var storage = _cache.GetStorage<T>();

            if (!storage.Any()) return;

            storage.Replace(entity);
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
            var entities = _unitOfWork.GetRepository<T>().GetWithChildren().ToList();

            foreach (var entity in entities)
            {
                _cache.GetStorage<T>().Add(entity);
            }

            return entities;
        }
    }
}