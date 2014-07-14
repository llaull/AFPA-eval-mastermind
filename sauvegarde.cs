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
            RandoNumber rand = new RandoNumber();

            int nombreTente = 0;
            Console.WriteLine("nombre generred : ");
            int[] nombre = new int[4];
            for (int i = 0; i < 4; i++)
            {
                nombre[i] = rand.RandomNumber(0, 8);
                Console.Write(nombre[i] + " ");
            }
            Console.WriteLine();
            /*int nombre1 = rand.RandomNumber(0, 8);
            int nombre2 = rand.RandomNumber(0, 8);
            int nombre3 = rand.RandomNumber(0, 8);
            int nombre4 = rand.RandomNumber(0, 8);

            string nombreSecret = nombre1.ToString() + nombre2.ToString() + nombre3.ToString() + nombre4.ToString();*/

            string sortie = "";
            

            //Console.WriteLine("nombre generred : " + nombre1 + " " + nombre2 + " " + nombre3 + " " + nombre4);


            while ((nombreTente != 8))
            {
               /* Console.WriteLine("essayes ! ");
                sortie = "";
                if (nombreTente == 7) Console.WriteLine("derniere tentativeeeeee ! ");
                string saisie = Console.ReadLine();

                if (saisie.Length != 4)
                {
                    Console.WriteLine("erreur de saisi");
                }
                else
                {
                    int[] saisieint = new int[4];
                    for (int i = 0; i < saisieint.Length; i++)
                    {
                        saisieint[i] = int.Parse(saisie[i].ToString());
                    }
                    //MatchCollection matches = Regex.Matches(nombreSecret, "");
                    //Console.WriteLine(matches.Count);

                    int[] checknumero = new int[4];
                    int compteur;
                    for (compteur = 0; compteur < 4; compteur++)
                    {
                        //checknumero[compteur] = Regex.Matches(nombreSecret, saisie[compteur].ToString()).Count;
                        checknumero[compteur] = nombre.Contains(saisieint[compteur]) ? 1 : 0;
                        if (checknumero[compteur] >= 1)
                        {
                            if (nombre[compteur] == saisieint[compteur]) { sortie += "°"; } else { sortie += "*"; }
                        }
                    }
                */
                    /*
                    int checkNumero1 = Regex.Matches(nombreSecret, saisie[0].ToString()).Count;
                    int checkNumero2 = Regex.Matches(nombreSecret, saisie[1].ToString()).Count;
                    int checkNumero3 = Regex.Matches(nombreSecret, saisie[2].ToString()).Count;
                    int checkNumero4 = Regex.Matches(nombreSecret, saisie[3].ToString()).Count;

                    // Console.WriteLine(nombre1.ToString() + " + " + saisaie[0].ToString() + " = " + checkNumero1); 
                    //Console.WriteLine(nombre2.ToString() + " + " + saisaie[1].ToString() + " = " + checkNumero2);
                    //Console.WriteLine(nombre3.ToString() + " + " + saisaie[2].ToString() + " = " + checkNumero3);
                    // Console.WriteLine(nombre4.ToString() + " + " + saisaie[3].ToString() + " = " + checkNumero4);


                    if (checkNumero1 >= 1) { if (nombre1.ToString() == saisie[0].ToString()) { sortie = "°"; } else { sortie = "*"; } }
                    if (checkNumero2 >= 1) { if (nombre2.ToString() == saisie[1].ToString()) { sortie += "°"; } else { sortie += "*"; } }
                    if (checkNumero3 >= 1) { if (nombre3.ToString() == saisie[2].ToString()) { sortie += "°"; } else { sortie += "*"; } }
                    if (checkNumero4 >= 1) { if (nombre4.ToString() == saisie[3].ToString()) { sortie += "°"; } else { sortie += "*"; } }*/

                   // if (sortie == "°°°°") Console.WriteLine("ok");
                  /*  Console.WriteLine(sortie);
                    
                    nombreTente += 1;
                    if (sortie == "°°°°") { Console.WriteLine("ok"); nombreTente = 8; }
                }
            }
            Console.WriteLine("you loose ! ");
            Console.ReadLine();*/


          /*  if (checkNumero1 != 0)
            {
                Console.WriteLine(nombre1.ToString() + " + " + saisaie[0].ToString() + " = " + checkNumero1); sortie = "*";
            }
            else
            {
                Console.WriteLine(checkNumero1); sortie = "*";
            }

            if (checkNumero2 != 0)
            {
                Console.WriteLine(checkNumero2); sortie = "*";
            }
            else
            {
                Console.WriteLine(checkNumero2); sortie = "*";
            }
            if (checkNumero3 != 0)
            {
                Console.WriteLine(checkNumero3); sortie = "*";
            }
            else
            {
                Console.WriteLine(checkNumero3); sortie = "*";
            }
            if (checkNumero4 != 0)
            {
                Console.WriteLine(checkNumero4); sortie = "*";
            }
            else
            {
                Console.WriteLine(checkNumero4); sortie = "*";
            }


            */
            /*Console.WriteLine(nombre2.ToString() + " > " + Regex.Matches(nombreSecret, saisaie[1].ToString()).Count);
            Console.WriteLine(nombre3.ToString() + " > " + Regex.Matches(nombreSecret, saisaie[2].ToString()).Count);
            Console.WriteLine(nombre4.ToString() + " > " + Regex.Matches(nombreSecret, saisaie[3].ToString()).Count);*/

            



            /*if (nombre1 == int.Parse(saisaie.Substring(0,1))) sortie = "_"; else sortie = "°";
            Console.WriteLine("resultat -> " + int.Parse(saisaie[0].ToString()) + " > " + sortie);

            if (nombre2 == int.Parse(saisaie[1].ToString())) sortie += "_"; else sortie += "°"; 
            Console.WriteLine("resultat -> " + int.Parse(saisaie[1].ToString()) + " > "+ sortie);

            if (nombre3 == int.Parse(saisaie[2].ToString())) sortie += "_"; else sortie += "°";
            Console.WriteLine("resultat -> " + int.Parse(saisaie[2].ToString()) + " > " + sortie);


            if (nombre4 == int.Parse(saisaie[3].ToString())) sortie += "_"; else sortie += "°";
            Console.WriteLine("resultat -> " + int.Parse(saisaie[3].ToString()) + " > " + sortie);
            */
          /*  string searchWithinThis = nombreSecret;
            string searchForThis = nombre1.ToString();
            int firstCharacter = searchWithinThis.IndexOf(searchForThis);

           // Console.WriteLine("First occurrence: {0}", firstCharacter);*/

            
        }
    }
}
