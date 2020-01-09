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

            Console.Write("\nIndique qual o modelo do seu veículo: ");
            veiculo.Modelo = Console.ReadLine();

            Console.Write("\nIndique qual a placa do seu veículo: ");
            veiculo.Placa = Console.ReadLine();

            Console.Write("\nIndique quanto custa seu veículo em R$: ");
            veiculo.Preco = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nIndique a cor do seu veículo: ");
            veiculo.Cor = Console.ReadLine();

            Console.Clear();
            Console.WriteLine($"Status: \n\n" +
                $"\nMarca: " + //8, 3
                $"\nModelo: " +//9, 4
                $"\nPreço: " +//8, 5
                $"\nPlaca: " +//8, 6
                $"\nCor: " +//6, 7
                $"\nVelocidade: " +//13, 8
                $"\nLitros de gasolina: " +//21, 9
                $"\nKM: ");//5, 10

            veiculo.Writeat(8,3, veiculo.Marca);
            veiculo.Writeat(9,4, veiculo.Modelo);
            veiculo.Writeat(8,5, Convert.ToString(veiculo.Preco));
            veiculo.Writeat(8,6, veiculo.Placa);
            veiculo.Writeat(6,7, veiculo.Cor);
            veiculo.Writeat(13,8, Convert.ToString(veiculo.Velocidade));
            veiculo.Writeat(21,9, Convert.ToString(veiculo.Litros_gas));
            veiculo.Writeat(5,10, Convert.ToString(veiculo.Km));

            Console.WriteLine("\nO que você deseja: ");
            Console.WriteLine($"\n" +
                $"01 - Ligar    | 02 - Desligar | 03 - Abastecer" +
                 "\n04 - Acelerar | 05 - Frear    | 06 - Pintar\n");


            while (true) {
                
                string opcao = Console.ReadLine();

                switch (Convert.ToInt32(opcao)) {
                    case 01: veiculo.Ligar();
                        break;
                    case 02: veiculo.Desligar();
                        break;
                    case 03:
                        Console.WriteLine("quanto deseja abastecer?");
                        string quant = Console.ReadLine();
                        veiculo.Abastecer(Convert.ToInt32(quant));
                        break;
                    case 04: veiculo.Acelerar();
                        break;
                    case 05: veiculo.Frear();
                        break;
                    case 06:
                        Console.WriteLine("Qual a Cor que deseja?");
                        string CorNova = Console.ReadLine();
                        veiculo.Pintar(CorNova);
                        break;
                    default:
                        Console.WriteLine("opcao indisponível \n Insira uma opcao existente");
                        break;
                }
            }

        }
        
    }
}
