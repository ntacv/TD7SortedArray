using System;

namespace TD7SortedArray
{
    class Program
    {
        static void AfficherTableau(int[] tableau)
        {
            if (tableau == null)
            {
                Console.WriteLine("tableau null");
            }
            else
            {
                if (tableau.Length == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                else
                {
                    for (int i = 0; i < tableau.Length - 1; i++)
                    {
                        Console.Write(tableau[i] + " ; ");
                    }
                    Console.WriteLine("" + tableau[tableau.Length - 1] + "");
                }
            }
        }
        static void AfficherTableauDouble(double[] tableau)
        {
            if (tableau == null)
            {
                Console.WriteLine("tableau null");
            }
            else
            {
                if (tableau.Length == 0)
                {
                    Console.WriteLine("tableau vide");
                }
                else
                {
                    for (int i = 0; i < tableau.Length - 1; i++)
                    {
                        Console.Write(tableau[i] + " ; ");
                    }
                    Console.WriteLine("" + tableau[tableau.Length - 1] + "");
                }
            }
        }
        static int[] GenererTableauAleatoire(int taille, int valeurMin, int valeurMax)
        {
            int[] tableau;
            if (taille > 0)
            {
                tableau = new int[taille];
                Random random = new Random();
                for (int i = 0; i < taille; i++)
                {

                    int number = random.Next(valeurMin, valeurMax + 1);
                    tableau[i] = number;
                }
            }
            else
            {
                tableau = null;
            }
            return tableau;
        }

        static bool Permuter(int[] tableau, int index1, int index2)
        {
            bool possible = false;
            if (tableau != null && tableau.Length != 0 && tableau.Length > index1 && tableau.Length > index2)
            {

                int temp = tableau[index1];
                tableau[index1] = tableau[index2];
                tableau[index2] = temp;

                possible = true;
            }
            return possible;
        }
        static bool SortingArray(int[] tableau)
        {
            bool sorted = false;

            if (tableau != null && tableau.Length != 0)
            {
                bool allSorted = false;
                do
                {
                    for (int i = 0; i < tableau.Length-1; i++)
                    {
                        if (tableau[i] >= tableau[i + 1])
                        {
                            Permuter(tableau, tableau[i], tableau[i + 1]);

                        }
                    }
                } while (!allSorted);
                sorted = true;
            }
            return sorted;
        }
        static void Main(string[] args)
        {

            int[] tableau = GenererTableauAleatoire(5, 0, 10);
            AfficherTableau(tableau);

            SortingArray(tableau);
            AfficherTableau(tableau);


            Console.ReadKey();

        }
    }
}

