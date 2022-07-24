using System;
using System.Collections.Generic;
using System.Linq;

using TestTask.Shared;

namespace TestTask.Server.DAL.Context
{
    /// <summary>
    /// Класс, заполяющий базу данных тестовыми данными
    /// </summary>
    public class DatabaseInitializer : IDataInitializer
    {
        /// <summary>
        /// Заполняет базу данных тестовыми данными
        /// </summary>
        /// <param name="context"></param>
        public void Initialize(DatabaseContext context)
        {
            var divisions = InitializeDivisions(context);

            InitializeEmployees(context, divisions);
        }

        /// <summary>
        /// Заполняет таблицу подразделений тестовыми даными
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        private IEnumerable<Division> InitializeDivisions(DatabaseContext context)
        {
            if (context.Divisions.Any())
                return context.Divisions.ToList();

            var mainDivision = new Division { Title = "Председатель комитета", CreateDate = new DateTime(1990, 3, 15) };

            mainDivision = CreateEntity(mainDivision, context);

            var subDivision = new Division
            {
                Title = "Заместитель председателя комитета",
                DivisionId = mainDivision.Id,
                CreateDate = new DateTime(1990, 3, 15)
            };

            subDivision = CreateEntity(subDivision, context);

            var subDivisionChild = new Division
            {
                Title = "Управление торгов и подготовки производства",
                ParentDivision = subDivision,
                CreateDate = new DateTime(1990, 3, 15)
            };

            subDivisionChild = CreateEntity(subDivisionChild, context);

            var divisions = new[]
            {
                new Division {Title = "Отдел финансирования и бюджетного учета", ParentDivision = mainDivision, CreateDate = new DateTime(1995, 10, 12)},
                new Division {Title = "Отдел правовой работы и экономической политики", ParentDivision = subDivision, CreateDate = new DateTime(1995, 10 ,12)},
                new Division {Title = "Отдел торгов и закупок", ParentDivision = subDivisionChild, CreateDate = new DateTime(1995, 10 ,12)},
                new Division {Title = " Производственно-технический отдел", ParentDivision = subDivisionChild, CreateDate = new DateTime(1995, 10 ,12)}
            };

            foreach (var division in divisions)
            {
                context.Divisions.Add(division);
                context.SaveChanges();
            }


            return context.Divisions.ToList();
        }

        /// <summary>
        /// Создает запись и сохраняет ее в бд
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        private T CreateEntity<T>(T entity, DatabaseContext context) where T : class
        {
            var savedEntity = context.Set<T>().Add(entity);
            context.SaveChanges();
            return savedEntity.Entity;
        }

       
        /// <summary>
        /// Заполняет таблицу сотрудников тестовыми данными
        /// </summary>
        /// <param name="context"></param>
        /// <param name="divisions"></param>
        private void InitializeEmployees(DatabaseContext context, IEnumerable<Division> divisions)
        {
            if (context.Employees.Any())
                return;

            var genders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToArray();

            var employees = new List<Employee>
            {
                new Employee("София", "Максимовна", "Галкина", divisions.First(), genders[1], new DateTime(1990, 8, 23)),
                new Employee("Валерия", "Матвеевна", "Суханова", divisions.ElementAt(1), genders[1], new DateTime(1991, 10, 10), true),
                new Employee("Андрей", "Николаевич", "Чернышев", divisions.ElementAt(2), genders[0], new DateTime(1996, 10, 22)),
                new Employee("Дмитрий", "Михайлович", "Морозов", divisions.ElementAt(2), genders[0], new DateTime(1995, 1, 6), true),
                new Employee("Елизавета", "Руслановна", "Шарова", divisions.ElementAt(3), genders[1], new DateTime(1999, 7, 9)),
                new Employee("Мария", "Андреевна", "Данилова", divisions.ElementAt(3), genders[1], new DateTime(1997, 4, 29)),
                new Employee("Мила", "Данииловна", "Жукова", divisions.ElementAt(5), genders[1], new DateTime(1989, 8, 31)),
                new Employee("Александр", "Иванович", "Рыбаков", divisions.ElementAt(5), genders[0], new DateTime(1995, 2, 21), true),
                new Employee("Владимир", "Матвеевич", "Лебедев", divisions.ElementAt(6), genders[0], new DateTime(1985, 5, 13)),
                new Employee("Всеволод", "Михайлович", "Андреев", divisions.ElementAt(6), genders[0], new DateTime(2001, 8, 17), true),
            };

            foreach (var employee in employees)
            {
                context.Employees.Add(employee);
            }

            context.SaveChanges();
        }
    }
}