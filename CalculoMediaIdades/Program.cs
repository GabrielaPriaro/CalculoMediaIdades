//Problema "media_idades"
//Faça um programa para ler um número indeterminado de dados, contendo cada um, a idade de um
//indivíduo. O último dado, que não entrará nos cálculos, contém um valor de idade negativa. Calcular
//e imprimir a idade média deste grupo de indivíduos. Se for entrado um valor negativo na primeira vez,
//mostrar a mensagem "IMPOSSIVEL CALCULAR". 

using System.Globalization;
using System.Runtime.Serialization;

namespace CalculoMediaIdades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite as idades:");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0)
            {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else
            {
                while (idade > 0)
                {
                    soma = soma + idade;
                    cont = cont + 1;

                    idade = int.Parse(Console.ReadLine());
                }

                media = (double)soma / cont;

                Console.WriteLine($"MEDIA = {media.ToString("F2", CI)}");
            }
        }
    }
}   
