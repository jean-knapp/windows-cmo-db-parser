using System;

namespace cmo_db_parser
{
    public static class ConsoleExtensions
    {
        public static void Pause()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
