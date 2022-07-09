using System;

namespace TestTask.Client.Services
{
    public class EventAggregator
    {
        public event Action DivisionCollectionChanged;

        public void InvokeDivisionCollectionChanged()
        {
            DivisionCollectionChanged?.Invoke();
        }
    }
}