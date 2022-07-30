﻿using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Linq;

using TestTask.Server.DAL;
using TestTask.Server.Storage;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис подразделений
    /// </summary>
    public class DivisionService : IDivisionService
    {
        private readonly UnitOfWork _unitOfWork;
        private readonly ILogger<DivisionService> _logger;
        private readonly DataServiceCollection _serviceCollection;

        /// <summary>
        /// Конструктор сервиса сотрудников
        /// </summary>
        /// <param name="unitOfWork">Класс, хранящий все репозитории с целью гарантии использования одного контекста</param>
        /// <param name="logger">Логгер</param>
        public DivisionService(UnitOfWork unitOfWork, ILogger<DivisionService> logger, DataServiceCollection serviceCollection)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _serviceCollection = serviceCollection;
        }

        /// <summary>
        /// Получение списка подразделений
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Division> Get()
        {
            return _serviceCollection.Divisions.GetAll();
        }

        /// <summary>
        /// Попытка получить подразделение по идентификатору
        /// </summary>
        /// <param name="id">Идентификатор подразделения</param>
        /// <param name="division">Найденное подразделение</param>
        /// <returns>True, если запись подразделение найдено. False, если нет</returns>
        public bool TryGet(int id, out Division division)
        {
            division = _serviceCollection.Divisions.Get(id);
            return division != null;
        }

        /// <summary>
        /// Добавление подразделения
        /// </summary>
        /// <param name="division">Подразделение, которое нужно добавить</param>
        public int Add(Division division)
        {
            if (division.Id != 0)
                throw new ArgumentException("Division Id is not 0");

            var subDivisions = division.SubDivisions.ToList();
            division.SubDivisions = new List<Division>();

            var id = _serviceCollection.Divisions.Add(division);

            foreach (var subDivision in subDivisions)
            {
                var dbDivision = _serviceCollection.Divisions.Get(subDivision.Id);

                if (dbDivision is null)
                {
                    _logger.LogWarning("One of subdivisions is null");
                    continue;
                }

                var parentDivision = dbDivision.ParentDivision;

                parentDivision?.SubDivisions.Remove(dbDivision);

                dbDivision.DivisionId = id;
                dbDivision.ParentDivision = division;

                _serviceCollection.Divisions.SaveAndUpdate(dbDivision);
            }

            return id;
        }

        /// <summary>
        /// Удаление подразделения
        /// </summary>
        /// <param name="id">Идентификатор подразделения, которое нужно удалить</param>
        public void Delete(int id)
        {
            //Todo: тут 2 раза получаем напрямую из бд
            var division = _serviceCollection.Divisions.Get(id, true);

            var subDivisions = _serviceCollection.Divisions.GetAll(d => d.DivisionId == id);
            if (subDivisions != null)
            {
                foreach (var subDivision in subDivisions)
                {
                    subDivision.DivisionId = null;
                    subDivision.ParentDivision = null;
                    _serviceCollection.Divisions.SaveAndUpdate(subDivision);
                }
            }

            var employeesForDelete = _serviceCollection.Employees.GetByDivisionId(id);
            if (employeesForDelete.Any())
            {
                employeesForDelete.ToList().ForEach(e => _serviceCollection.Employees.Delete(e.Id));
            }

            division.DivisionId = null;
            _serviceCollection.Divisions.SaveAndUpdate(division);
            _serviceCollection.Divisions.Delete(division.Id);


            if (subDivisions == null) return;

            foreach (var subDivision in subDivisions)
            {
                _serviceCollection.Divisions.SaveAndUpdate(subDivision);
            }
        }

        /// <summary>
        /// Изменение подразделения
        /// </summary>
        /// <param name="division">Модель подразделения</param>
        public void Edit(Division division)
        {
            var subDivisionIds = division.SubDivisions.Select(d => d.Id).ToList();

            division.SubDivisions = new List<Division>();

            _serviceCollection.Divisions.SaveAndUpdate(division);

            foreach (var subDivisionId in subDivisionIds)
            {
                var subDivision = _serviceCollection.Divisions.Get(subDivisionId);
                if (subDivision is null)
                {
                    _logger.LogWarning($"One of subdivisions is null by Id={subDivisionId}");
                    continue;
                }

                subDivision.DivisionId = division.Id;
                subDivision.ParentDivision = null;

                _serviceCollection.Divisions.SaveAndUpdate(subDivision);
            }

            var subDivisionsFromDb = _serviceCollection.Divisions.GetAll(d => d.DivisionId == division.Id, true);
            foreach (var subDivisionFromDb in subDivisionsFromDb)
            {
                if (subDivisionIds.Any(id => id == subDivisionFromDb.Id)) 
                    continue;

                subDivisionFromDb.DivisionId = null;
                _serviceCollection.Divisions.SaveAndUpdate(subDivisionFromDb);
            }

            _serviceCollection.Divisions.Save();
        }
    }
}