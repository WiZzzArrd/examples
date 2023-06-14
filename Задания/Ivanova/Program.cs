namespace Ivanova;

class Program
{
    static void Main(string[] args)
    {
        double AI92 = 40;
            double AI95 = 47;
            double AI98 = 62.16;

            Console.WriteLine("Выберите марку бензина: 92, 95, 98: ");
            string marka = Console.ReadLine();

            Console.WriteLine("Введите число литров: ");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Наличие дисконтной карты (скидка 5%): да(y) нет(n): ");
            String key = Console.ReadLine();

            if (key == "y" || key == "н")
            {
                if(marka == "92")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + ((l*AI92)/100*95 ));
                }
                else if(marka == "95")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + ((l*AI95)/100*95 ));
                }
                else if(marka == "98")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + ((l*AI98)/100*95 ));
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine("Данной марки не существует!!!");
                    Environment.Exit(0);
                }
            }
            else if (key == "n" || key == "т")
            {
                if(marka == "92")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + (l*AI92));
                }
                else if (marka == "95")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + (l*AI95));
                }
                else if(marka == "98")
                {
                    Console.WriteLine();
                    Console.WriteLine("Итого к оплате: " + (l*AI98));
                }
                else{
                    Console.WriteLine();
                    Console.WriteLine("Данной марки не существует!!!");
                    Environment.Exit(0);
                }
            }
            else 
            {
                Console.WriteLine("Команда не распознана!!!");
                Environment.Exit(0);
            }






            Console.ReadKey(true);
    }
}


