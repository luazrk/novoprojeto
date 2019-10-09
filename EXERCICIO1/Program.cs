using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior, menor;




            Console.Write("Receber n1 do usuario: ");
            maior = int.Parse(Console.ReadLine());
            Console.Write("Receber n2 do usuario: ");
            menor = int.Parse(Console.ReadLine());
            Console.WriteLine("A diferença de n1: " + maior + " e n2: " + menor + " é: " + diferenca(maior, menor));
            Console.ReadKey();
        }
        static int diferenca(int maior, int menor)
        {
            string D = "";
            if (maior > menor)
                return maior - menor;
            else
                return menor - maior;
        }

    }
}
}
