using System;

class MainClass {
  public static void Main() {
    Contato x = new Contato("contato 1", "12345678", "c1@email.com");
    //int.Parse("10000000000");
    //int[] v = { 0, 1, 2 };
    //Console.WriteLine(v[10]);
    //Console.WriteLine(x.GetNome());
    //Console.WriteLine(x.GetFone());
    //Console.WriteLine(x.GetEmail());
    x.Nome = "Felipe";
    Console.WriteLine(x.GetNome());
    Console.WriteLine(x.GetFone());
    Console.WriteLine(x.GetEmail());

    try {
      x.Nascimento = DateTime.Parse("2022-01-01");
    }
    catch {
      Console.WriteLine("A data de nascimento não pode ser no futuro");
    }
    Console.WriteLine(x.Nascimento);

    x.Nascimento = DateTime.Parse("2000-05-08");
    Console.WriteLine(x.Nascimento);
    Console.WriteLine(x.Idade);
    //x.Idade = 20;

    /*
    Contato2 y = new Contato2 { Nome = "contato 1", Fone = "12345678", Email = "c1@email.com" };
    Console.WriteLine(y.Nome);
    Console.WriteLine(y.Fone);
    Console.WriteLine(y.Email);
    y.Nome = "Gilbert";
    Console.WriteLine(y.Nome);
    Console.WriteLine(y.Fone);
    Console.WriteLine(y.Email);
    */
  }
}

class Contato2 {
  public string Nome { get; set; }
  public string Fone { get; set; }
  public string Email { get; set; }
}


class Contato {
  private string nome;
  private string fone;
  private string email;
  private DateTime nascimento;

  public string Nome  { get { return nome; } set { nome = value; } }
  public string Fone  { get => fone; set => fone = value; }
  public string Email { get { return email; } set { email = value; } }
  public int Idade {
    get {
      DateTime hoje = DateTime.Now;
      int anos = hoje.Year - nascimento.Year;
      return anos;
    }
  }

  public DateTime Nascimento { 
    get { return nascimento; } 
    set { 
      DateTime hoje = DateTime.Now;
      if (value < hoje) nascimento = value;
      else
        throw new ArgumentOutOfRangeException("Data inválida");
    }
  }

  public DateTime GetNascimento() {
    return nascimento;
  }

  public void SetNascimento(DateTime value) {
      DateTime hoje = DateTime.Now;
      if (value < hoje) nascimento = value;
      else
        throw new ArgumentOutOfRangeException("Data inválida");
  }

  public Contato(string n, string f, string e) {
    nome = n;
    fone = f;
    email = e;
  }
  public void SetNome(string value) {
    nome = value;
  }
  
  public string GetNome() {
    return nome;
  }
  
  public string GetNome2() => nome;
  
  public void SetFone(string n) {
    fone = n;
  }
  public string GetFone() {
    return fone;
  }
  public void SetEmail(string n) {
    email = n;
  }
  public string GetEmail() {
    return email;
  }
}
