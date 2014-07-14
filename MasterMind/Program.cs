using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            fonction.menu();
            
            RandoNumber rand = new RandoNumber();
            int[] nombre = new int[4];


            string saisieConsole = Console.ReadLine();



            if (saisieConsole != "s")
            {
                do
                {
                    for (int i = 0; i < 4; i++)
                    {
                        nombre[i] = rand.RandomNumber(0, 7);
                    }

                } while (fonction.Checkeur(nombre,4,8) != "");
            }
            else
            {
                //super munsterMind
                do
                {
                    for (int i = 0; i < 5; i++)
                    {
                        nombre[i] = rand.RandomNumber(0, 8);
                    }

                } while (fonction.Checkeur(nombre, 5, 10) != "");

            }
            Console.ReadKey();
        }
    }
}
