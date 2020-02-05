using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace desafio_veiculo {
    class Veiculo {

        public string veiculo { get; set; }
        public int Escolha { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public bool esta_ligado { get; set; }
        public int Litros_gas { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }
        

        public virtual void abastecer(int qtd) {
            Abastecer(qtd);
        }

        public void Ligar() {
            if (esta_ligado == false) {
                esta_ligado = true;
                Writeat(2, 15, "Seu veículo está ligado");
            } else {
                Writeat(2,15, "Seu veiculo já está ligado");
            }
        }

        public void Desligar() {
            if (esta_ligado == true && Velocidade == 0) {
                Console.WriteLine("Seu carro está desligado");
                esta_ligado = false;
                Atualizar();
            } else if (esta_ligado == true && Velocidade > 0) {
                Console.WriteLine("Pare o carro antes de desligar");
            } else {
                Console.WriteLine("Seu carro já está desligado");
            }
            Pausinha();
        }

        public void Acelerar() {

            if (esta_ligado == true && Conferir_gas() != "vazio") {
                Velocidade = Velocidade + 20;
                Litros_gas = Litros_gas - 1;
                Atualizar();
                if (Conferir_gas() == "cheio" || Conferir_gas() == "abastecido" || Conferir_gas() == "baixo") {
                    Atualizar();
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
            Pausinha();
        }

        private void Abastecer(int quant_litros) {
            if (Litros_gas < 100) {
                int verificar = Litros_gas + quant_litros;
                if (verificar <= 100) {
                    Litros_gas = Litros_gas + quant_litros;
                    Atualizar();
                    Console.WriteLine("");
                } else if (verificar > 100) {
                    Console.WriteLine("\nO tanque já está cheio");
                }
            }
            Pausinha();
        }

        public void Frear() {
            if (esta_ligado == true && Velocidade > 0) {
                Velocidade = Velocidade - 10;
            } else if (esta_ligado == false) {
                Console.WriteLine("seu carro está desligado");
            }
            if (Velocidade > 8000) {
                Console.WriteLine("chama o samu");
            }
            Atualizar();
        }

        public void Pintar(string cor_nova) {
            if (Cor != cor_nova) {
                Cor = cor_nova;
            } else {
                Console.WriteLine("Seu veículo já possui está cor");
            }
            Atualizar();
        }

        public string Conferir_gas() {
            //estou achando um metodo inutil
            string nivel = "";
            if (Litros_gas == 100) {
                nivel = "cheio";
            } else if (Litros_gas > 10 && Litros_gas < 50) {
                nivel = "abastecido";
            } else if (Litros_gas < 10 && Litros_gas > 0) {
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

        public void Writeatgas(int left, int top, int gas) {
            Console.SetCursorPosition(left, top);
            Console.Write(gas);
        }

        public void Atualizar() {
            Writeat(8, 3, Marca);
            Writeat(9, 4, Modelo);
            Writeat(8, 5, Convert.ToString(Preco));
            Writeat(8, 6, Placa);
            Writeat(6, 7, Cor);
            Writeat(13, 8, Convert.ToString(Velocidade));
            Writeat(21, 9, "    ");
            Writeatgas(21, 9, Litros_gas);
            Writeat(5, 10, Convert.ToString(Km));
            string status = "";
            if (esta_ligado == true) {
                status = "ligado                       ";
            } else {
                status = "Desligado                     ";
            }
            Writeat(9, 0, status);
        }

        public void zerarperg() {
            for (int j = 16; j < 23; j++) {
                for (int i = 0; i < 40; i++) {
                    Console.SetCursorPosition(i, j);
                    Console.Write(" ");
                }
            }
            Console.SetCursorPosition(0, 16);
        }

    }
}

