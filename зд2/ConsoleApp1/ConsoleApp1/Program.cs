using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp1

{

    class Program

    {

        static public void Main(string[] args)

        {

            Console.WriteLine("Введите название модели");
            string model = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Введите количество ОЗУ");
            int OZY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите колличество памяти ПК");
            int strongDisk = Convert.ToInt32(Console.ReadLine());


            Computer dom3 = new Computer(model,OZY,strongDisk);
            dom3.Info();
            
            
            Console.ReadKey();

        }

    }



}

