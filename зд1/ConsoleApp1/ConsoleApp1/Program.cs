using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp67

{

    class Program

    {

        static public void Main(string[] args)

        {

            Build dom1 = new Build();

            dom1.name = "Квартира";

            dom1.area = 50;

            dom1.kvo = 4;

            dom1.ShowInfo();

            Build dom2 = new Build("квартира", 50, 4);



            dom2.ShowInfo();



            Console.WriteLine("Введите название проэкта");

            string name = Convert.ToString(Console.ReadLine());



            Console.WriteLine("Введите площадь проэкта");

            double area = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Введите колличество жильцов");

            int kvo = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Введите колличество этажей");

            byte floor = Convert.ToByte(Console.ReadLine());



            Build dom3 = new Build(name, area, kvo, floor);

            dom3.ShowInfo2();

            Console.ReadKey();

        }

    }



}