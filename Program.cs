using System;

namespace PopovaM.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.UserDomainName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.Version);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.CurrentManagedThreadId);
            Console.WriteLine(Environment.ProcessId);
            Console.WriteLine(Environment.ProcessorCount);
            Console.WriteLine(Environment.Is64BitProcess);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
        }
    }
}
