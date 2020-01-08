using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Henrique {
    class Program {
        static void Main(string[] args) {
            Veiculo veiculo= new Veiculo();

            //Preenchimento
            Console.Write("Indique a marca do veículo: ");
            veiculo.Marca = Console.ReadLine();

            Console.WriteLine("\nIndique qual o modelo do seu veículo: ");
            veiculo.Modelo = Console.ReadLine();

            Console.WriteLine("\nIndique qual a placa do seu veículo: ");
            veiculo.Placa = Console.ReadLine();

            Console.WriteLine("\nIndique quanto custa seu veículo em R$: ");
            veiculo.Preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nIndique a cor do seu veículo: ");
            veiculo.Cor = Console.ReadLine();


        }
    }
}
