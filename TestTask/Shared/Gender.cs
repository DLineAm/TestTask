using System.Collections.Generic;

namespace TestTask.Shared
{
    public class Gender
    {
        /// <summary>
        /// Идентификатор гендера
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Наименование гендера
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Сотрудники, прикрепленные к этому гендеру
        /// </summary>
        public ICollection<Employee> Employees { get; set; }
    }
}