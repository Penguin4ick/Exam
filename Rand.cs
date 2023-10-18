using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
     public class Rand
    {
        private int[] chislo;
        public int[] Out()
        {
            int e, h, a, t, d;
            int nn = int.Parse(Console.ReadLine());
            string s = nn.ToString();
            if (s.Length != 4)
            {
                Console.WriteLine("Вы неверно ввели число");
                Environment.Exit(0);
            }
            
            this.chislo = new int[4];
            t = (nn / 1000);
            h = (nn % 1000 / 100);
            d = (nn % 100 / 10);
            e = (nn % 10);
            for (int o = 0; o < chislo.Length; o++)
            {
                if (o == 0)
                {
                    chislo[o] = t;
                }
                if (o == 1)
                {
                    chislo[o] = h;
                }
                if (o == 2)
                {
                    chislo[o] = d;
                }
                if (o == 3)
                    chislo[o] = e;
            }
            return this.chislo;
        }
    }
}
