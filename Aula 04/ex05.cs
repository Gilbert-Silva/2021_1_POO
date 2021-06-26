using System;
//using System.Globalization;

class MainClass {
  public static void Main() {
    //Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine(Data.UltimoDia(6, 2021));
    DateTime d = DateTime.Parse("2021-06-30");
    Console.WriteLine(d);
    Console.WriteLine(d.ToString("dd"));
    Console.WriteLine(d.ToString("ddd"));
    Console.WriteLine(d.ToString("dddd"));
  }
}

class Data {
  public static string UltimoDia(int mes, int ano)
  {
    int max = 31;
    switch(mes) {
      case 2: if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0)) max = 29;
              else max = 28; 
              break;
      case 4:
      case 6:
      case 9:
      case 11: max = 30; break;
    }
    //string s = max.ToString("00") + "/" + mes.ToString("00") + "/" + ano.ToString("0000");
    string s = $"{max:00}/{mes:00}/{ano:0000}";
    return s;
  }
}