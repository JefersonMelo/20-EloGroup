using System;

namespace AbastecimentoF1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Entre com a extensão da pista");
			double tPista = double.Parse(Console.ReadLine());  //3,5

			Console.WriteLine("Entre com o número de voltas do GP");
			int nVoltas = int.Parse(Console.ReadLine());

			Console.WriteLine("Entre com número de reabastecimentos desejados");
			int nAbastecimentos = int.Parse(Console.ReadLine());

			Console.WriteLine("Entre com o consumo de combustível do carro (em Km/L)");
			double consumo = double.Parse(Console.ReadLine());//2

			double pitStop = (nVoltas / nAbastecimentos) / consumo;
			double resposta = pitStop * tPista;


			Console.WriteLine($"litros necessários para percorrer até o primeiro reabastecimento: {resposta}");
		}
	}
}
