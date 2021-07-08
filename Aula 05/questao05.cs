using System;

class MainClass {
  /*
  public static void Main() {
    Console.WriteLine("Digite uma lista de valores");
    string lista = Console.ReadLine();
    string[] v = lista.Split(',');
    int soma = 0;
    foreach (string x in v) {
      soma = soma + int.Parse(x);
    }
    Console.WriteLine(soma/v.Length);
  }
  */
  public static void Main() {
    Console.WriteLine("Digite uma lista de valores");
    string lista = Console.ReadLine();
    int media = Media2(lista);
    Console.WriteLine(media);
  }

  public static int Media(string lista) {
    string[] v = lista.Split(',');
    int soma = 0;
    foreach (string x in v) {
      soma = soma + int.Parse(x);
    }
    return soma/v.Length;
  }

  public static int Media2(string lista) {
    // 10,20,30,40,
    // 012345678902
    lista = lista + ',';
    int p = lista.IndexOf(',');
    int soma = 0;
    int k = 0;
    while (p != -1) {
      soma = soma + int.Parse(lista.Substring(0, p));
      lista = lista.Substring(p+1);
      p = lista.IndexOf(',');
      k++;
    }
    return soma/k;
  }


}