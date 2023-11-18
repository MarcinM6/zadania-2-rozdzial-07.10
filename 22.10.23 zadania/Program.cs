using System;
using System.Diagnostics.CodeAnalysis;

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
            // zad33();
            // zad34();
            // zad35();
            // zad36();
            //zad37(); 
            //zad38();
            // zad39();
            //zad310();
            //zad311();
            //zad312();
            //zad313();
            // zad314(); nie wiem
            zad315();
                


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
            if (a % b == 0)
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
            int some = 0;
            if (a >= b && a >= c)
            {
                some = a;
            }
            if (b >= c && b >= a)
            {
                some = b;
            }
            if (c >= b && c >= a)
            {
                some = c;
            }
            Console.WriteLine(some);
        }
        static void zad34()
        {
            Console.WriteLine("Wybierz działanie : *, /, +, -,");
            string znak = Console.ReadLine();
            Console.WriteLine("wprowadz liczby: a ,b ");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            switch (znak)
            {
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    Console.WriteLine(a / b);
                    break;
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;



            }
        }

        static void zad35()
        {
            Console.WriteLine("Podaj współczynnik równania kolejno : a, b,c");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float delta = b * b - 4 * a * c;

            if (delta == 0)
            {
                Console.WriteLine("Istnieje jeden pierwiastek");

            } else if (delta > 0)
            {
                Console.WriteLine("istnieją dwa pierwiastki ");
            }
            else
            {
                Console.WriteLine(" nie istnieją pierwiastki");
            }



        }

        static void zad36()
        {
            Console.WriteLine("Podaj mase (kg)");
            float masa = float.Parse(Console.ReadLine());
            Console.WriteLine("wzrost (m)");
            float wzrost = float.Parse(Console.ReadLine());
            float BMI = masa / (wzrost * wzrost);
            Console.WriteLine(BMI);

            if (BMI < 18.5)
            {
                Console.WriteLine("Niedowaga");

            } else if ((BMI >= 18.5) && (BMI <= 24.99))
            {
                Console.WriteLine("wartosc prawidlowa");
            } else if ((BMI >= 25) && (BMI <= 30))
            {
                Console.WriteLine("Nadwaga");
            }
            else
            {
                Console.WriteLine("Otyłość");
            }
        }

        static void zad37()
        {
            Console.WriteLine("wpisz nr dnia tygodnia");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("Poniedzialek");
                    break;
                case 2:
                    Console.WriteLine("wtorek");
                    break;
                case 3:
                    Console.WriteLine("sroda");
                    break;
                case 4:
                    Console.WriteLine("czwartek");
                    break;
                case 5:
                    Console.WriteLine("piatek");
                    break;
                case 6:
                    Console.WriteLine("sobota");
                    break;
                case 7:
                    Console.WriteLine("niedziela");
                    break;
                default:
                    Console.WriteLine("Błąd");
                    break;

            }
        }

        static void zad38()
        {
            Console.WriteLine("podaj srednią wartosc ocen");
            float a = float.Parse(Console.ReadLine());

            if (a >= 4 && a <= 4.79)
            {
                Console.WriteLine("Kwota sypendium : 350 zl");
            }
            else if (a <= 4.80 && a <= 5)
            {
                Console.WriteLine("Kwota sypendium : 350 zl");
            }
            else
            {
                Console.WriteLine("Kwota sypendium: 0zł");
            }

        }

        static void zad39()
        {
            Console.WriteLine("Podaj liczbe wierszy");
            int a = int.Parse(Console.ReadLine());
            int b = a;

            //*
            //**
            //***
            for (int i = 0; i < a; i++)
            {
                for (int z = 0; z <= i; z++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }

            a = b;

            Console.WriteLine("");
            Console.WriteLine("");


            //***
            //**
            //*
            for (int i = a; i >= 0; i--)
            {
                for (int z = 0; z <= i; z++)
                {
                    Console.Write("*");

                }
                Console.WriteLine("");
            }

            a = b;
            //      *
            //     **
            //    ***
            Console.WriteLine("");
            int chwile = b;
            for (int i = 0; i <= a; i++)
            {


                for (int y = chwile; y > 0; y--)
                {
                    Console.Write(" ");
                }
                chwile = chwile - 1;

                for (int z = 0; z <= i; z++)
                {
                    Console.Write("*");

                }

                Console.WriteLine("");

            }

            a = b;

            Console.WriteLine(" ");

            for (int i = 0; i <= a; i++)
            {
                Console.Write("*");
            }


            Console.WriteLine("");

            for (int i = 0; i <= a; i++)
            {
                Console.Write("*");

                for (int y = 2; y <= a; y++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");

                Console.WriteLine("");
            }




            for (int i = 0; i <= a; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");

        }


        static void zad310()
        {
            Console.WriteLine("Podaj N!");
            int n = int.Parse(Console.ReadLine());
            int suma = 1;
            for (int i = n; i >= 1; --i)
            {
                suma = suma * i;
            }
            Console.WriteLine("n! = " + suma);
        }
        static void zad311()
        {
            Console.WriteLine("Podaj I");
            int I = int.Parse(Console.ReadLine());
            int suma = I;
            int ile = 0;

            if (I > 100)
            {
                Console.WriteLine("Liczba jest większa od 100");
            }
            else
            {
                for (int i = I + 1; i < 100 && suma <= 100; ++i)
                {
                    suma = suma + i;
                    ile++;
                    Console.WriteLine("to t suma :" + suma);
                    Console.WriteLine("to i :" + i);
                }
                Console.WriteLine(suma);
                Console.WriteLine("musielismy dodać: " + ile + "razy");


            }

        }

        static void zad312()
        {
            int[] a = new int[1];
            int x = 0;
            do
            {

                Console.WriteLine("Podaj liczbe: ");
                Array.Resize(ref a, a.Length + 1);
                a[x] = int.Parse(Console.ReadLine());

                x++;

            } while (a[x - 1] != 0);
            Array.Resize(ref a, a.Length - 1);

            Console.WriteLine("wprowadziles : " + a.Length + " Liczb");

        }
        static void zad313()
        {
            int n = int.Parse(Console.ReadLine());
            int suma = 0;
            for (int i = 2; i <= n; i += 2)
            {
                suma = suma + i - 1 - i;
                Console.WriteLine(suma);
            }
            if (n % 2 == 1)
            {
                suma = suma + n;
            }
            Console.WriteLine(suma);
        }

        static void zad314()
        {
            int n = int.Parse(Console.ReadLine());
            double suma = 0;
            int ile = 0; 

                for (int i = n; i > 0; i--) //ma 28 , pozniej obniza o jeden
                {
                if(i %2==1)
                {
                    i--;
                }
                ile = 0;
                suma = 0;
                Console.WriteLine("Dla liczby " + i + "dzielnikami sa");
                for (int y =(i/2)-ile; y>0; y/=2) //14 tu sprawdza
                {




                    if (i%2 == 0) // 14
                    {
                        suma = suma + y;
                    }
                    else
                    {
                        suma = suma + 1 + y;
                        y++;
                        ile++;
                    }
                    Console.WriteLine("Y to  " + y);
                    Console.WriteLine("suma:" + suma);
                    if (suma == n)
                    {
                        Console.WriteLine("Suma =n czyli  " + n);
                    }


                }

            }

            

        }
        static void zad315()
        {

                Console.WriteLine("Start");
                for (int z1 = 0; z1 <= 10; z1++)
                    for (int z2 = 0; z2 <= 5; z2++)
                        for (int z5 = 0; z5 <= 2; z5++)
                            if (z1 * 1 + z2 * 2 + z5 * 5 == 10)
                                Console.WriteLine("zlotowka = {0} dwa zlote = {1} piec zlote = {2}", z1, z2, z5);
                Console.ReadKey();

            

        }


    }



    }



