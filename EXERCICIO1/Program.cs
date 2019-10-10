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



            // alteração no Console.Write
            Console.Write("Receber pimeiro número do usuario: ");
            maior = int.Parse(Console.ReadLine());
            Console.Write("Receber segundo número do usuario: ");
            menor = int.Parse(Console.ReadLine());
            Console.WriteLine("A diferença de n1: " + maior + " e n2: " + menor + " é: " + dife(maior, menor));
            Console.ReadKey();
        }
        static int dife(int maior, int menor)
            // mudei o nome do metodo
        {
            // tinha uma chave a mais
            string D = "";
            if (maior > menor)
                return maior - menor;
            else
                return menor - maior;
        }

    }
}

