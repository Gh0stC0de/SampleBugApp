using System;
using Prism.Logging;

namespace SampleBugApp.Adapters
{
    public class MyLoggerAdapter : ILoggerFacade
    {
        public void Log(string message, Category category, Priority priority)
        {
            Console.WriteLine(
                $"{Enum.GetName(typeof(Category), category)}|{Enum.GetName(typeof(Priority), priority)}|{message}");
        }
    }
}