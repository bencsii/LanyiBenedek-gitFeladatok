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
        static void Main(string[] args)
        {
        }
    }
}
