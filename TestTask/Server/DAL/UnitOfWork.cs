using System;
using TestTask.Server.DAL.Context;
using TestTask.Shared;

namespace TestTask.Server.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext _context;

        private bool _disposed;

        private Repository<Division> _divisionRepository;
        private Repository<Employee> _employeeRepository;
        private Repository<Gender> _genderRepository;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public Repository<Division> DivisionRepository => _divisionRepository
        ??= new Repository<Division>(_context);
        public Repository<Employee> EmployeeRepository => _employeeRepository
            ??= new Repository<Employee>(_context);
        public Repository<Gender> GenderRepository => _genderRepository
            ??= new Repository<Gender>(_context);

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
            }

            this._disposed = true;
        }

        ~UnitOfWork()
        {
            Dispose(true);
        }
    }
}