using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Desafio_Henrique {
    class Veiculo {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public Boolean esta_ligado { get; set; }
        public int Litros_gas { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public void Ligar() {
            if (esta_ligado == false) {
                Console.WriteLine("Seu carro está Ligado");
                Pausinha();
                esta_ligado = true;
            } else {
                Console.WriteLine("Seu veículo já está ligado");
            }
        }

        public void Desligar() {
            if (esta_ligado == true && Velocidade == 0) {
                Console.WriteLine("Seu carro está desligado");
                esta_ligado = false;
            } else if (esta_ligado == true && Velocidade > 0) {
                Console.WriteLine("Pare o carro antes de desligar");
            } else {
                Console.WriteLine("Seu carro já está desligado");
            }
        }

        public void Acelerar() {

            if (esta_ligado == true && Conferir_gas() != "vazio") {
                Velocidade = Velocidade + 20;
                if (Conferir_gas() == "cheio") {
                    Litros_gas = -1;
                    if (Conferir_gas() == "vazio") {
                        Console.WriteLine("Sem gasolina");
                    }
                    if (Conferir_gas() == "baixo") {
                        Console.WriteLine("Pouca gasolina");
                    }
                }
                if (Velocidade > 140) {
                    Console.WriteLine("Excesso de velocidade dá ruim");
                }
            } else {
                Console.WriteLine("o seu veículo está desligado no momento");
            }
        }

        public void Abastecer(int quant_litros) {
            if (Litros_gas < 100) {
                int verificar = Litros_gas + quant_litros;
                if (verificar < 100) {
                    Litros_gas =+ quant_litros;
                    Writeat(21, 9, Convert.ToString(Litros_gas));
                    Console.WriteLine("");
                } else {
                    Console.WriteLine("O tanque já está cheio");
                }
            }
        }

        public void Frear() {
            if (esta_ligado == true && Velocidade > 0) {
                Velocidade = -10;
            }
            if (Velocidade > 8000) {
                Console.WriteLine("chama o samu");
            }
        }

        public void Pintar(string cor_nova) {
            if (Cor != cor_nova) {
                Cor = cor_nova;
            } else {
                Console.WriteLine("Seu veículo já possui está cor");
            }
        }

        public string Conferir_gas() {
            string nivel = "";
            if (Litros_gas == 100) {
                nivel = "cheio";
            } else if (Litros_gas < 50) {
                nivel = "metade";
            } else if (Litros_gas < 10) {
                nivel = "baixo";
            } else if (Litros_gas == 0) {
                nivel = "vazio";
            }
            return nivel;
        }

        public void Pausinha() {
            Thread.Sleep(TimeSpan.FromMilliseconds(600));
        }
        public void Writeat(int left, int top, string frase) {
            Console.SetCursorPosition(left, top);
            Console.Write(frase);
        }
    }


}
