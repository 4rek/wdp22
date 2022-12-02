# Wstęp do programowania 2022

C# (C Sharp, dosłownie „cis”, „c z krzyżykiem”) – obiektowy język
programowania zaprojektowany w latach 1998-2001 przez zespół pod
kierunkiem Andersa Hejlsberga dla firmy Microsoft


```c#
using System;

namespace ConsoleApp1
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!"); // wypisanie "Hello World!" ze znakiem końca wiersza
      Console.Write("Test"); // wypisanie "Test" bez znaku końca wiersza

      int counter = 0; // deklaracja zmiennej
      const int Limit = 1; // deklaracja stałej

      // Konwersje zmiennych
      double zmiennaRzeczywista = double.Parse(”333.33”);
      int zmiennaCalkowita = Int32.Parse(”123”);
      float zmiennaFloat = float.Parse(”24.77”);

      int[] numbers = new int[] {1,2,3,4,5}; //deklaracja tablicy jednowymiarowej i przypisanie wartości
      int[,] array2d = new int[2,2]; // deklaracja tablicy dwuwymiarowej
      int[][] jaggedArray = new int[2][2]; // deklaracja tablicy postrzępionej (ang. jagged)

      bool condition = true;

      for (int i = 0; int < numbers.Length; i++) {
        // dla i startującego od zera wykonaj ciało pętli 4 razy (dopóki i nie będzie równe 4)
      }

      foreach (int num in numbers) {
        // przeiteruj po kadym elemencie tablicy
      }

      while (condition) {
        // ... sprawdź warunek i wykonuj gdy warunek spełniony
      }

      do {
        // wykonaj instrukcje, a następnie sprawdź warunek i jeśli spełniony, to kontynuuj
      } while (condition);

      try
      {
        // wykonaj kod, który moze spowodować wyjątek
      }
      catch (Exception ex) 
      {
        // obsłu wyjątek "ex"
      }
      finally 
      {
        // wykonaj ten blok kodu niezaleznie, czy błąd został spowodowany, czy nie
      }
    }
  }
}
```

1. Cechy dobrego programu
* poprawny
* przystosowalny
* odporny na błędy
* stabilny
* optymalny

2. Zmienne
* 