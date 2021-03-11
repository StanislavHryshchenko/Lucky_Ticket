using System;
using System.Linq;

namespace S_Hryshchenko_Lucky_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Пожалуйста введите номер билета:  ");
                int chi;
                while (!int.TryParse(Console.ReadLine(), out chi))
                {
                    Console.WriteLine("Введите число, не символы!");
                }
                string s = chi.ToString();
                char[] mas = new char[s.Length];
                mas = s.ToCharArray();
                int[] ticketNumbers = mas.Select(n => int.Parse(n.ToString())).ToArray();
                if (mas.Length > 3 && mas.Length < 9)
                {
                    int lNumb = 0;
                    int rNumb = 0;
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (i < mas.Length / 2)
                        {
                            lNumb += ticketNumbers[i];
                        }

                        else rNumb += ticketNumbers[i];
                    }

                    if (lNumb == rNumb)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Вам повезло! Левоя сторона: {lNumb} равна правой: {rNumb}");
                    }

                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Левоя сторона: {lNumb} не равна правой: {rNumb}, билет не счастливый!");
                    }
                }

                else
                {
                    Console.WriteLine("Число введено не правильно!");
                }
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Для выхода нажмите  0 ");
                Console.WriteLine();
                Console.WriteLine("Для повторного ввода нажмите любую другую кнопку ");
            } while (Console.ReadLine() != "0");
        }



























        //public static void Prog()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Пожалуйста, введите номер билета: ");
        //    string sTickNumb = Console.ReadLine();
        //    char[] mas = new char[sTickNumb.Length];
        //    int[] iTickNumb = mas.Select(s => int.Parse(s.ToString())).ToArray();
        //    int lNumb = 0;
        //    int rNumb = 0;

        //    if (mas.Length > 3 && mas.Length < 9)
        //    {

        //        for (int i = 0; i < mas.Length; i++)
        //        {
        //            if (i < mas.Length / 2)
        //            {
        //                lNumb += iTickNumb[i];
        //            }
        //            else rNumb += iTickNumb[i];
        //        }
        //        if (lNumb == rNumb)
        //        {
        //            Console.WriteLine($"Ваш билет счастливый: {lNumb} = {rNumb}");
        //        }
        //        else Console.WriteLine($"Левая часть '{lNumb}' не равна правой '{rNumb}'");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Допущена ошибка при вводе!");
        //    }
        //}
        //public static void Main()
        //{
        //    bool isContinue = true;
        //    Console.Clear();
        //    Console.WriteLine("Выберите действие: ");
        //    Console.WriteLine("Ввести данные - 1");
        //    Console.WriteLine("Выйти из программы - 0");
        //    int k = int.Parse(Console.ReadLine());

        //    do
        //    {
        //        switch (k)
        //        {
        //            case 1: Prog(); break;
        //            case 0: isContinue = false; break;
        //            default: break;
        //        }
        //    } while (isContinue);
        //}






































        //static void Main(string[] args)
        //{
        //    Console.Clear();
        //    Console.WriteLine("Пожалуйста, введите номер билета: ");
        //    string sTickNumb = Console.ReadLine();
        //    char[] mas = new char[sTickNumb.Length];
        //    int[] iTickNumb = mas.Select(x => int.Parse(x.ToString())).ToArray();
        //    int lNumb = 0;
        //    int rNumb = 0;

        //    if (mas.Length > 3 && mas.Length < 9)
        //    {

        //        for (int i = 0; i < mas.Length; i++)
        //        {
        //            if (i < mas.Length / 2)
        //            {
        //                lNumb += iTickNumb[i];
        //            }
        //            else rNumb += iTickNumb[i];
        //        }
        //        if (lNumb == rNumb)
        //        {
        //            Console.WriteLine($"Ваш билет счастливый: {lNumb} = {rNumb}");
        //        }
        //        else Console.WriteLine($"Левая часть '{lNumb}' не равна правой '{rNumb}'");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Допущена ошибка при вводе!");
        //    }

        //}

    }
}
