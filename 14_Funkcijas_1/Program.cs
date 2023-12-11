using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Funkcijas_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            char izvele;

            do
            {
                Console.WriteLine("1 - saskaitīšana");
                Console.WriteLine("2 - atņemšana");
                Console.WriteLine("3 - reizināšana");
                Console.WriteLine("4 - dalīšana");
                Console.WriteLine("0 - iziet");

                izvele = Console.ReadKey().KeyChar;

                if (izvele != '0')
                {
                    Console.WriteLine("\nCik piemērus rēķināsiet: ");
                    int atkartojumi = int.Parse(Console.ReadLine());

                    switch (izvele)
                    {
                        case '1':
                            for (int i = 0; i < atkartojumi; i++)
                            {
                                IzpildiSaskaitisanu(rand);
                            }
                            break;

                        case '2':
                            for (int i = 0; i < atkartojumi; i++)
                            {
                                IzpildiAtnemsanu(rand);
                            }
                            break;

                        case '3':
                            for (int i = 0; i < atkartojumi; i++)
                            {
                                IzpildiReizinisanu(rand);
                            }
                            break;

                        case '4':
                            for (int i = 0; i < atkartojumi; i++)
                            {
                                IzpildiDalisanu(rand);
                            }
                            break;

                        default:
                            Console.WriteLine("Nepareiza izvēle. Lūdzu, izvēlies atkārtoti.");
                            break;
                    }
                }

            } while (izvele != '0');
        }

        static void IzpildiSaskaitisanu(Random rand)
        {
            int skaitlis1 = rand.Next(1, 11);
            int skaitlis2 = rand.Next(1, 11);

            Console.Write($"Cik ir {skaitlis1} + {skaitlis2}? ");
            int atbilde = int.Parse(Console.ReadLine());

            if (atbilde == skaitlis1 + skaitlis2)
            {
                Console.WriteLine("Pareizi!");
            }
            else
            {
                Console.WriteLine($"Nepareizi. Pareizā atbilde ir {skaitlis1 + skaitlis2}.");
            }
        }

        static void IzpildiAtnemsanu(Random rand)
        {
            int skaitlis1 = rand.Next(1, 11);
            int skaitlis2 = rand.Next(1, 11);

            Console.Write($"Cik ir {skaitlis1} - {skaitlis2}? ");
            int atbilde = int.Parse(Console.ReadLine());

            if (atbilde == skaitlis1 - skaitlis2)
            {
                Console.WriteLine("Pareizi!");
            }
            else
            {
                Console.WriteLine($"Nepareizi. Pareizā atbilde ir {skaitlis1 - skaitlis2}.");
            }
        }

        static void IzpildiReizinisanu(Random rand)
        {
            int skaitlis1 = rand.Next(1, 11);
            int skaitlis2 = rand.Next(1, 11);

            Console.Write($"Cik ir {skaitlis1} * {skaitlis2}? ");
            int atbilde = int.Parse(Console.ReadLine());

            if (atbilde == skaitlis1 * skaitlis2)
            {
                Console.WriteLine("Pareizi!");
            }
            else
            {
                Console.WriteLine($"Nepareizi. Pareizā atbilde ir {skaitlis1 * skaitlis2}.");
            }
        }

        static void IzpildiDalisanu(Random rand)
        {
            int dalitajs = rand.Next(1, 11);
            int dalitajsReizinatajs = rand.Next(1, 11);
            int dalitajsRezultats = dalitajs * dalitajsReizinatajs;

            Console.Write($"Cik ir {dalitajsRezultats} / {dalitajs}? ");
            int atbilde = int.Parse(Console.ReadLine());

            if (atbilde == dalitajsRezultats / dalitajs)
            {
                Console.WriteLine("Pareizi!");
            }
            else
            {
                Console.WriteLine($"Nepareizi. Pareizā atbilde ir {dalitajsRezultats / dalitajs}.");
            }
        }
    }
}