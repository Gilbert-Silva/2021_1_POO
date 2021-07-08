using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite uma lista de notas");
    string notas = Console.ReadLine();
    Console.WriteLine("Digite uma lista de nomes");
    string nomes = Console.ReadLine();
    string s = NotasAbaixoMedia(notas, nomes);
    Console.WriteLine(s);
  }

  public static string NotasAbaixoMedia(string notas, string nomes) {
    int media = Media(notas);
    string[] v = notas.Split(','); // notas
    string[] w = nomes.Split(','); // nomes
    string s = "";
    for (int i = 0; i < v.Length; i++) {
      if (int.Parse(v[i]) < media)
        s = s + w[i] + ",";
    }
    s = s.Remove(s.Length-1);
    return s;
  }

  public static int Media(string lista) {
    string[] v = lista.Split(',');
    int soma = 0;
    foreach (string x in v) {
      soma = soma + int.Parse(x);
    }
    return soma/v.Length;
  }
}

