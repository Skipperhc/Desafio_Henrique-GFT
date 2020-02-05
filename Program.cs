using desafio_veiculo.Entidade;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_veiculo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine($"01 - carro | 02 - Avião | 03 - Caminhão");
            int opcao = VerificarOpcao(Convert.ToInt32(Console.ReadLine()));
            var vei = DefVeiculo(opcao);
            CompletarInf(vei);
            Console.Clear();
            escrevernatela(vei);
            Writeat(3, 10, $"\nO que você deseja: " +
                $"\n01 - Ligar    | 02 - Desligar | 03 - Abastecer" +
                 "\n04 - Acelerar | 05 - Frear    | 06 - Pintar\n" +
                 "Opção: ");
        }
        public static void Comeco() {
            while (true) {

            }
        }
        public static void SelecaoOpcao(Veiculo vei, int opcao) {
            switch (Convert.ToInt32(opcao)) {
                case 01:
                    vei.Ligar();
                    break;
                case 02:
                    vei.Desligar();
                    Writeat(2, 15, "Seu veículo está ligado");
                    break;
                case 03:
                    Writeat(2, 15, "Quanto deseja abastecer?\n");
                    string quant = Console.ReadLine();
                    vei.abastecer(Convert.ToInt32(quant));
                    Writeat(2, 17, "Veículo abastecido");
                    break;
                case 04:
                    vei.Acelerar();
                    Writeat(2, 15, "Acelerando");
                    break;
                case 05:
                    vei.Frear();
                    Writeat(2, 15, "Freiou");
                    break;
                case 06:
                    Writeat(2, 15, "Qual a Cor que deseja?\n");
                    string CorNova = Console.ReadLine();
                    vei.Pintar(CorNova);
                    Writeat(2, 17, $"{vei.veiculo} pintado");
                    break;
                default:
                    Console.WriteLine("opcao indisponível \n Insira uma opcao existente");
                    break;
            }
            Pausinha();
            PreencherCampos(vei);
        }

        public static void Pausinha() {
            Thread.Sleep(1000);
        }
        public static Veiculo DefVeiculo(int opcao) {
            var vei = new Veiculo();
            switch (opcao) {
                case 1:
                    vei = new Carro(opcao);
                    vei.veiculo = "Carro";
                    break;
                case 2:
                    vei = new Caminhao(opcao);
                    vei.veiculo = "Caminhão";
                    break;
                case 3:
                    vei = new Aviao(opcao);
                    vei.veiculo = "Avião";
                    break;
            }
            vei.esta_ligado = false;
            return vei;
        }
        public static void CompletarInf(Veiculo vei) {
            if (vei.Escolha == 1 || vei.Escolha == 2) {
                Console.WriteLine($"Qual a marca do seu {vei.veiculo}?");
                vei.Marca = Console.ReadLine();
                Console.WriteLine($"Qual a placa do seu {vei.veiculo}?");
                vei.Placa = Console.ReadLine();
            }
            Console.WriteLine($"Qual a cor do seu {vei.veiculo}?");
            vei.Cor = Console.ReadLine();
            Console.WriteLine($"Qual o modelo do seu {vei.veiculo}?");
            vei.Modelo = Console.ReadLine();
            Console.WriteLine($"Qual o preço do seu {vei.veiculo}?");
            vei.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Quanto deseja abastecer em seu {vei.veiculo}");
            vei.Litros_gas = Convert.ToInt32(Console.ReadLine());
        }

        public static int VerificarOpcao(int opcao) {
            if (opcao > 0 && opcao <= 3) {
                return opcao;
            }
            return VerificarOpcao(Convert.ToInt32(Console.ReadLine()));
        }


        public static void PreencherCampos(Veiculo vei) {
            Writeat(123, 23, "");
        }
        public static void escrevernatela(Veiculo vei) {
            if (vei.Escolha == 1 || vei.Escolha == 2) {
                Console.WriteLine($"status: \n\n" +
                    $"Você escolheu um {vei.veiculo}\n\n" +
                    $"Marca: {vei.Marca}\n" +//7, 4
                    $"Modelo: {vei.Modelo}\n" +//8, 5
                    $"Placa: {vei.Placa}\n" +//8, 6
                    $"Cor: {vei.Cor}\n" +//5, 7
                    $"Preço: {vei.Preco}\n");//7, 8
            } else {
                Console.WriteLine($"status: \n\n" +
                    $"Você escolheu um {vei.veiculo}\n\n" +
                    $"Modelo: {vei.Modelo}\n" +//8, 4
                    $"Cor: {vei.Cor}\n" +//5, 5
                    $"Preço: {vei.Preco}\n");//7, 6
            }
            Writeat(40, 4, $"Velocidade: {vei.Velocidade}");
            Writeat(40, 5, $"Km: {vei.Km}");
            Writeat(40, 6, $"Litros abastecido: {vei.Litros_gas}");
        }
        public static void Writeat(int left, int top, string frase) {
            Console.SetCursorPosition(left, top);
            Console.Write(frase);
        }
    }
}


