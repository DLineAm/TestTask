using System.Collections.Generic;

namespace TestTask.Shared
{
    public class Gender
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}