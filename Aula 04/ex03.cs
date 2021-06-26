using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite o nome de quatro cidades");
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    string d = Console.ReadLine();
    /*
    if (a > b)
    if (a > c)
    if (a > d)
    if (b > c)
    if (b > d)
    if (c > d)
    */
    // Implementando o algoritmo de ordenação
    if (string.Compare(a, b) > 0) {
      (a, b) = (b, a);
    }
    if (string.Compare(a, c) > 0) {
      string x = a;
      a = c;
      c = x;
    }
    if (string.Compare(a, d) > 0) {
      (a, d) = (d, a);
    }
    if (string.Compare(b, c) > 0) {
      (b, c) = (c, b);
    }
    if (string.Compare(b, d) > 0) {
      (b, d) = (d, b);
    }
    if (string.Compare(c, d) > 0) {
      (c, d) = (d, c);
    }
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine(d);
    // Usando o algoritmo de ordenação da classe Array
    string[] v = { a, b, c, d };
    Array.Sort(v);
    foreach (string s in v)
      Console.WriteLine(s);
    /*
    if (v[0] > v[1])
    if (v[0] > v[2])
    if (v[0] > v[3])
    if (v[1] > v[2])
    if (v[1] > v[3])
    if (v[2] > v[3])

    for (int i = 0; i <= 2; i++)
      for (int j = i + 1; j <= 3; j++)
        if (v[i] > v[j])
    */





  }
}