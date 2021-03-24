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




        static void Main(string[] args)
        {
            



        }
    }
}
