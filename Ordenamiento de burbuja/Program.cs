using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ordenamiento_de_burbuja
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> numero = new List<int>();

           numero.Add(5);
           numero.Add(2);
           numero.Add(1);
           numero.Add(8);
           numero.Add(4);
           numero.Add(3);

           int t;
           Console.WriteLine("Lista Desordenada: ");
           for (int k = 0; k < numero.Count; k++)
           {
               Console.WriteLine(numero[k]+" ");
           }
           for (int i = 1; i < numero.Count; i++)
           {
               for (int j = numero.Count - 1; j >= i; j--)
               {
                   if (numero[j - 1] > numero[j])
                   {
                       t = numero[j - 1];
                       numero[j - 1] = numero[j];
                       numero[j] = t;
                   }
               }
           }
           Console.WriteLine("Lista Ordenada: ");
           for (int f = 0; f < numero.Count; f++)
           {
               Console.WriteLine(numero[f]+" ");
           }
        }
    }
}
