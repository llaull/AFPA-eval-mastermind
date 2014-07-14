using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMind
{
    class fonction
    {
         public static void menu()
        {
            /*                                              menu                            */
            Console.Clear();
            Console.WriteLine(@"___  ___          _           ___  ____           _ ");
            Console.WriteLine(@"|  \/  |         | |          |  \/  (_)         | |");
            Console.WriteLine(@"| .  . | __ _ ___| |_ ___ _ __| .  . |_ _ __   __| |");
            Console.WriteLine(@"| |\/| |/ _` / __| __/ _ \ '__| |\/| | | '_ \ / _` |");
            Console.WriteLine(@"| |  | | (_| \__ \ ||  __/ |  | |  | | | | | | (_| |");
            Console.WriteLine(@"\_|  |_/\__,_|___/\__\___|_|  \_|  |_/_|_| |_|\__,_|");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("            Menu MasterMinde laul version alpha");
            Console.WriteLine("             n - Generer un nouveau code de jeu");
            Console.WriteLine("             s - Jouer au superMasterMind de la mort");
            Console.WriteLine("             q - Quitter ce jeu");
            Console.ForegroundColor = ConsoleColor.White;
            /*                                              menu                            */
        }

        static bool IsNumeric(string Nombre)
        {
            try
            {
                int.Parse(Nombre);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string Checkeur(/*string saisieConsole,*/ int[] nombreMysterieu, int longeurNombreMysterieu, int NombreTentationMax) 
        {
            int nombreTente = 1;

            Console.WriteLine(longeurNombreMysterieu + "nombre generred : " /*+ nombreMysterieu[0] + nombreMysterieu[1] + nombreMysterieu[2] + nombreMysterieu[3]*/);
            for (int i = 0; i < nombreMysterieu.Length; i++)
            {
                Console.Write(nombreMysterieu[i]);
            }
            Console.WriteLine("");
           


            while (nombreTente != NombreTentationMax)
            {
                string saisieConsole  = Console.ReadLine();
               

                //declaration des variable d'environement
                string sortie = "";
                
                // si saisie est divisible par 2
                if (IsNumeric(saisieConsole) == true)
                {
                    //si la saisie console comprends 4 nombre
                    if (saisieConsole.Length == longeurNombreMysterieu)
                    {

                        //on mets en tableau la saisie console
                        int[] saisieint = new int[longeurNombreMysterieu];
                        for (int i = 0; i < saisieint.Length; i++)
                        {
                            saisieint[i] = int.Parse(saisieConsole[i].ToString());
                        }

                        int[] checknumero = new int[longeurNombreMysterieu];
                        int compteur;


                        for (compteur = 0; compteur < longeurNombreMysterieu; compteur++)
                        {
                            checknumero[compteur] = nombreMysterieu.Contains(saisieint[compteur]) ? 1 : 0;
                            if (checknumero[compteur] >= 1)
                            {
                                if (nombreMysterieu[compteur] == saisieint[compteur])
                                {
                                    sortie += "°";
                                }
                                else
                                {
                                    sortie += "*";
                                }
                            }
                        }
                        Console.WriteLine(sortie);
                        if (sortie == "°°°°")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("gagné ! \ntu veux rejouer ? (O)ui/(N)on");
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Console.ReadLine().ToLower() == "o")
                            {
                                return "n";
                            }
                            else
                            {
                                Environment.Exit(0);
                            }
                        }

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Fail ! limité à " + longeurNombreMysterieu + " rejoues ! NOW");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                   
                   
                }
                else
                {
                    switch(saisieConsole)
                    {
                         case "n":
                            return "n";                            
                        case "s":
                             // appel du superMasterMind
                            return "s";                             
                        case "q":
                             Environment.Exit(0);
                             break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("NaN, rejoues ! NOW");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                   
                }
                if (nombreTente == NombreTentationMax)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You LOOSE ! \ntu veux rejouer ? (O)ui/(N)on");

                    if (Console.ReadLine().ToLower() == "o")
                    {
                        return "n";
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
                nombreTente++;
            }
            return "0";
        }

    }
}
