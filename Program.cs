using System;
using Cafeteira.classes;

namespace Cafeteira
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe cafe = new MaquinaCafe();
            bool opcao = true;
            bool opcao2 = true;
            do
            {
                Console.WriteLine($"Quanto de açúcar você quer no café?");
                Console.WriteLine("Se você quiser 10 gramas não precisa informar um valor");
                string stringQuantidadeAcucar = Console.ReadLine();
                cafe.FazerCafe(stringQuantidadeAcucar);

                do
                {
                    Console.WriteLine($"Deseja fazer mais um café? s/n");
                    string resposta1 = Console.ReadLine();
                    if (resposta1 == "n")
                    {
                        Console.WriteLine("Obrigado por usar a Super CafeteiraTabajaras Plus++");
                        opcao = false;
                        opcao2 = false;
                    }else if(resposta1 == "s"){
                        opcao2 = false;
                    }else{
                        Console.WriteLine("Você digitou uma opção inválida");
                    }
                } while (opcao2 != false);
            } while (opcao != false);
            
        }
    }
}
