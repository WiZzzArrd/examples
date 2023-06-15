
using System;

namespace absal
{
   class Program1
   {
      public static void Show()
      {


         // Получаем данные от пользователя
         Console.Write("Введите цену автомобиля: ");
         double price = double.Parse(Console.ReadLine());

         Console.Write("Введите марку автомобиля: ");
         string brand = Console.ReadLine();

         // Определяем коэффициент риска на основе марки автомобиля
         double riskCoefficient;
         switch (brand.ToLower())
         {
            case "ford":
               riskCoefficient = 1.2;
               break;
            case "bmw":
               riskCoefficient = 1.5;
               break;
            case "toyota":
               riskCoefficient = 1.0;
               break;
            case "renault":
               riskCoefficient = 1.1;
               break;
            case "volkswagen":
               riskCoefficient = 1.3;
               break;
            default:
               Console.WriteLine("Марка автомобиля не распознана.");
               return;
         }

         // Рассчитываем платеж КАСКО
         double payment = price * riskCoefficient * 0.03;

         // Выводим результат пользователю
         Console.WriteLine("Платеж КАСКО: {0:F2}", payment);
      }
   }
}