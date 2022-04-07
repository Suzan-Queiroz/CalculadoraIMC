using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Digite o seu nome");
            string nome = Console.ReadLine();
 
            Console.WriteLine("\n DIgite a sua altura Ex:1,70");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n IDIgite o seu peso em Kg. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = (peso/(altura*altura));

            Console.WriteLine("\n {0} A sua altura é {1} e o seu peso é {2}", nome, altura, peso);
            Console.WriteLine("\n O seu IMC é {0}", imc);

            if(imc <= 0){
                Console.WriteLine("Esses valores são inválidos");
            }else if(imc < 17){
                Console.WriteLine("Você está muito abaixo do peso");
            }else if(imc > 17 && imc < 18.5){
                Console.WriteLine("Você está abaixo do peso");
            }else if(imc > 18.5 && imc < 25){
                Console.WriteLine("Você está com o peso normal");
            }else if(imc > 25 && imc < 30){
                Console.WriteLine("Você está acima do peso");
            }else if(imc > 30 && imc < 35){
                Console.WriteLine("Você está no grau de obesidade I");
            }else if(imc > 35 && imc < 40){
                Console.WriteLine("Você está no grau de Obesidade II");
            }else  if (imc > 40){
                Console.WriteLine("Obesidade Grau III");
            }
        }
    }
}