using System;
using System.Collections.Generic;
using System.Text;

namespace ExCarro
{
    public class Frotas_Carros : IAutomovel
    {
        public List<IAutomovel> Automoveis { get; set; } = new List<IAutomovel>();

        public void Acelerar()
        {
            foreach (var automovel in this.Automoveis)
            {
                automovel.Acelerar();
            }
        }

        public void AcenderFarol()
        {
            foreach (var automovel in this.Automoveis)
            {
                automovel.AcenderFarol();
            }
        }

        public void ApagarFarol()
        {
            foreach (var automovel in this.Automoveis)
            {
                automovel.ApagarFarol();
            }
        }

        public void Frear()
        {
            foreach (var automovel in this.Automoveis)
            {
                automovel.Frear();
            }
        }
    }
}
