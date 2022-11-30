using System;

namespace WDP // Note: actual namespace depends on the project name.
{
  internal class Program
  {
    static void Main(string[] args)
    {
      string zestawArg = args[0];
      string zadanieArg = args[1];

      IZestaw z = new Zestaw();

      switch (zestawArg)
      {
        case "1":
          z = new Zestaw1();
          break;
        case "2":
          z = new Zestaw2();
          break;
        case "3":
          z = new Zestaw3();
          break;
        case "4":
          z = new Zestaw4();
          break;
        case "5":
          z = new Zestaw5();
          break;
        case "6":
          z = new Zestaw6();
          break;
        default:
          Console.WriteLine("Zestaw {0} nie jest poprawnym zestawem.", zestawArg);
          break;
      }

      switch (zadanieArg)
      {
        case "1":
          z.Zadanie1();
          break;
        case "2":
          z.Zadanie2();
          break;
        case "3":
          z.Zadanie3();
          break;
        case "4":
          z.Zadanie4();
          break;
        case "5":
          z.Zadanie5();
          break;
        case "6":
          z.Zadanie6();
          break;
        case "7":
          z.Zadanie7();
          break;
        case "8":
          z.Zadanie8();
          break;
        case "9":
          z.Zadanie9();
          break;
        case "10":
          z.Zadanie10();
          break;
        case "11":
          z.Zadanie11();
          break;
        default:
          Console.WriteLine("Zadanie {0} nie istnieje w zestawie {1}", zadanieArg, zestawArg);
          break;
      }
    }
  }
}