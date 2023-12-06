using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// описывает транспорт и его вид
    /// </summary>
    class Transport
    {
        public string kindTransport;
        string color;
        double speed;
        double massa;

        public Transport()
        {

        }
        public Transport(string kindTransport, string color, double speed, double massa)
        {
            this.color = color;
            this.speed = speed;
            this.massa = massa;
            this.kindTransport = kindTransport;
        }

        public void Info ()
        {
            Console.WriteLine($"Тип транспорта - {kindTransport} \n" +
                $"Цвет транспорта - {color} \n" +
                $"Скорость транспорта - {speed} km/h\n" +
                $"Масса транспорта - {massa} kg\n");
        }
    }
}
