using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitFeladatok
{
    internal class Program
    {
        static Random rnd = new Random();

        static void f01(int[] tomb)
        {
            for(int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(1,51);
            }
        }

        static int f02(int[] tomb)
        {
            int szamlalo = 0;
            for(int i = 0;i < tomb.Length;i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    szamlalo++;

                }
            }
            return szamlalo;
        }

        static double f03(int[] tomb)
        {
            double atlag = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                atlag += tomb[i];

            }
            return atlag / tomb.Length;
        }

        static int[] f04(int[] tomb)
        {
            int[] paratlanok = new int[10];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    paratlanok[i] = tomb[i] + 1;
                    
                }
                else
                {
                    paratlanok[i] = tomb[i];
                }

            }
            return paratlanok;
        }


        static void Main(string[] args)
        {
        }
    }
}
