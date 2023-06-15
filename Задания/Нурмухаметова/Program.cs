using System;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            // Запрос времени аренды у пользователя
            Console.WriteLine("Введите время аренды (в часах): ");
            int rentalTime = Convert.ToInt32(Console.ReadLine());

            // Запрос типа автомобиля у пользователя
            Console.WriteLine("Введите тип автомобиля (1 - такси, 2 - микроавтобус, 3 - автобус): ");
            int carType = Convert.ToInt32(Console.ReadLine());

            // Вычисление стоимости аренды в зависимости от времени аренды и типа автомобиля
            double rentalCost = 0;
            switch (carType)
            {
                case 1:
                    rentalCost = rentalTime * 10;
                    break;
                case 2:
                    rentalCost = rentalTime * 20;
                    break;
                case 3:
                    rentalCost = rentalTime * 30;
                    break;
                default:
                    Console.WriteLine("Некорректный тип автомобиля.");
                    break;
            }

            // Вывод стоимости аренды на экран
            Console.WriteLine("Стоимость аренды: " + rentalCost + " рублей.");
        }
    }
}
