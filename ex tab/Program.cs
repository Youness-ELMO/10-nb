using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] tab = new int[10];
            int s = 0;
            // remplissage est calcule de la somme
            Console.WriteLine("entrez les elements du tableau");
            for (int i = 0; i < 10; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());

                s = s + tab[i];
            }
            int max = tab[0];
            int min = tab[0];
            int pmax = 0;
            int pmin = 0;

            for (int i = 0; i < 10; i++)
                {
                    if (tab[i] > max)
                    {
                        max = tab[i];
                       pmax = i;

                    }

                    else if (tab[i] < min)
                    {
                        min = tab[i];
                        pmin = i;

                    }
                    
            }
            
            Console.WriteLine("la somme est: " + s);
            Console.WriteLine("la moyenne est:  " + s / 10);
            Console.WriteLine("le max est:  " + max + " sa position est:  "+pmax);
            Console.WriteLine("le min est:  " + min + " sa position est:  " + pmin);





            Console.ReadKey();

        }

    }
}
