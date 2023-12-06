using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Figura
    {
        string kindFigur;
        int height;
        int width;

        public Figura()
        {

        }

        public Figura(string kindFigur, int height, int width)
        {
            this.kindFigur = kindFigur;
            this.height = height;
            this.width = width;
        }

        public void Info()
        {
            Console.WriteLine($"Тип фигуры - {kindFigur}\n" +
                $"Высота - {height} см\n" +
                $"Ширина - {width} см\n" +
                $"Площадь - {height * width} см кв\n");
        }
    }
}
