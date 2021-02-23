using System;
using System.IO;


namespace SpiralArray
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            try
            {
                do
                {
                    Console.WriteLine("Введите ширину и длину массива а так же скорость заполнения (от 100 до 1500) ");

                    int width = Convert.ToInt32(Console.ReadLine()); //x
                    int length = Convert.ToInt32(Console.ReadLine()); //y
                    int speed = Convert.ToInt32(Console.ReadLine());

                    if (speed > 1500)
                    {
                        speed = 1500;
                    }
                    else if (speed < 100)
                    {
                        speed = 100;
                    }

                    int[,] Arrey = new int[length, width];

                    Spiral _object = new Spiral(Arrey, speed);

                    Console.WriteLine("\nДля выхода нажмите Escape, для повтора -  Enter");
                } while (Console.ReadKey().Key != ConsoleKey.Escape);
                

            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели что-то неправильно");
            }

        }

        



    }
}
