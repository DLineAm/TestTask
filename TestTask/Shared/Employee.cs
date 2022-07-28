#nullable enable
using System;

namespace TestTask.Shared
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : IIdentity
    {
        private readonly bool _isInitialized;

        public Employee(string firstName, string middleName, string lastName, Division division,Gender gender ,DateTime dateOfBirth, bool hasDriverLicense = false)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Division = division;
            Gender = gender;
            HasDriverLicense = hasDriverLicense;
            DateOfBirth = dateOfBirth;
        }

        public Employee(Employee? employee)
        {
            if (employee == null)
            {
                return;
            }

            FirstName = employee.FirstName;
            MiddleName = employee.MiddleName;
            LastName = employee.LastName;
            DateOfBirth = employee.DateOfBirth;
            Gender = employee.Gender;
            Division = employee.Division;
            DivisionId = employee.DivisionId;
            HasDriverLicense = employee.HasDriverLicense;
            Id = employee.Id;
            _isInitialized = true;
        }

        public Employee()
        {
        }

        public bool CheckInitialize()
        {
            return _isInitialized;
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
        /// Имеет ли сотрудник водительское удостоверение
        /// </summary>
        public bool HasDriverLicense { get; set; }

        /// <summary>
        /// Идентификатор подразделения сотрудника
        /// </summary>
        public int? DivisionId { get; set; }

        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string FullName => LastName + " " + FirstName + " " + MiddleName; 

        /// <summary>
        /// Подразделение сотрудника
        /// </summary>
        public Division? Division { get; set; }

        /// <summary>
        /// Гендер сотрудника
        /// </summary>
        public Gender Gender { get; set; } = Gender.Male;
    }
}