using System;
using System.Collections.Generic;
using System.Text;

namespace ExCarro
{
    class AutomovelMetralhadora : IAutomovelDeCombate
    {
        private Carro automovel;
        public AutomovelMetralhadora(Carro automovel)
        {
            this.automovel = automovel;
        }
        public void Acelerar()
        {
            this.automovel.Acelerar();
        }

        public void AcenderFarol()
        {
            this.automovel.AcenderFarol();
        }

        public void ApagarFarol()
        {
            this.automovel.ApagarFarol();
        }

        public void Atirar()
        {
            Console.WriteLine("o carro:" + this.automovel.Placa +  " RATATATATATA");
        }

        public void Frear()
        {
            this.automovel.Frear();
        }
    }
}
