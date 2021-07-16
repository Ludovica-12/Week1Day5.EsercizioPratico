using System;
using System.Collections.Generic;

namespace Week1Day5.EsercizioPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Benvenuto a Tombola!---");
            
            Console.WriteLine("Inserisci 5 Numeri");
            
            ScegliNumero();
            
            int[] num = new int[91];
            int numeri = 91;
            Random r = new Random();
            

            for (int x = 1; x <= 90; x++) 
            { 
                num[x] = x; 
            } 

            int estrazione = 1;
            while (estrazione < 5)
            {
                int casuale = r.Next(1, numeri);

                if (casuale != numeri - 1)
                {
                    num[numeri - 1] = num[casuale];
                    num[casuale] = num[numeri - 1];
                    num[numeri - 1] = num[casuale];

                    Console.WriteLine(estrazione + "° estratto = " + num[numeri - 1]);
                    numeri = numeri - 1;
                    estrazione++;
                }
            }

            /*TODO: 
             * Per risolvere il punto 6 della traccia
             * avrei comparato l'array dei numeri scelti con
             * l'array dei numeri estratti casuali
             * per poi ciclare e vedere giro dopo giro quali erano i numeri
             * uguali e di conseguenza stampare
             * i messaggi di vincita o in caso contrario di perdita*/
            




        }

        private static void ScegliNumero()
        {
            int n1, n2, n3, n4, n5;

            Console.WriteLine("\nInserisci il primo numero");
            n1 = int.Parse(Console.ReadLine());
            /*if (!SceltaErrata(n1))
            {
                Console.WriteLine("\nInserisci di nuovo il primo numero");
                n1 = int.Parse(Console.ReadLine());

                SceltaErrata(n1);

            }*/


            Console.WriteLine("Inserisci il secondo numero");
            n2 = int.Parse(Console.ReadLine());

            //SceltaErrata();

            if (n1 == n2)
            {
                Console.WriteLine("Numero già inserito inserirne un altro!");
                n2 = int.Parse(Console.ReadLine());

            }


            Console.WriteLine("\nInserisci il terzo numero");
            n3 = int.Parse(Console.ReadLine());

            //SceltaErrata();

            if (n2 == n3 || n3 == n1)
            {
                Console.WriteLine("Numero già inserito inserirne un altro!");
                n3 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nInserisci il quarto numero");
            n4 = int.Parse(Console.ReadLine());

            //SceltaErrata();

            if (n3 == n4 || n4 == n2 || n4 == n1)
            {
                Console.WriteLine("Numero già inserito inserirne un altro!");
                n4 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\nInserisci il 5 numero");
            n5 = int.Parse(Console.ReadLine());

            //SceltaErrata();

            if (n4 == n5 || n5 == n3 || n5 == n2 || n5 == n1)
            {
                Console.WriteLine("Numero già inserito inserirne un altro!");
                n5 = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("I numeri da te scelti sono: " + "\n" + n1 + "\n" + n2 + "\n" + n3 + "\n" + n4 + "\n" + n5);
            Console.WriteLine("Premi invio per scoprire i numeri estratti");
            Console.ReadLine();

        }

        /*private static bool SceltaErrata(int n)
        {
            while (!int.TryParse(Console.ReadLine(), out n) || n >= 1 || n <= 90)

            {
                Console.WriteLine("Scelta errata. Deve essere un intero compreso tra 1 e 90. riprova");
                return true;
            }

            return false;
        }*/
    }
}
