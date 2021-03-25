//TD7 d'algorithmique
//Nathan Choukroun
//Esilv A1S2
//TD N2

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
                bool notAllSorted = true;
                for(int j=0; j<tableau.Length && notAllSorted; j++)
                {
                    notAllSorted = false;
                    for (int i = 0; i < tableau.Length-1-j; i++)
                    {
                        if (tableau[i] > tableau[i + 1])
                        {
                            Permuter(tableau, i, i + 1);
                            notAllSorted = true;
                        }
                    }
                }
                sorted = true;
            }
            return sorted;
        }
        static bool SortingArrayWhile(int[] tableau)
        {
            bool sorted = false;

            if (tableau != null && tableau.Length != 0)
            {
                bool notAllSorted = true;
                int j = 0;
                do
                {
                    notAllSorted = false;
                    for (int i = 0; i < tableau.Length - 1-j; i++)
                    {
                        if (tableau[i] > tableau[i + 1])
                        {
                            Permuter(tableau, i, i + 1);
                            notAllSorted = true;
                        }
                    }
                    j++;
                } while (notAllSorted);
                sorted = true;
            }
            return sorted;
        }

        static bool SortingArray2(int[] tableau)
        {
            bool sorted = false;

            if (tableau != null && tableau.Length != 0)
            {
                for(int i = 0; i<tableau.Length; i++)
                {
                    for (int j = 0; j < tableau.Length - 1 - i; j++)
                    {
                        if (tableau[j] > tableau[j + 1])
                        {
                            Permuter(tableau, j, j+1);
                        }
                    }
                }
                sorted = true;
            }
            return sorted;
        }
        static bool SortingArrayInverted(int[] tableau)
        {
            bool sorted = false;

            if (tableau != null && tableau.Length != 0)
            {
                bool notAllSorted = true;
                for (int j = 0; j < tableau.Length && notAllSorted; j++)
                {
                    notAllSorted = false;
                    for (int i = tableau.Length-1-j; i >0; i--)
                    {
                        if (tableau[i] < tableau[i - 1])
                        {
                            Permuter(tableau, i-1, i);
                            notAllSorted = true;
                        }
                    }
                }
                sorted = true;
            }
            return sorted;
        }
        static bool SortingArrayOneTwo(int[] tableau)
        {
            bool sorted = false;

            if (tableau != null && tableau.Length != 0)
            {
                bool notAllSorted = true;
                for (int i = 0; i < tableau.Length && notAllSorted; i++)
                {
                    notAllSorted = false;
                    for(int j=i; j<tableau.Length-1; j++)
                    {
                        if(tableau[j] > tableau[j + 1])
                        {
                            Permuter(tableau, j, j + 1);
                            notAllSorted = true;
                            AfficherTableau(tableau);
                        }
                    }
                    for(int k=i; k<tableau.Length-1; k++)
                    {
                        if(tableau[tableau.Length - k] > tableau[tableau.Length - k - 1])
                        {
                            Permuter(tableau, tableau.Length - k, tableau.Length - k - 1);
                            notAllSorted = true;
                            AfficherTableau(tableau);
                        }
                    }
                }
                sorted = true;
            }
            return sorted;
        }
        static bool SortingArrayOneTwo2(int[] tableau)
        {
            bool sorted = false;
            int temp;
            if (tableau != null && tableau.Length != 0)
            {
                bool notAllSorted = true;
                for (int i = 0; i < tableau.Length && notAllSorted; i++)
                {
                    notAllSorted = false;
                    for (int k = i; k < tableau.Length - 1 - i; k++)
                    {
                        if (tableau[k] > tableau[k + 1])
                        {
                            temp = tableau[k];
                            tableau[k] = tableau[k + 1];
                            tableau[k + 1] = temp;
                            notAllSorted = true;
                        }
                        else
                        {
                            tableau[k] = tableau[k];


                        }

                    }
                    for (int j = tableau.Length - 1 - i; j > i; j--)
                    {
                        if (tableau[j] < tableau[j - 1])
                        {
                            temp = tableau[j];
                            tableau[j] = tableau[j - 1];
                            tableau[j - 1] = temp;
                            notAllSorted = true;
                        }
                        else
                        {
                            tableau[j] = tableau[j];

                        }
                    }

                }
                sorted = true;
            }
            return sorted;
        }

        static void Main(string[] args)
        {

            int[] tableau = GenererTableauAleatoire(5, 0, 10);
            AfficherTableau(tableau);

            Console.WriteLine(SortingArrayOneTwo2(tableau));
            AfficherTableau(tableau);


            Console.ReadKey();

        }
    }
}

