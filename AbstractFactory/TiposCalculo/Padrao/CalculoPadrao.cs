using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.Padrao
{
    internal class CalculoPadrao : ATipoCalculo
    {
        internal CalculoPadrao(int leituraAnterior, int leituraAtual) 
            : base(leituraAnterior, leituraAtual)
        {
        }

        public override decimal PercentualEsgoto()
        {
            return 0.5m;
        }

        public override decimal ValorMetroCubico()
        {
            return 1m;
        }
    }
}
