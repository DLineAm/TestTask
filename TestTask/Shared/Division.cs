using System;
using System.Collections.Generic;

#nullable enable

namespace TestTask.Shared
{
    /// <summary>
    /// Подразделение сотрудников
    /// </summary>
    public class Division : IIdentity
    {
        private readonly bool _isCopied;

        public Division()
        {
            
        }

        /// <summary>
        /// Конструктор, принимающий подразделение для копирования данных со свойств этого подазделения
        /// </summary>
        public Division(Division? division)
        {
            if (division == null)
            {
                return;
            }

            Title = division.Title;
            CreateDate = division.CreateDate;
            Description = division.Description;
            DivisionId = division.DivisionId;
            Employees = division.Employees;
            ParentDivision = division.ParentDivision;
            SubDivisions = division.SubDivisions;
            Id = division.Id;
            _isCopied = true;
        }

        /// <summary>
        /// Получает информацию о том, были ли скопированы данные со свойств другого подразделения
        /// </summary>
        /// <returns>True, если данные были скопированы. False, если нет</returns>
        public bool CheckCopied()
        {
            return _isCopied;
        }

        /// <summary>
        /// Идентификатор подразделения
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Наименование подразделения
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Дата создания подразделения
        /// </summary>
        public DateTime CreateDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Описание подразделения
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// Идентификатор родительского подразделения
        /// </summary>
        public int? DivisionId { get; set; }

        /// <summary>
        /// Родительское подразделение
        /// </summary>
        public Division? ParentDivision { get; set; }

        /// <summary>
        /// Сотрудники, прикрепленные к этому подразделению
        /// </summary>
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();

        /// <summary>
        /// Дети подразделения
        /// </summary>
        public ICollection<Division> SubDivisions { get; set; } = new List<Division>();

        /// <summary>
        /// Проверяет, является ли подразделение division родительским
        /// </summary>
        /// <param name="division"></param>
        /// <returns>True, если подразделение division является родительким. False, если нет</returns>
        public bool HasParent(Division division)
        {
            return division.Id == DivisionId || ParentDivision?.HasParent(division) != null;
        }
    }
}