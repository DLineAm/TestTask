using System;
using System.Collections.Generic;
using System.Linq;
using TestTask.Shared;

namespace TestTask.Server.DAL.Context
{
    public class DatabaseInitializer
    {
        public static void InitializeDatabase(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            var divisions = InitializeDivisions(context);

            var (mGenderId, fGenderId) = InitializeGenders(context);

            InitializeEmployees(context, divisions, mGenderId, fGenderId);
        }

        private static IEnumerable<Division> InitializeDivisions(DatabaseContext context)
        {
            if (context.Divisions.Any())
            {
                return context.Divisions.ToList();
            }

            var mainDivision = new Division {Title = "Председатель комитета", CreateDate = new DateTime(1990, 3, 15)};

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

        private static T CreateEntity<T>(T entity, DatabaseContext context) where T : class
        {
            var savedEntity = context.Set<T>().Add(entity);
            context.SaveChanges();
            return savedEntity.Entity;
        }

        private static (int, int) InitializeGenders(DatabaseContext context)
        {
            if (context.Genders.Any())
            {
                var mId = context.Genders.ToList().ElementAt(0).Id;
                var fId = context.Genders.ToList().ElementAt(1).Id;

                return (mId, fId);
            }
            var mGender = new Gender {Title = "М"};
            mGender = context.Genders.Add(mGender).Entity;
            var fGender = new Gender {Title = "Ж"};
            fGender = context.Genders.Add(fGender).Entity;

            context.SaveChanges();

            return (mGender.Id, fGender.Id);
        }

        private static void InitializeEmployees(DatabaseContext context, IEnumerable<Division> divisions, int mGenderId, int fGenderId)
        {
            if (context.Employees.Any())
            {
                return;
            }

            var employees = new List<Employee>
            {
                new Employee("София", "Максимовна", "Галкина", divisions.First(), fGenderId, new DateTime(1990, 8, 23)),
                new Employee("Валерия", "Матвеевна", "Суханова", divisions.ElementAt(1), fGenderId, new DateTime(1991, 10, 10), true),
                new Employee("Андрей", "Николаевич", "Чернышев", divisions.ElementAt(2), mGenderId, new DateTime(1996, 10, 22)),
                new Employee("Дмитрий", "Михайлович", "Морозов", divisions.ElementAt(2), mGenderId, new DateTime(1995, 1, 6), true),
                new Employee("Елизавета", "Руслановна", "Шарова", divisions.ElementAt(3), fGenderId, new DateTime(1999, 7, 9)),
                new Employee("Мария", "Андреевна", "Данилова", divisions.ElementAt(3), fGenderId, new DateTime(1997, 4, 29)),
                new Employee("Мила", "Данииловна", "Жукова", divisions.ElementAt(5), fGenderId, new DateTime(1989, 8, 31)),
                new Employee("Александр", "Иванович", "Рыбаков", divisions.ElementAt(5), mGenderId, new DateTime(1995, 2, 21), true),
                new Employee("Владимир", "Матвеевич", "Лебедев", divisions.ElementAt(6), mGenderId, new DateTime(1985, 5, 13)),
                new Employee("Всеволод", "Михайлович", "Андреев", divisions.ElementAt(6), mGenderId, new DateTime(2001, 8, 17), true),
            };

            foreach (var employee in employees)
            {
                context.Employees.Add(employee);
            }

            context.SaveChanges();
        }
    }
}