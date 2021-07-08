using System;

class MainClass {
  public static void Main() {
    int x = 5;  // x é uma instância do tipo inteiro
    int y = 15; // y é uma instância do tipo inteiro

    Produto p = new Produto();
    // p = Produto()
    p.Nome = "Arroz";
    //p.Preco = 3;
    p.SetPreco(3);

    Produto q = new Produto();
    q.Nome = "Biscoito";
    q.SetPreco(-5);

    Console.WriteLine(x);
    Console.WriteLine(y);
    //Console.WriteLine(p.GetType());
    Console.WriteLine(p.ToString());
    Console.WriteLine(q.ToString());
  }
}

class Produto {
  public string Nome;                   // Atributo - Dados
  private double Preco = 10;
  public override string ToString() {   // Método - Operação
    return Nome + " " + Preco;
  }
  public void SetPreco(double v) {
    if (v > 0) Preco = v;
  }
}