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
            string input = Console.ReadLine();
            char[]  nn = input.ToCharArray();
            
            if (nn.Length != 4 )
            {
                Console.WriteLine("Вы неверно ввели число"); Environment.Exit(0);
            }

            this.chislo = new int[4];
            for (int i = 0; i < 4; i++)
            {
                this.chislo[i] = Convert.ToInt32(nn[i]-48);
            }

            return this.chislo;
        }
    }
}
