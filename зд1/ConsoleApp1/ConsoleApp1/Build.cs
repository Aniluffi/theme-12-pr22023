using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp67

{

    /// <summary>

    /// класс создает имя проэкта ,площадь ,колличество жителей,колличество этажей

    /// 

    /// </summary>

    class Build

    {

        public string name;

        public double area;

        public int kvo;





        public Build()

        {



        }



        /// <summary>

        /// конструктор который инициализирует поля

        /// </summary>

        /// <param name="name">имя проэкта</param>

        /// <param name="area">площадь дома</param>

        /// <param name="kvo">колличество жителей</param>

        public Build(string name, double area, int kvo)

        {

            this.name = name;

            this.area = area;

            this.kvo = kvo;

        }





        /// <summary>

        /// метод который выводит информацию

        /// </summary>

        public void ShowInfo()

        {

            Console.WriteLine($"\n Описание проэкта - {name} \n " +

                $"Площадь = {area} \n" +

                $"Колличество жильцов - {kvo} \n" +

                $"Площадь на одного жильца = {area / kvo} ");

        }

        public byte floor;



        /// <summary>

        /// 

        /// </summary>

        /// <param name="name"></param>

        /// <param name="area"></param>

        /// <param name="kvo"></param>

        /// <param name="floor">колличество этажей</param>

        public Build(string name, double area, int kvo, byte floor) : this(name, area, kvo)

        {

            this.floor = floor;

        }





        /// <summary>

        /// второй метод вывода ,отличие в том том что здесь есть вывод колличества этажей

        /// </summary>

        public void ShowInfo2()

        {

            Console.WriteLine($"\n Описание проэкта - {name} \n " +

                $"Площадь = {area} \n" +

                $"Колличество жильцов - {kvo} \n" +

                $"Площадь на одного жильца = {area / kvo} \n" +

                $"Колличество этажей - {floor}");

        }

    }

}

