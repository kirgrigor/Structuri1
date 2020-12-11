using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grigorev Kirill Evgenevich");
            Console.WriteLine("FITU2-5");
            int a = 0, b = 0;
            int x = 0;
            do
            {
                Console.WriteLine("Vvedite a");
                a = Convert.ToInt32(Console.ReadLine());
                
            } while (a < 2);
            do
            {
                Console.WriteLine("Vvedite b");
                b = Convert.ToInt32(Console.ReadLine());
                x = Convert.ToInt32(Math.Pow(10, 9));
               
            } while (b >= 2 * x);
            int n=0;

            for (int i=1;i<5; i++)
            {
                

               int res = Convert.ToInt32(Math.Pow(b, i));
                if (res % a == 0)
                {
                    n = i;
                    Console.WriteLine("n= " + n);
                    break;
                }
            }
            if (n == 0)
            {
                Console.WriteLine("n= -1" );
            }
        }
    }
}
