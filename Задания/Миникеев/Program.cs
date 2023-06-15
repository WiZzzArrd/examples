using System;

namespace minikey
{
   class Program5
   {
      public static void solution()
      {
         double distance, price;

         Console.WriteLine("Введите расстояние поездки в км:");
         distance = Double.Parse(Console.ReadLine());

         Console.WriteLine("Введите регион поездки: 1 - в черте города, 2 - в радиусе до 70 км, 3 - в радиусе более 70 км");
         int region = Int32.Parse(Console.ReadLine());

         if (region == 1)
         {
            price = distance * 20;
         }
         else if (region == 2)
         {
            price = distance * 25;
         }
         else if (region == 3)
         {
            price = distance * 30;
         }
         else
         {
            Console.WriteLine("Некорректный регион");
            return;
         }

         Console.WriteLine("Цена поездки: " + price + " руб.");
      }
   }
}