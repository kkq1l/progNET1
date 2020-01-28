using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Class1
    {
        public void Zad8(int day){
            switch (day)
            {
                case 1:
                    Console.WriteLine("1: ОС\n2: Дифура\n3: ОС\n4: Англ");
                    break;
                case 2:
                    Console.WriteLine("2: Экономика\n3: Программирование NET");
                    break;
                case 3:
                    Console.WriteLine("2: Физра\n3: Англ");
                    break;
                case 4:
                    Console.WriteLine("1: Теория автоматов и формальных языков\n2: Дифференциальные и разностные уравнения\n3: Теория автоматов и формальных языков");
                    break;
                case 5:
                    Console.WriteLine("1: Структуры и алгоритмы обработки данных\n2: Структуры и алгоритмы обработки данных\n3: Программирование.NET");
                    break;
                case 6:
                    Console.WriteLine("2: Физра\n3: База Данных\n4: База Данных");
                    break;
                case 7:
                    Console.WriteLine("Выходной");
                    break;
                default:
                    Console.WriteLine("Ошибка дня недели");
                    break;
            }
            return;
        }

        public void Zad7(string name) {
            char[] firstname = name.ToCharArray();
            string bukva = Convert.ToString(firstname[firstname.Length-1]);
            if (bukva == "а")
            {
                Console.WriteLine("Здраствуйте госпожа " + name);
            }
            else {
                Console.WriteLine("Здраствуйте господин " + name);
            }
            return;
        }

        public void Zad2(int a, int b) {
            if (a > b)
            {
                Console.WriteLine("Максимальное число равно " + a);
            }
            else {
                Console.WriteLine("Максимальное число равно " + b);
            }
            return;
        }
    }
}
