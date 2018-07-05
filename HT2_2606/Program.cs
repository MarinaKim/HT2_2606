using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT2_2606
{
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Enter a task num: ");
                n = Int32.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        {
                            task1();
                        }
                        break; ;

                    case 2:
                        {
                            task2();
                        }
                        break;
                    case 3:
                        {
                            task3();
                        }
                        break;

                    case 4:
                        {
                            task4();
                        }
                        break;

                    case 5:
                        {
                            task5();
                        }
                        break;

                    case 6:
                        {
                            task6();
                        }
                        break;

                    case 7:
                        {
                            task7();
                        }
                        break;

                    case 8:
                        {
                            task8();
                        }
                        break;

                    case 9:
                        {
                            task9();
                        }
                        break;

                    case 10:
                        {
                            task10();
                        }
                        break;
                }
            } while (n > 0);
        }

        static void task1()
        {
            /*1.	Написать программу, которая считывает символы с клавиатуры, 
             * пока не будет введена точка. Программа должна сосчитать количество
             *  введенных пользователем пробелов. */

            Console.WriteLine("Enter the symbols: ");

            List<char> l = new List<char>();
            int count = 0;
            char x = ' ';
            while (x != '.')
            {
                x = Char.Parse(Console.ReadLine());
                l.Add(x);
                if (x == ' ')
                    count++;
            }
            Console.WriteLine("Count of ' ': {0}", count);

        }

        static void task2()
        {
            /*26.	Дано четырехзначное число. Найти: 
a.	сумму его цифр; 
b.	произведение его цифр*/
            int[] x = { 2, 3, 4, 5 };
            int sum = 0, pr = 1;
            for (int i = 0; i < 4; i++)
            {
                sum += x[i];
                pr *= x[i];
            }
            Console.WriteLine("sum: {0}\n pr: {1}", sum, pr);
        }

        static void task3()
        {
            /*5.	Дано целое число N (> 0), найти число, полученное при прочтении
             *  числа N справа налево. Например, если было введено число 345,
             *   то программа должна вывести число 543.*/

            Console.WriteLine("Введите число: ");
            string x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Reverse: {0} ", new string(arr));
        }

        static void task4()
        {
            /*18.	Дана сторона квадрата. Найти его периметр.*/
            Console.Write("Введите сторону квадрата: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Периметр: {0}", a * 4);

        }

        static void task5()
        {
            /*38.	Дата некоторого дня характеризуется тремя натуральными числами:
             *  g (год), m (порядковый номер месяца) и n (число). 
             *  По заданным g, n и m определить: 
                .	дату предыдущего дня;
               b.	дату следующего дня.*/
            Console.Write("Enter a date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime yesterday = date.Date.AddDays(-1);
            Console.WriteLine("дату предыдущего дня: {0} ", yesterday);
            Console.WriteLine("------------------------------------------------------");
            DateTime nextday = date.Date.AddDays(+1);
            Console.WriteLine("дату следующего дня: {0} ", nextday);

        }

        static void task6()
        {
            /*41.	Напечатать таблицу соответствия между весом в фунтах и весом в
             *  килограммах для значений 1, 2, ..., 10 фунтов (1 фунт = 453 г).*/
            int[] funt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] kg = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 10; i++)
            {
                kg[i] = funt[i] * 453;
                Console.WriteLine("{0} pound\t= {1} kg", funt[i], kg[i]);
            }
        }

        static void task7()
        {
            /*9.	С некоторого момента прошло 234 дня. 
             * Сколько полных недель прошло за этот период?*/
            int count = 234;
            Console.WriteLine("Full weeks: {0}", count / 7);

        }

        static void task8()
        {
            /*16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;*/
            Console.Write("Enter the x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("y = {0}", y);
        }

        static void task9()
        {
            /*Дано двузначное число. Определить: 
a.	какая из его цифр больше: первая или вторая; 
b.	одинаковы ли его цифры.*/

            Console.WriteLine("Введите 2значное число: ");
            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();
            int a1 = Int32.Parse(arr[0].ToString());
            int a2 = Int32.Parse(arr[1].ToString());

            if (a1 > a2)
                Console.WriteLine("Первая больше.");
            else if (a1 < a2)
                Console.WriteLine("Вторая больше.");
            else
                Console.WriteLine("Равны.");

        }

        static void task10()
        {
            /*32.	Дано натуральное число. Определить: 
a.	является ли оно четным;
b.	оканчивается ли оно цифрой 7*/

            Console.WriteLine("введите 2значное число: ");

            int a = Int32.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Число четное.");
            else
            {
                Console.WriteLine("Число не четное.");
                int k = a / 10;
                if (a - k*10 == 7)
                    Console.WriteLine("Число оканчивается на 7.");
                else
                    Console.WriteLine("Число не оканчивается на 7.");
            }

        }
    }
}
