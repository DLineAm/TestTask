using System;

namespace TestTask.Client.Services
{
    /// <summary>
    /// Класс, хранящий в себе события, требуемые для некоторых страниц
    /// </summary>
    public class EventAggregator
    {
        /// <summary>
        /// Событие, возникающее при изменении коллекции подразделений
        /// </summary>
        public event Action DivisionCollectionChanged;

        /// <summary>
        /// Вызов события DivisionCollectionChanged
        /// </summary>
        public void InvokeDivisionCollectionChanged()
        {
            DivisionCollectionChanged?.Invoke();
        }
    }
}