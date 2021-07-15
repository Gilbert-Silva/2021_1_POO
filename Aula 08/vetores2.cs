using System;

class MainClass {
  public static void Main() {
    int[] v = { 6, 4, 1, 2, 5, 63, 71, 18, 91, 10 };
    Array.Sort(v);
    foreach (int i in v)  Console.Write(i + " ");
    Console.WriteLine();

    string[] vs = { "x", "b", "r"};
    Array.Sort(vs);
    foreach (string s in vs)  Console.Write(s + " ");
    Console.WriteLine();

    Pessoa p1 = new Pessoa(); p1.Nome = "x";
    Pessoa p2 = new Pessoa(); p2.Nome = "b";
    Pessoa p3 = new Pessoa(); p2.Nome = "r";

    Pessoa[] xp = new Pessoa[3];
    xp[0] = p1;
    xp[1] = p2;
    xp[2] = p3;

    Array.Sort(xp);
    foreach (Pessoa p in xp)  Console.Write(p + " ");
    Console.WriteLine();

  }
}

class Pessoa {
  public string Nome;
  public override string ToString() {
    return Nome;
  }
}