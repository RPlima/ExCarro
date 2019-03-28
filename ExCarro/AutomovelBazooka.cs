using System;
using System.Collections.Generic;
using System.Text;

namespace ExCarro
{
    class AutomovelBazooka : IAutomovelDeCombate
    {
        private Carro automovel;

        public AutomovelBazooka(Carro automovel)
        {
            this.automovel = automovel;
        }
        public void Acelerar()
        {
            this.Acelerar();
        }

        public void AcenderFarol()
        {
            this.AcenderFarol();
        }

        public void ApagarFarol()
        {
            this.ApagarFarol();
        }

        public void Atirar()
        {
            Console.WriteLine("o carro:" + this.automovel.Placa+ " BOOOOOOOOOOOOOM");
        }

        public void Frear()
        {
            this.Frear();
        }
    }
}
