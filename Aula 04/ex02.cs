using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite uma frase:");
    string frase = Console.ReadLine();
    // Separando a frase em palavras com Split
    string[] v = frase.Split();
    foreach (string palavra in v)
      Console.Write(palavra.Length);
    Console.WriteLine();  
    // Percorrer a frase buscando os espaços
    int k = 0;
    foreach (char c in (frase + " ")) {
      if (c == ' ') {
        Console.Write(k);
        k = 0;
      }
      else 
        k++;
    }
  }
}