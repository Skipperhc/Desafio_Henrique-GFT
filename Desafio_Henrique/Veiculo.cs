using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Henrique {
    class Veiculo {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public float Km { get; set; }
        public Boolean esta_ligado { get; set; }
        public int litros_gas { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public void Acelerar() {
            if (esta_ligado == true) {
                Velocidade = Velocidade + 20;
                if (litros_gas > 0) {
                    litros_gas = +1;
                }
            } else {
                Console.WriteLine("o seu veículo está desligado no momento");
            }
        }

        public void Abastecer(int quant_litros) {
            if (litros_gas < 100) {
                int verificar = litros_gas = + quant_litros;
                if (verificar > 100) {
                    litros_gas = + quant_litros;
                    Console.WriteLine("");
                } else {
                    Console.WriteLine("O tanque já está cheio");
                }
            }
        }
    }


}
