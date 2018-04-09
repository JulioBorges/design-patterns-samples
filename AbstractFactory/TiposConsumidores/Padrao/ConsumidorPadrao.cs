using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Padrao
{
    internal class ConsumidorPadrao : AConsumidor
    {
        internal ConsumidorPadrao(int leituraAnterior, int leituraAtual) 
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
