using System;

namespace WDP
{
  public class Zestaw2 : IZestaw
  {
    public void Zadanie1()
    {
      Console.WriteLine("Zadanie 1");
      Console.WriteLine("Podaj początek przedziału");
      int start = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj koniec przedziału");
      int end = int.Parse(Console.ReadLine());

      for (int i = start; i <= end; i++)
      {
        if (i % 3 == 0)
        {
          Console.WriteLine("Liczba {0} jest podzielna przez 3");
        }
      }

      while (start <= end)
      {
        if (start % 3 == 0)
        {
          Console.WriteLine("Liczba {0} jest podzielna przez 3");
        }
        start++;
      }

      do
      {
        if (start % 3 == 0)
        {
          Console.WriteLine("Liczba {0} jest podzielna przez 3");
        }
        start++;
      } while (start <= end);
    }
    public void Zadanie2()
    {
      Console.WriteLine("Zadanie 2");
      Console.WriteLine("Wariant 1");

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j < 5; j++)
        {
          Console.Write('*');
        }
        Console.Write('\n');
      }

      Console.WriteLine("Wariant 2");

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j <= i; j++)
        {
          Console.Write('*');
        }
        Console.Write('\n');
      }

      Console.WriteLine("Wariant 3");

      for (int i = 0; i < 5; i++)
      {
        for (int j = 0; j <= 5; j++)
        {
          Console.Write(j >= 5 - i ? '*' : ' ');
        }
        Console.Write('\n');
      }
    }
    public void Zadanie3()
    {
      Console.WriteLine("Zadanie 3");
      Console.WriteLine("Podaj początek przedziału:");
      int start = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj koniec przedziału:");
      int end = int.Parse(Console.ReadLine());

      int sumEven = 0;
      int sumOdd = 0;

      for (int i = start; i <= end; i++)
      {
        if (i % 2 == 0)
        {
          sumEven += i;
        }
        else
        {
          sumOdd += i;
        }
      }
    }
    public void Zadanie4()
    {
      Console.WriteLine("Zadanie 4");

      Console.WriteLine("Podaj pierwszą liczbę:");
      int first = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj drugą liczbę:");
      int second = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj trzecią liczbę:");
      int third = int.Parse(Console.ReadLine());
      Console.WriteLine("Podaj czwartą liczbę:");
      int fourth = int.Parse(Console.ReadLine());

      int sum = first + second + third + fourth;
      double median = sum / 4;

      Console.WriteLine("Suma podanych liczb to {0}", sum);
      Console.WriteLine("Średnia podanych liczb to {0}", median);
    }
    public void Zadanie5()
    {
      Console.WriteLine("Zadanie 5");

      Random generator = new Random();

      Console.WriteLine("Podaj ilość liczb do wylosowania:");
      int count = int.Parse(Console.ReadLine());

      int sum = 0;
      int min = -1;
      int max = -1;

      for (int i = 0; i < count; i++)
      {
        int number = generator.Next(999);

        if (min > number)
        {
          min = number;
        }

        if (max < number)
        {
          max = number;
        }

        sum += number;
      }

      double median = sum / count;

      Console.WriteLine("Najmniejsza liczba ze zbioru: {0}", min);
      Console.WriteLine("Najwieksza liczba ze zbioru: {0}", max);
      Console.WriteLine("Średnia liczba ze zbioru: {0}", median);

    }
    public void Zadanie6()
    {
      Console.WriteLine("Zadanie 6");

      for (int i = 0; i <= 10; i++)
      {
        for (int j = 0; j <= 10; j++)
        {
          if (i == 0 && j == 0)
          {
            Console.Write("X");
          }
          else if (i == 0)
          {
            Console.Write(j);
          }
          else if (j == 0)
          {
            Console.Write(i);
          }
          else
          {
            Console.Write(i * j);
          }
        }
        Console.Write("\n");
      }
    }
    public void Zadanie7()
    {
      Console.WriteLine("Zadanie 7");

      for (int i = 122; i >= 97; i--)
      {
        char letter = (char)i;
        Console.Write(letter);
      }
    }
    public void Zadanie8()
    {
      Console.WriteLine("Zadanie 8");
      // ???
    }
    public void Zadanie9()
    {
      Console.WriteLine("Zadanie 9");

      Console.WriteLine("Podaj rok, który chcesz sprawdzić:");
      int year = int.Parse(Console.ReadLine());

      bool check = (year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0);

      if (check)
      {
        Console.WriteLine("Rok {0} jest rokiem przestępnym", year);
      }
      else
      {
        Console.WriteLine("Rok {0} nie jest rokiem przestępnym", year);
      }
    }
    public void Zadanie10()
    {
      Console.WriteLine("Zadanie 10");

      int sum = 0;
      int count = 0;

      while (sum < 100)
      {
        sum += count;
        count++;
      }

      Console.WriteLine("Aby przekroczyć sumę o wartości 100 potrzeba {0} kolejnych liczb całkowitych", count);
    }
    public void Zadanie11()
    {
      Console.WriteLine("Zadanie 11");

      for (int i = 1; i <= 6; i++)
      {
        for (int j = 1; j <= 6; j++)
        {
          if (j == i || j == (7 - i))
          {
            Console.Write("X");
          }
          else
          {
            Console.Write(" ");
          }
        }

        Console.Write("\n");
      }
    }
  }
}