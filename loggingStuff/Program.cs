using System;
using CommonLog;

namespace loggingStuff
{
    class MainClass
    {
		
        public static void Main(string[] args)
        {
            var program = new MainClass();
            program.Run();
            Console.ReadLine();
        }

        void Run()
        {
            using (this.Log().Activity("Run"))
            {
                this.Log().Debug(() => string.Format("Hello World {0}", 2));
            }
        }
    }
}
