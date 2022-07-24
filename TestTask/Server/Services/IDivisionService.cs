using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    /// <summary>
    /// Сервис подразделений
    /// </summary>
    public interface IDivisionService
    {
        IEnumerable<Division> Get();
        bool TryGet(int id, out Division value);
        int Add(Division item);
        void Edit(Division item);
        void Delete(int id);
    }
}