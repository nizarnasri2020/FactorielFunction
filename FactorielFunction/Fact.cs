using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorielFunction
{
    public class Fact
    {


        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choisissez une méthode pour calculer la factorielle, 1 pour Methode Recursive et 2 pour methode iterative");
               
                string choix = Console.ReadLine();

                Console.WriteLine("Entrez un nombre  :");
                int n = int.Parse(Console.ReadLine());

                long resultat;

                switch (choix)
                {
                    case "1":
                        resultat = FactRecursive(n);
                        Console.WriteLine($"Factorielle de {n} avec la methode récursive est : {resultat}");
                        break;
                    case "2":
                        resultat = FactIterative(n);
                        Console.WriteLine($"Factorielle de {n} avec la methode itérative est : {resultat}");
                        break;
                    default:
                        Console.WriteLine(" invalide.");
                        break;
                }
            }
           
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }




        // Recursive Method
        public static long FactRecursive(int n)
        {
            try
            {
                if (n < 0)
                    throw new ArgumentException("n doit être >= 0");

                if (n == 0)
                    return 1;

                return n * FactRecursive(n - 1);
            }
            catch (Exception)
            {
               
                throw;
            }
            
        }

        //  Iterative Method
        public static long FactIterative(int n)
        {
            try
            {
                if (n < 0)
                    throw new ArgumentException("n doit être >= 0");

                long result = 1;
                for (int i = 1; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
