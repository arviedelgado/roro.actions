using System;

namespace Roro.Actions
{
    public interface IActionExecutionContext
    {
        public T GetInstance<T>(Guid id);

        public Guid AddInstance<T>(object obj);

        public bool RemoveInstance(Guid id);

        public bool IsCancellationRequested { get; }
    }
}