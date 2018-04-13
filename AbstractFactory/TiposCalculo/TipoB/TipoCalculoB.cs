using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.TipoB
{
    internal class TipoCalculoB : ATipoCalculo
    {
        internal TipoCalculoB(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
        {
        }

        public override decimal PercentualEsgoto()
        {
            return 0;
        }

        public override decimal ValorMetroCubico()
        {
            return 1m;
        }
    }
}
