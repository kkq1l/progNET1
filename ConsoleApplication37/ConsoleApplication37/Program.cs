using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication37
{
    class Program
    {

        

        static void Main(string[] args)
        {
            int dd = 1;
            Class1 asd = new Class1();
            int zad;
            string name;
            int a, b;

            Console.WriteLine("ЛАБАРАТОРНАЯ РАБОТА №1:\n    Выберите номер задачу 1-8:");
            zad = Convert.ToInt16(Console.ReadLine());

            
                if (zad == 8)
                {
                    Console.WriteLine("Введите день недели для просмотра рассписания:\n             1 - Понедельник;\n             2 - Вторник;\n             3 - Среда и тд");

                    dd = Convert.ToInt16(Console.ReadLine());
                    asd.Zad8(dd);
                }
                else if (zad == 7)
                {
                    Console.WriteLine("Введите вашу Фамилию:");

                    name = Console.ReadLine();
                    asd.Zad7(name);
                }
                else if (zad == 2) {
                    Console.Write("Введите a=");

                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Введите b=");
                    b = Convert.ToInt16(Console.ReadLine());
                    asd.Zad2(a,b);
                }

            Console.ReadKey();
            }
            
        }
}

