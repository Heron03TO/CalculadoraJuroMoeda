using System;

namespace calculadoraMultifuncao // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)

        { int opcao = 0;
           do
           {
            Console.WriteLine("Olá, escolha uma das opções abaixo");
            Console.WriteLine("1. Calculadora de juros");
            Console.WriteLine("2. Conversão de moedas estrangeiras para reais");
            Console.WriteLine("3. Sair");
           
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                
                Console.WriteLine("Informe o valor da prestação: ");
                double valorPrestacao = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe a taxa de juros (%): ");
                double taxa = double.Parse(Console.ReadLine()) / 100;
                Console.WriteLine("Informe o numero de prestações restante: ");
                int numeroPrestacao = int.Parse(Console.ReadLine());

                double valorTotal = valorPrestacao * Math.Pow(1 + taxa, numeroPrestacao);
                Console.WriteLine("O valor total pago após "+numeroPrestacao+ " será de: "+valorTotal+ " reais");

                break;
                
                case 2:
                Console.WriteLine("Qual a cotação atual em R$ da moeda desejada?");
                double cotacao = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite o valor em R$ que deseja converter: ");
                double valor = double.Parse(Console.ReadLine());

                double valorConvertido = cotacao * valor;
                Console.WriteLine("O valor convertido em R$ é: "+valorConvertido);

                break;

                case 3:
                Console.WriteLine("Encerrando o programa, até mais!");
                break;

                default:
                Console.WriteLine("Opção inválida, tente novamente!");
                break;
                
            }  
                
           }  while(opcao != 3);
        } 
    }
}
