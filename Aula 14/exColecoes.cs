using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main() {

    ArrayList x = new ArrayList();
    x.Add(1);
    x.Add("C#");
    x.Add(3.5);
    x.Add(false);
    x.Add(new Escola { Nome = "IFRN" });

    foreach(object obj in x) Console.WriteLine(obj);
    Console.WriteLine(x[0]);
    Console.WriteLine(x[2]);
    Console.WriteLine((int)x[0] + (double)x[2]);

    List<int> y = new List<int>();
    y.Add(1);
    y.Add(2);
    Console.WriteLine(y[0]+y[1]);

    //int d = int.Parse(Console.ReadLine());
    int d = 25;
    Stack<int> pilha = new Stack<int>();
    while (d >= 1) {
      int r = d % 2;
      pilha.Push(r);
      d = d / 2;
    }
    while (pilha.Count > 0)
      Console.Write(pilha.Pop());
    Console.WriteLine();  

    SortedSet<int> s = new SortedSet<int>();
    s.Add(10);
    s.Add(1);
    s.Add(20);
    s.Add(14);
    s.Add(11);
    s.Add(30);

    foreach(int i in s) 
      Console.WriteLine(i);
    }

}

class Escola {
  public string Nome { get; set; }
  public override string ToString() {
    return Nome;
  }
}