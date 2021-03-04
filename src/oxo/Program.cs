using System;
using System.Reflection;

namespace oxo
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        var versionString = Assembly.GetEntryAssembly()
                                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                                .InformationalVersion
                                .ToString();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("**");
        Console.WriteLine($"oxo v{versionString}");
        Console.WriteLine("**");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nUsage:");
        Console.WriteLine("  botsay <message>");
        Console.WriteLine("");
        return;
      }
    }
  }
}
