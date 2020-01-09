using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Henrique {
    class Program {
        static void Main(string[] args) {
            Veiculo veiculo= new Veiculo();
            Boolean verificador = false;

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

            while (verificador == false) {
                Console.Write("\nIndique a quantidade de gasolina: ");
                int gas = veiculo.Litros_gas = Convert.ToInt32(Console.ReadLine());

                if (gas <= 100) {
                    veiculo.Litros_gas = gas;
                    verificador = true;
                } else {
                    Console.WriteLine("Insira uma quantidade inferior a 100 L");
                    verificador = false;
                }
            }


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
            veiculo.Atualizar();

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
                 "\n04 - Acelerar | 05 - Frear    | 06 - Pintar\n" +
                 "Opção: ");


            while (true) {
                
                string opcao = Console.ReadLine();
                if (opcao == null) {
                    Console.WriteLine("po bicho");
                    break;
                }
                switch (Convert.ToInt32(opcao)) {
                    case 01: veiculo.Ligar();
                        veiculo.zerarperg();
                        break;
                    case 02: veiculo.Desligar();
                        veiculo.zerarperg();
                        break;
                    case 03:
                        Console.SetCursorPosition(0, 17);
                        Console.WriteLine("quanto deseja abastecer?");
                        string quant = Console.ReadLine();
                        veiculo.Abastecer(Convert.ToInt32(quant));
                        veiculo.zerarperg();
                        break;
                    case 04: veiculo.Acelerar();
                        veiculo.zerarperg();
                        break;
                    case 05: veiculo.Frear();
                        veiculo.zerarperg();
                        break;
                        //
                        //
                    case 06:
                        Console.WriteLine("Qual a Cor que deseja?");
                        string CorNova = Console.ReadLine();
                        veiculo.Pintar(CorNova);
                        veiculo.zerarperg();
                        break;
                    default:
                        Console.WriteLine("opcao indisponível \n Insira uma opcao existente");
                        veiculo.zerarperg();
                        break;
                }

                //Console.SetCursorPosition(); 17

            }

        }
        
    }
}
