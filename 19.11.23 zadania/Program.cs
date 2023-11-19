using System.Numerics;

namespace zadania
{
    class project
    {
        static void Main(string[] args)
        {
            /*
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine(Zad51(f));
            */

            /*
            Console.WriteLine("Podaj kolejnio: a,b,x");
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("czy liczba x miesci sie wp rzedzial (a,b) lub (b,a):"+Zad52(a,b,x));
            */

            double[] wek = {3, 2};
            double[] A = new double[1];
            A[0] = int.Parse(Console.ReadLine());
            A[1] = int.Parse(Console.ReadLine());
            Zad53_Przesun();


        }

        static float Zad51(float f)
        {
            float c = (f - 30) / 2;
            return c;
        }

        static bool Zad52(float a, float b, float x)
        {

            if (x < b & x > a)
                return true;
            else
                return false;
        }

        static void Zad53_Przesun(double[]wek, double[]A)
        {
            for (int i = 0; i = 1; i++)
                A[i] += A[i] + wek[i];
            
        }
    }
}