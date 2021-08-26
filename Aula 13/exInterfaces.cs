using System;
using System.Collections;

class MainClass {
  public static void Main() {
    /*
    string a = "100";
    string b = "20";
    int c = 100;
    int d = 20;
    Console.WriteLine(a.CompareTo(b));
    Console.WriteLine(c.CompareTo(d));
    IComparable x = "Felipe";
    IComparable y = "Virginia";
    //IComparable z = 30;
    Console.WriteLine(x.CompareTo(y));
    Console.WriteLine(a[1]);
    //Console.WriteLine(x[1]);
    */
    string[] s = { "100", "20", "AAA", "ZZZ", "bbb"};
    Array.Sort(s);
    foreach(string w in s) Console.WriteLine(w);

    Aluno a1 = new Aluno { Nome = "AAA", Matricula = "123", Nascimento = DateTime.Parse("1990-1-1"), Altura = 170 };
    Aluno a2 = new Aluno { Nome = "ZZZ", Matricula = "124", Nascimento = DateTime.Parse("1992-1-1"), Altura = 180 };
    Aluno a3 = new Aluno { Nome = "SSS", Matricula = "121", Nascimento = DateTime.Parse("1994-1-1"), Altura = 175 };

    Aluno[] a = { a1, a2, a3 };
    Array.Sort(a);
    foreach(Aluno aluno in a) Console.WriteLine(aluno);

    //a1.CompareTo(a2);
    //a1.CompareTo(a3);
    //a2.CompareTo(a3);

    CompNascimento c = new CompNascimento();
    Array.Sort(a, c);
    foreach(Aluno aluno in a) Console.WriteLine(aluno);
    //c.Compare(a1, a2);
    //c.Compare(a1, a3);
    //c.Compare(a2, a3);

  }
}

class CompNascimento : IComparer {
  public int Compare(object obj1, object obj2) {
    Aluno x = (Aluno) obj1;
    Aluno y = (Aluno) obj2;
    return x.Nascimento.CompareTo(y.Nascimento); 
  }
}

class Aluno : IComparable {
  public string Nome {get;set;}
  public string Matricula {get;set;}
  public DateTime Nascimento {get;set;}
  public int Altura {get;set;}

  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj;
    //return this.Nome.CompareTo(x.Nome);
    if (this.Altura > x.Altura) return -1;
    if (this.Altura < x.Altura) return 1;
    return 0;
  }

  public override string ToString() {
    return Nome + " - " + Matricula + " - " + Nascimento.ToString("dd/MM/yyyy") + " - " + Altura;
  }

}

