using System;

class MainClass {
  public static void Main() {
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w = new int[10];
    foreach (int i in v)  Console.Write(i + " ");
    Console.WriteLine();

    foreach (int i in w)  Console.Write(i + " ");
    Console.WriteLine();

    Array.Copy(v, w, 5);
    foreach (int i in w)  Console.Write(i + " ");
    Console.WriteLine();

    int[] x = { -1, -2, -3 };
    x.CopyTo(w, 6);     
    foreach (int i in w)  Console.Write(i + " ");
    Console.WriteLine();

    foreach (int i in x)  Console.Write(i + " ");
    Console.WriteLine();

    object obj = x.Clone();
    Console.WriteLine(obj);

    int[] y = (int[]) obj;
    foreach (int i in y)  Console.Write(i + " ");
    Console.WriteLine();

    x[0] = 20;
    foreach (int i in x)  Console.Write(i + " ");
    Console.WriteLine();
    foreach (int i in y)  Console.Write(i + " ");
    Console.WriteLine();

    Pessoa p1 = new Pessoa();
    p1.Nome = "a";
    Pessoa p2 = new Pessoa();
    p2.Nome = "b";

    Pessoa[] xp = new Pessoa[2];
    xp[0] = p1;
    xp[1] = p2;
     
    foreach (Pessoa p in xp) Console.Write(p + " ");
    Console.WriteLine();

    object obj2 = xp.Clone();
    Pessoa[] yp = (Pessoa[]) obj2;
    yp[0].Nome = "c";

    foreach (Pessoa p in xp) Console.Write(p + " ");
    Console.WriteLine();
  }
}

class Pessoa {
  public string Nome;
  public override string ToString() {
    return Nome;
  }
}