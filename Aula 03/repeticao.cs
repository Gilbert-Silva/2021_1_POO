using System;

class Matematica {
  public static int Subtrair(int x, int y) {
    int z = x - y;
    return z;
  }
}

class MainClass {
  public static int Somar(int x, int y) {
    int z = x + y;
    return z;
  }
  public static void Main() {
    int a = 10;
    int b = 5;
    Console.WriteLine(Somar(a, b));
    Console.WriteLine(MainClass.Somar(a, b));
    Console.WriteLine(Matematica.Subtrair(a, b));
  }
}



    /*
    Console.WriteLine("Digite um valor até 10");
    int x = int.Parse(Console.ReadLine());
    
    int i = 1;
    while (i <= x) {
      Console.WriteLine(i);
      i++; // i = i + 1
    }
    for(int j = 1; j <= x; j++) {
      Console.WriteLine(j);
    }
    int k = 1;
    do {
      Console.WriteLine(k);
      k++; 
    } while (k <= x);
  
    foreach(char c in "Teste")
      Console.WriteLine(c);
   
    int[] v = {1,2,3,4,5};
    foreach(int y in v)
      Console.WriteLine(y);
    
    for(int j = 1; j <= 3; j++) {
      Console.WriteLine(v[j]);
    }
    */
    /*
    int[] v = {1, 20, 3, 14, 5};
    foreach(int y in v)
      Console.WriteLine(y);
    Array.Sort(v);
    foreach(int y in v)
      Console.WriteLine(y);
    Array.Reverse(v);
    foreach(int y in v)
      Console.WriteLine(y);
    //          012345678901234
    string s = "Tecnologia em Análise e Desenvolmento de Sistemas";

    Console.WriteLine(s.Substring(14, 7));

    int x = 5;
    Console.WriteLine(x.ToString() + x.ToString());
    // C++
    // itos(x);
    Console.WriteLine(s);

    Console.WriteLine(Math.Sqrt(16));
    //double z = 16;
    //Console.WriteLine(z.Sqrt());

    WriteLine("Teste");
    //int(input())
    //math.sqrt(16)
  }
  */
