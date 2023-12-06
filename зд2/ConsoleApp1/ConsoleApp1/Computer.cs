using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
 /// <summary>
        /// класс который описывает ПК
        /// </summary>
     class Computer
    {
       
        string model;
        int OZY;
        int strongDisk;

        /// <summary>
        /// конструктор который инециализирует поля класса
        /// </summary>
        /// <param name="model">модель ПК</param>
        /// <param name="OZY">колличество оперативнной памяти</param>
        /// <param name="strongDisk">колличество внутренней памяти</param>
        public Computer(string model, int OZY, int strongDisk)
        {


            this.model = model;
            this.OZY = OZY;
            this.strongDisk = strongDisk;
        }

        /// <summary>
        /// метод который выводит информацию о ПК
        /// </summary>
        public void Info ()
        {
            Console.WriteLine($"Модель ПК - {model}\n" +
                $"Колличество ОЗУ - {OZY} гб\n" +
                $"Колличество памяти - {strongDisk} гб\n");
        }
    }
}
