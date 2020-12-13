using System;

namespace Cafeteira.classes
{
    public class MaquinaCafe
    {
        private float acucarDisponivel = 300;

        public void FazerCafe(string stringQuantidadeAcucar){
            if (stringQuantidadeAcucar == "")
            {
                this.FazerCafe();
            }else{
                float floatQuantidadeAcucar = float.Parse(stringQuantidadeAcucar);
                if (this.acucarDisponivel>=floatQuantidadeAcucar)
                {
                    this.acucarDisponivel = this.acucarDisponivel - floatQuantidadeAcucar;
                    Console.WriteLine($"Café feito com {floatQuantidadeAcucar} gramas de açúcar");
                }else{
                    Console.WriteLine($"A maquina só tem {this.acucarDisponivel} gramas de açúcar");
                    Console.WriteLine($"Deseja fazer o café com essa quantidade ou fazer sem açúcar? s/n");
                    string resposta = Console.ReadLine();
                    if (resposta == "s")
                    {
                        Console.WriteLine($"Café feito com {this.acucarDisponivel} gramas de açúcar");
                        this.acucarDisponivel = this.acucarDisponivel - this.acucarDisponivel;
                    }else{
                        Console.WriteLine("Café feito sem açúcar");
                    }
                    
                }
            }
        }
        public void FazerCafe(){
            if (acucarDisponivel>=10)
            {
                this.acucarDisponivel = this.acucarDisponivel - 10;
                Console.WriteLine("Café feito com 10 gramas de açúcar");
            }else{
            Console.WriteLine($"A maquina só tem {this.acucarDisponivel} gramas de açúcar");
            Console.WriteLine($"Deseja fazer o café com essa quantidade ou fazer sem açúcar? s/n");
            string resposta = Console.ReadLine();
            if (resposta == "s")
            {
                Console.WriteLine($"Café feito com {this.acucarDisponivel} gramas de açúcar");
                this.acucarDisponivel = this.acucarDisponivel - this.acucarDisponivel;
            }else{
                Console.WriteLine("Café feito sem açúcar");
            }
            }
        }
    }
}