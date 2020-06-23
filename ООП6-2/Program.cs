using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП6_2
{
    class Class
    {
        private string Metod;

        public Class()
        {
            Metod = "Пусто";
        }
        public Class(string Line)
        {
            if (Line.Length > 10)
                this.Metod = "Слишком длинная строка";
            else
                this.Metod = Line;
        }
        public void Display()
        {
            Console.WriteLine(Metod);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class classone = new Class();
            classone.Display();
            Class classtwo = new Class("1234567890");
            classtwo.Display();
            Class classthre = new Class("2200-0032-1265-5342");
            classthre.Display();
            Console.ReadKey();
        }
    }
}
