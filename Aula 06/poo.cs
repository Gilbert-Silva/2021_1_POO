using System;

class MainClass {
  public static void Main() {
    int x = 5;
    int y = x;
    Console.WriteLine(x);
    Console.WriteLine(y);

    Produto w = null;
    Console.WriteLine(w);

    Produto p = new Produto();
    Console.WriteLine(p);
    p.Nome = "Arroz";
    p.SetPreco(3);
    Console.WriteLine(p);

    Produto s = p;
    s.Nome = "Feijao";
    Console.WriteLine(p);

    Produto q = new Produto("Biscoito");
    Console.WriteLine(q);
    q.SetPreco(-5);
    Console.WriteLine(q);

    Produto r = new Produto("Refrigerante", 5);
    Console.WriteLine(r);
    Console.WriteLine(r.ToString());
    Console.WriteLine(r.GetPreco());

    Cliente cliente = new Cliente();
    Console.WriteLine(cliente);
  }
}

class Produto {
  public string Nome = "Sem nome";      // Atributo - Dados
  private double Preco;
  public Produto() { }
  public Produto(string n) {
    Nome = n;
  }
  public Produto(string n, double p) {
    Nome = n;
    if (p > 0) Preco = p;
  }
  public override string ToString() {   // Método - Operação
    return Nome + " " + Preco;
  }
  public void SetPreco(double Preco) {
    if (Preco > 0) this.Preco = Preco;
  }
  public double GetPreco() {
    return Preco;
  }
}
