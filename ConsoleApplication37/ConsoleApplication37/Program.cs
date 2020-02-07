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
            double aaa, bbb;
            int a, b,n=0;
            while (n < 1)
            {
                Console.WriteLine("ЛАБАРАТОРНАЯ РАБОТА №1:\n    Выберите номер задачу 1,2,4,6-8");
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
                else if (zad == 2)
                {
                    Console.Write("Введите a=");

                    a = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Введите b=");
                    b = Convert.ToInt16(Console.ReadLine());
                    asd.Zad2(a, b);
                }
                else
                    if (zad == 1)
                    {
                        aaa = Convert.ToDouble(Console.ReadLine());
                        bbb = Convert.ToDouble(Console.ReadLine());
                        asd.Zad1(aaa, bbb);
                    }
                    else
                        if (zad == 4)
                        {
                            aaa = Convert.ToDouble(Console.ReadLine());
                            bbb = Convert.ToDouble(Console.ReadLine());
                            asd.Zad4(aaa, bbb);
                        }
                        else
                            if (zad == 6)
                            {
                                int c, d;
                                Console.Write("     Месяц рождения ");
                                a = Convert.ToInt16(Console.ReadLine());
                                Console.Write("     Год рождения ");
                                b = Convert.ToInt16(Console.ReadLine());
                                Console.Write("     Месяц в данное время ");
                                c = Convert.ToInt16(Console.ReadLine());
                                Console.Write("     Год в данное время ");
                                d = Convert.ToInt16(Console.ReadLine());

                                asd.Zad6(a, b, c, d);
                            }

                Console.WriteLine("0 - еще раз\n1 - Закончить");
                n = Convert.ToInt16(Console.ReadLine());
                    if(n==1){
                        break;
                    }
            }
            Console.ReadKey();
        }
            
        }
}

