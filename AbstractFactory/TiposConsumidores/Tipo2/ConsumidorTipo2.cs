using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Tipo2
{
    internal class ConsumidorTipo2 : AConsumidor
    {
        internal ConsumidorTipo2(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
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
