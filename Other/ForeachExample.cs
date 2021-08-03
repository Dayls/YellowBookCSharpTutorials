using System;
using System.Collections.Generic;
namespace ConsoleApplication1
{
   class Program
   {
      static void Main(string[] args)
      {
      // Объявляем два массива
         int[] myArr = new int[5];
         int[,] myTwoArr = new int[5, 6];
         int sum = 0;
         Random ran = new Random();
      // Инициализируем массивы
         for (int i = 1; i <= 5; i++)
         {
            myArr[i - 1] = ran.Next(1, 20);
            for (int j = 1; j <= 6; j++)
               myTwoArr[i - 1, j - 1] = ran.Next(1, 30);
         }
      // Вычисляем квадрат каждого элемента одномерного массива
         foreach (int fVar in myArr)
            Console.WriteLine("{0} в квадрате равно {1}", fVar, fVar * fVar);
         Console.WriteLine();
      // Вычислим сумму элементов многомерного массива
         foreach (int fTwoVar in myTwoArr)
            sum += fTwoVar;
         Console.WriteLine("Сумма элементов многомерного массива: {0}", sum);
         Console.ReadLine();
      }
   }
}
