using System;

namespace zadania
{

    class Program
    {
        static void Main(string[] args)
        {
            // zad3a();
            // zad3b();
            // zad3c();

            // zad31();
            // zad32();
             zad33();
        }

        static void zad3a()
        {
            Console.WriteLine("podaj liczbe");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {

                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba jest nie parzysta");
            }

            if (a < 0) { Console.WriteLine("Liczba jest ujemna"); }
            else { Console.WriteLine("Liczba jest dodatnia"); }

        }

        static void zad3b()
        {
            Console.WriteLine("Wprowadz liczbe 1");
            int liczba1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Wprowadz liczbe 2");
            int liczba2 = int.Parse(Console.ReadLine());
            Console.Write("liczby parzyste:");
            for (int i = liczba1; i <= liczba2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadKey();
        }
        /*
        static void zad3c(string[] args)
        {
            int i = 1;
            double dlug =
        }
        */

        static void zad31()
        {
            int rok = int.Parse(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                Console.WriteLine("jest przystepny");
            }
            else
            {
                Console.WriteLine("jest nie przestepny");
            }
        }

        static void zad32()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if(a %b ==0)
            {
                Console.WriteLine("jest dzielnikiem");

            }
            else
            {
                Console.WriteLine("nie jest dzielnikiem");
            }
        }

        static void zad33()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int some=0;
            if(a>=b && a>=c)
            {
                some = a;
            }
            if(b>=c && b>=a)
            {
                some = b;
            }
            if(c>=b && c>=a)
            {
                some = c;
            }
            Console.WriteLine(some);
        }
        static void zad34()
        {
            switch x
            { 

            
            }
        }
    }

}

