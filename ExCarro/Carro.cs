using System;
using System.Collections.Generic;
using System.Text;

namespace ExCarro
{
    public class Carro : IAutomovel
    {
        private static int Numero = 0;
        public string Placa { get; set; } = "AAA" + Numero++;
        public bool FarolAceso = false;
        public int velocidade = 0;


        public void Acelerar()
        {
            velocidade += 10;
            Console.WriteLine("Acelerar" + this.Placa);
        }

        public void AcenderFarol()
        {
            if (!FarolAceso) {
                FarolAceso = true;
            Console.WriteLine("AcenderFarol" + this.Placa);
            }
        }

        public void ApagarFarol()
        {
            if (FarolAceso) {
                FarolAceso = false;
            Console.WriteLine("ApagarFarol" + this.Placa);
            }
        }

        public void Frear()
        {
            velocidade -= 10;
            Console.WriteLine("Frear - Velocidade"  +
            this.velocidade.ToString() + "do Carro:" + this.Placa);
        }
    }
}
