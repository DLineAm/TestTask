using System.Collections.Generic;
using TestTask.Shared;

namespace TestTask.Server.Services
{
    public interface IMaybeGettable<T>
    {
        bool TryGet(int id, out T value);
    }

    public interface IGettableWithParameter<T>{
        IEnumerable<T> GetWithParameter(object param);
    }

    public interface IMultiGettable<T>
    {
        IEnumerable<T> Get();
    }

    public interface IAddable<T>
    {
        void Add(T item);
    }

    public interface IChangeable<T>
    {
        void Change(T item, T itemToChange);
    }

    public interface IDeletable<T>
    {
        void Delete(T item);
    }

    public interface IWritable<T> : IAddable<T>, IChangeable<T>, IDeletable<T>{}

    public interface IDivisionService : IMultiGettable<Division>, IMaybeGettable<Division>, IWritable<Division> { }

    public interface IEmployeeService : IMaybeGettable<Employee>, IGettableWithParameter<Employee>, IWritable<Employee>{}

    public interface IGenderService : IMultiGettable<Gender>{}
}