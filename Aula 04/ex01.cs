using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite o nome do estado");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite o número de habitantes");
    int hab = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite a área dp estado em km2");
    double area = double.Parse(Console.ReadLine());
    double dens = hab/area;
    Console.WriteLine($"A densidade demográfica do(a) {nome} é de {dens:0.0} hab/km2");
    Console.WriteLine("A densidade demográfica do(a) {0} é de {1:0.0} hab/km2", nome, dens);
    Console.WriteLine("A densidade demográfica do(a) {0} é de {1:f1} hab/km2", nome, dens);
    Console.WriteLine("A densidade demográfica do(a) " + nome+ " é de " + dens.ToString("0.0") + " hab/km2");
  }
}