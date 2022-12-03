using System;

namespace WDP
{
  public class Zestaw1 : IZestaw
  {
    public void Zadanie1()
    {
      Console.WriteLine("Zadanie 1");

      int a = 5;
      int b = 10;

      double zero = 0.0;

      Console.WriteLine("Dodawanie {0} i {1} = {2}", a, b, a + b);
      Console.WriteLine("Odejmowanie {0} - {1} = {2}", a, b, a - b);
      Console.WriteLine("Mnozenie {0} i {1} = {2}", a, b, a * b);
      Console.WriteLine("Dzielenie {0} przez {1} = {2}", a, b, a / b);
      Console.WriteLine("Dzielenie {0} przez 0,0 = {2}", a, zero, a / zero);
      Console.WriteLine("Dzielenie {0} przez 1e308 = {2}", a, 1e308, a / 1e308);
    }
    public void Zadanie2()
    {
      Console.WriteLine("Zadanie 2");

      Console.WriteLine("Podaj współczynnik a:");
      int a = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj współczynnik b:");
      int b = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj współczynnik c:");
      int c = int.Parse(Console.ReadLine());

      int delta = b * b - 4 * a * c;

      double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
      double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

      Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);

    }
    public void Zadanie3()
    {
      Console.WriteLine("Zadanie 3");

      Console.WriteLine("Podaj pierwszą liczbę");
      float first = float.Parse(Console.ReadLine());

      Console.WriteLine("Podaj drugą liczbę");
      float second = float.Parse(Console.ReadLine());

      if (first == second)
      {
        Console.WriteLine("Podane liczby są takie same.");
      }
      else if (first > second)
      {
        Console.WriteLine("Pierwsza liczba jest większa od drugiej.");
        Console.WriteLine("True");
      }
      else
      {
        Console.WriteLine("Druga liczba jest większa od pierwszej");
        Console.Write("False");
      }
    }
    public void Zadanie4()
    {
      Console.WriteLine("Zadanie 4");

      char first = 'A';
      char second = 'B';

      Console.WriteLine("Suma: {0}", first + second);
      Console.WriteLine("Róznica: {0}", first - second);
    }
    public void Zadanie5()
    {
      Console.WriteLine("Zadanie 5");
    }
    public void Zadanie6()
    {
      Console.WriteLine("Zadanie 6");

      // To samo, co zadanie nr 2.
      Zadanie2();
    }
    public void Zadanie7()
    {
      Console.WriteLine("Zadanie 7");

      Console.WriteLine("Podaj pierwszą liczbę:");
      int a = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj drugą liczbę:");
      int b = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj trzecią liczbę:");
      int c = int.Parse(Console.ReadLine());

      if (a * a + b * b == c * c)
      {
        Console.WriteLine("Podane liczby tworzą trójkę pitagorejską");
      }
      else
      {
        Console.WriteLine("Podane liczby nie tworzą trójki pitagorejskiej");
      }
    }
    public void Zadanie8()
    {
      Console.WriteLine("Zadanie 8");

      float grade = 2.0F;

      Console.WriteLine("Podaj ilość punktów w przedziale 0 - 100:");
      int points = int.Parse(Console.ReadLine());

      if (points < 0 || points > 100)
      {
        Console.WriteLine("Niepoprawna ilość punktów.");
      }
      else if (points > 50 && points <= 60)
      {
        grade = 3.0F;
      }
      else if (points > 60 && points <= 70)
      {
        grade = 3.5F;
      }
      else if (points > 70 && points <= 80)
      {
        grade = 4.0F;
      }
      else if (points > 80 && points <= 90)
      {
        grade = 4.5F;
      }
      else
      {
        grade = 5.0F;
      }

      Console.WriteLine("Ocena dla {0} punktów to {1]", points, grade);
    }
    public void Zadanie9()
    {
      Console.WriteLine("Zadanie 9");

      Console.WriteLine("Podaj współczynnik a:");
      int a = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj współczynnik b:");
      int b = int.Parse(Console.ReadLine());

      Console.WriteLine("Podaj współczynnik y:");
      int y = int.Parse(Console.ReadLine());

      double result = (y - b) / a;

      Console.WriteLine("Wynik równania {0} = {1}x + {2} to: {3}", y, a, b, result);
    }
    public void Zadanie10()
    {
      Console.WriteLine("Zadanie 10");

      // To samo, co zadanie nr 2.
      Zadanie2();
    }
    public void Zadanie11()
    {
      Console.WriteLine("Brak zadania 11.");
    }
  }
}