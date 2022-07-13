#nullable enable
using System;

namespace TestTask.Shared
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee
    {
        public Employee(string firstName, string middleName, string lastName, Division division, int genderId, DateTime dateOfBirth, bool hasDriverLicense = false)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Division = division;
            GenderId = genderId;
            HasDriverLicense = hasDriverLicense;
            DateOfBirth = dateOfBirth;
        }

        public Employee()
        {
        }

        /// <summary>
        /// Идентификатор сотрудника
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя сотрудника
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество сотрудника
        /// </summary>
        public string? MiddleName { get; set; }

        /// <summary>
        /// Фамилия сотрудника
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Дата рождения сотрудника
        /// </summary>
        public DateTime DateOfBirth { get; set; } = DateTime.Now;

        /// <summary>
        /// Идентификатор гендера сотрудника
        /// </summary>
        public int GenderId { get; set; } = 1;

        /// <summary>
        /// Имеет ли сотрудник водительское удостоверение
        /// </summary>
        public bool HasDriverLicense { get; set; }

        /// <summary>
        /// Идентификатор подразделения сотрудника
        /// </summary>
        public int? DivisionId { get; set; }

        public string FullName => LastName + " " + FirstName + " " + MiddleName; 

        /// <summary>
        /// Подразделение сотрудника
        /// </summary>
        public Division? Division { get; set; }
        /// <summary>
        /// Гендер сотрудника
        /// </summary>
        public Gender Gender { get; set; }
    }
}