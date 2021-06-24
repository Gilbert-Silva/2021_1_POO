using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite um número entre 1 e 12");
    int x = int.Parse(Console.ReadLine());
    /*
    if (x == 1) Console.WriteLine("Janeiro");
    if (x == 2) Console.WriteLine("Fevereiro");
    if (x == 12) Console.WriteLine("Dezembro");
    if (x < 1 || x > 12) Console.WriteLine("Valor inválido");
    
    if (x == 1) Console.WriteLine("Janeiro");
    else
      if (x == 2) Console.WriteLine("Fevereiro");
      else
        if (x == 12) Console.WriteLine("Dezembro");
        else
          Console.WriteLine("Valor inválido");
    */
    switch (x) {
      case 1 : Console.WriteLine("Janeiro"); return;
      case 2 : Console.WriteLine("Fevereiro"); break;
      case 12 : Console.WriteLine("Dezembro"); throw new Exception("Erro");
      default : Console.WriteLine("Valor inválido"); break;
    }
    Console.WriteLine("Teste");
    switch (x.ToString()) {
      case "1" : Console.WriteLine("Janeiro"); return;
    }
  }
}
