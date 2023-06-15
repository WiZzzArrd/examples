using System;
using jan;
using shaid;
using absal;
using nurm;
using minikey;

class GigantProgram
{
   static void Main(string[] args)
   {

      string str = " ";

      // Program1.Show();  - абсалям
      // Program2.solution(); - иванова
      // Program3.solution(); - шайдуллина
      // Program4.solution(); - нурмухаметова
      // Program5.solution();  - вадим

      while (!str.Equals("0"))
      {

         Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
         Console.WriteLine("Введите номер программы, которую нужно запустить (1-5)");
         Console.WriteLine("1. Расчет платежа КАСКО");
         Console.WriteLine("2. Подсчет цен бензина на автозаправке");
         Console.WriteLine("3. Определения затрат на грузоперевозки");
         Console.WriteLine("4. Определения стоимости автомобиля");
         Console.WriteLine("5. Расчет цен аренды такси");
         Console.WriteLine("6. Информация о программе");
         Console.WriteLine("0. Выход");
         Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

         str = Console.ReadLine();

         if (str.Equals("1"))

         {
            Program1.Show();
         }


         else if (str.Equals("2"))
         {
            Program2.solution();


         }
         else if (str.Equals("3"))
         {
            Program3.solution();
         }


         else if (str.Equals("4"))
         {
            Program4.solution();
         }
         else if (str.Equals("5"))
         {
            Program5.solution();
         }
         else if (str.Equals("6"))
         {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Информация о программе:");
            Console.WriteLine(" ");
            Console.WriteLine("Руководитель:");
            Console.WriteLine("Бордуков Эдуард");
            Console.WriteLine("Программисты:");
            Console.WriteLine("1. Абсалямов Руслан");
            Console.WriteLine("2. Иванова Джанет");
            Console.WriteLine("3. Шайдуллина Гульгена");
            Console.WriteLine("4. Нурмухаметова Амина");
            Console.WriteLine("5. Миникеев Вадим");
            Console.WriteLine(" ");
            Console.WriteLine("Программа завершена: 15.06.23");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            return;
         }
         else if (str.Equals("0"))
         {
         }
         else
         {
            Console.WriteLine("Попробуйте еще раз");
         }
      }
   }
}
