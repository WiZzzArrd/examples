using System;

namespace FreightCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            Console.WriteLine("Введите расстояние в километрах: ");
            double distance = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес груза в килограммах: ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество грузчиков (0, если грузчики не нужны): ");
            int numWorkers = int.Parse(Console.ReadLine());

            // Расчет затрат
            double transportationCost = distance * 10; // Стоимость перевозки за километр
            double workersCost = numWorkers * 500; // Стоимость оплаты труда грузчиков
            double totalCost = transportationCost + workersCost; // Общая стоимость

            // Вывод результатов
            Console.WriteLine("Стоимость перевозки: " + transportationCost + " руб.");
            Console.WriteLine("Стоимость оплаты труда грузчиков: " + workersCost + " руб.");
            Console.WriteLine("Общая стоимость: " + totalCost + " руб.");
        }
    }
}
