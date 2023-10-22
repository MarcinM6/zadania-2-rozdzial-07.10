using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pierwszy_projekt
{
    class program
    {
        static void Main(string[] args)
        {
            //stopnie();
            //delta();
            //BMI();
            //zad24();
            //zad25();
            //zad26();
            zad27();
            //zad28();
            
        }



    public static void stopnie()
    {

                float C = float.Parse(Console.ReadLine());
                float F = 32 + 9 / 5 * C;
                Console.WriteLine(F);

        }
    public static void delta()
        {
            float a, B, c;
            Console.WriteLine("Podaj A");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Podaj B");
            B = float.Parse(Console.ReadLine());

            Console.WriteLine("Podaj C");
            c = float.Parse(Console.ReadLine());

            float delta = B * B - 4 * a * c;
            Console.WriteLine(delta);
        }

        public static void BMI()
        {
            Console.WriteLine("Podaj mase (kg)");
            float masa = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj C");
            Console.WriteLine("wzrost (m)");
            float wzrost = float.Parse(Console.ReadLine());
            float BMI = masa / (wzrost * wzrost);
            Console.WriteLine(BMI);
        }

        public static void zad24()
        {
            int x = 100;
            Console.WriteLine(++x * 2);

        }

        public static void zad25() 
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
        }

        public static void zad26() { 
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
        }

        public static void zad27()
        {
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
        }

        public static void zad28() 
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
                Console.WriteLine("zmienna x = "+x);
                Console.WriteLine("zmienna y = " + y);
                Console.WriteLine("zmienna z = " + z);
        }





    }
}