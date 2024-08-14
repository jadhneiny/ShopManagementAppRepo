using System.Runtime.CompilerServices;

namespace ShopManagementApp.Common.Utilities;

public class AsyncLazy<T> : Lazy<Task<T>>
{
    public TaskAwaiter<T> GetAwaiter() { return Value.GetAwaiter(); }
    public AsyncLazy(Func<T> valueFactory) : base(() => Task.Run(valueFactory)) { }
    public AsyncLazy(Func<Task<T>> valueFactory) : base(() => Task.Run(valueFactory)) { }
}
