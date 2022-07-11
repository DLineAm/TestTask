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

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public int GenderId { get; set; } = 1;
        /// <summary>
        /// Имеет ли сотрудник водительское удостоверение
        /// </summary>
        public bool HasDriverLicense { get; set; }
        public int DivisionId { get; set; }

        public string FullName => LastName + " " + FirstName + " " + MiddleName; 

        /// <summary>
        /// Подразделение сотрудника
        /// </summary>
        public Division Division { get; set; }
        public Gender Gender { get; set; }
    }
}