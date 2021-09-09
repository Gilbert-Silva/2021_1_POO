using System;
using System.Collections;
using System.Collections.Generic;

class MainClass {
  public static void Main() {
    try {
      int.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
      Console.WriteLine("FormatException");
    }
    //string s = null;
    //s.Substring(1, 3);
    
    Retangulo r = new Retangulo();
    try {
      r.SetBase(10);
      r.SetAltura(-10);
    }
    catch (ArgumentOutOfRangeException erro) {
      Console.WriteLine(erro.Message);
    }
  }
}


class Retangulo {
  private double b, h;
  public double Area {
    get { return b * h; }
  }
  public double Diagonal {
    get { return Math.Sqrt(b*b + h*h); }
  }
  public double Base {
    get { return b; }
    set { 
      if (value < 0) 
        throw new ArgumentOutOfRangeException("Base não pode ser negativa");
     this.b = value;  
    }
  }

  public void SetBase(double b) {
    if (b < 0) 
      throw new ArgumentOutOfRangeException("Base não pode ser negativa");
    this.b = b;  
  }
  public void SetAltura(double h) {
    if (h < 0) 
//      throw new ArgumentOutOfRangeException("Altura não pode ser negativa");
      throw new DimensaoException("Altura não pode ser negativa");
    this.h = h;  
  }
  public double GetBase() { return b; }
  public double GetAltura() { return h; }
  public override string ToString() {
    return $"Base = {b}  Altura = {h}";
  }
}

class DimensaoException : Exception {
  public DimensaoException(string s) : base(s) {

  }
}