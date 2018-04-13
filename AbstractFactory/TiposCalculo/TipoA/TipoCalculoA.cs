using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.TipoA
{
    internal class TipoCalculoA : ATipoCalculo
    {
        internal TipoCalculoA(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
        {
        }

        public override decimal PercentualEsgoto()
        {
            return 0.4m;
        }

        public override decimal ValorMetroCubico()
        {
            return 1.2m;
        }
    }
}
