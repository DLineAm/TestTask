using System;
using System.Collections.Generic;

namespace TestTask.Shared
{
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

        public Employee(string firstName, string middleName, string lastName, int divisionId, int genderId)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            DivisionId = divisionId;
            GenderId = genderId;
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
        public bool HasDriverLicense { get; set; }
        public int DivisionId { get; set; }

        public string FullName => LastName + " " + FirstName + " " + MiddleName; 

        public Division Division { get; set; }
        public Gender Gender { get; set; }
    }

    public class Gender
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}