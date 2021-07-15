using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Informe uma data yyyy-mm-dd");
    string s = Console.ReadLine();
    DateTime x = DateTime.Parse(s);
    Console.WriteLine(x);
    x = x.AddDays(1);
    Console.WriteLine(x.Day);
    Console.WriteLine($"{x:dd}");
    Console.WriteLine($"{x:ddd}");
    Console.WriteLine($"{x:dddd}");
    Console.WriteLine($"{x:dddd/MMM/yyyy}");
    x = DateTime.Now;
    Console.WriteLine(x);
  }
}