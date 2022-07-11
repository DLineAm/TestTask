using System;
using System.Collections.Generic;

#nullable enable

namespace TestTask.Shared
{
    /// <summary>
    /// Подразделение сотрудников
    /// </summary>
    public class Division
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование подразделения
        /// </summary>
        public string? Title { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Описание подразделения
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Id родительского подразделения
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
    }
}