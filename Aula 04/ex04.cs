using System;

class MainClass {
  public static void Main() {
    Console.WriteLine(MainClass.Soma(1, 10));
    Console.WriteLine(Soma(5, 150));
    int k = Soma(-10, 0);
    Console.WriteLine(k);
    Console.WriteLine(Soma(
      int.Parse(Console.ReadLine()),
      int.Parse(Console.ReadLine())));
  }

  public static int Soma(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++)
      soma = soma + i;
    return soma;
  }
}
