//метод, двум массив, цикл
using System;
namespace Tests
{
    class Program
    {
        static void Main()
        {
            int e, h, a, t, d;
            Console.WriteLine("Игра Быки и Коровы");
            int[,] array = new int[2, 2];
            Random random = new Random();
            int[] mass = new int[4];
            int z = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    array[i, j] = random.Next(0, 10);
                    mass[z] = array[i, j];
                    z++;
                }
            }
            int attempts = 0;
            bool guessed = false;

            while (!guessed && attempts < 10)
            {
                Console.WriteLine($"Попытка {attempts + 1}: ");
                Rand rnrn = new Rand();
                int[] usernumber = rnrn.Out();
                for (int i = 0; i < usernumber.Length; i++)
                {

                }
                int korova = 0;
                int bik = 0;
                for (int i = 0; i < 4; i++)
                    {
                        if (usernumber.Contains(mass[i]))
                        {
                        if (usernumber[i] == mass[i])
                        { bik++; }
                        else
                        { korova++; }
                        }
                    }
                
                Console.WriteLine($"Быки: {bik}, Коровы: {korova}");
                attempts++;
                if (bik == 4)
                {
                    guessed = true;
                    Console.WriteLine("Вы угадали число!");
                }

               

            }
                if (!guessed)
                {
                    Console.Write("Вы не угадали число. Ваше число ");
                for (int r = 0; r < mass.Length; r++)
                {
                    Console.Write(mass[r]);
                }
                }
            }
        }
    }

