using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double[,] matris = new double[,] { { 3, 4, 5 }, { 6, 7, 8 }, { 9, 10, 11 } };

            double toplam = 0;

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matris[i, j] = -1;
                    }

                    if (matris[i, j] % 2 == 0)
                    {
                        matris[i, j] = 0;
                    }

                    toplam = toplam + matris[i, j];

                    Console.Write($"{matris[i, j], 5}");
                  
                }
                Console.WriteLine();
            }

            Console.WriteLine("Dizinin toplamı : " +toplam);



            Console.ReadKey();
        }
    }
}
