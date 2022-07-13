using System;
using TestTask.Server.DAL.Context;
using TestTask.Shared;

namespace TestTask.Server.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext _context;

        private Repository<Division> _divisionRepository;
        private Repository<Employee> _employeeRepository;
        private Repository<Gender> _genderRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Репозиторий подразделений
        /// </summary>
        public Repository<Division> DivisionRepository => _divisionRepository
        ??= new Repository<Division>(_context);

        /// <summary>
        /// Репозиторий сотрудников
        /// </summary>
        public Repository<Employee> EmployeeRepository => _employeeRepository
            ??= new Repository<Employee>(_context);

        /// <summary>
        /// Репозиторий гендеров
        /// </summary>
        public Repository<Gender> GenderRepository => _genderRepository
            ??= new Repository<Gender>(_context);

        /// <summary>
        /// Фиксация изменений в бд
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}