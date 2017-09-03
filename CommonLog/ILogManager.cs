using System;
namespace CommonLog
{
    public interface ILogManager
    {
        ILogger GetLogger(Type type);
    }
}
