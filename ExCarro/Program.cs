using System;

namespace ExCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomovel automovel = new Carro();
            automovel.AcenderFarol();
            IAutomovel automovelB = new Carro();
            IAutomovel automovelC = new Carro();
            IAutomovel automovelD = new Carro();
            IAutomovel automovelE = new Carro();
            IAutomovel automovelF = new Carro();

            Frotas_Carros grupoA = new Frotas_Carros();
            grupoA.Automoveis.Add(automovel);
            grupoA.Automoveis.Add(automovelB);
            Frotas_Carros grupoB = new Frotas_Carros();
            grupoB.Automoveis.Add(automovelC);
            grupoB.Automoveis.Add(automovelD);
            Frotas_Carros grupoGrande = new Frotas_Carros();
            grupoGrande.Automoveis.Add(grupoA);
            grupoGrande.Automoveis.Add(grupoB);
            grupoGrande.Automoveis.Add(automovelE);
            grupoGrande.Automoveis.Add(automovelF);

            grupoA.AcenderFarol();
            grupoB.ApagarFarol();

            grupoGrande.Acelerar();

            AutomovelBazooka automovelBazooka = new AutomovelBazooka((Carro)automovelB);
            AutomovelMetralhadora automovelMetralhadora = new AutomovelMetralhadora((Carro)automovel);
            automovelBazooka.Atirar();
            automovelMetralhadora.Atirar();
            Console.ReadKey();
        }
    }
}
