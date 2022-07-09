using System;
using System.Collections.Generic;
using Newtonsoft.Json;

#nullable enable

namespace TestTask.Shared
{
    public class Division
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public int? DivisionId { get; set; }

        public Division? ParentDivision { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public ICollection<Division> SubDivisions { get; set; } = new List<Division>();
    }
}