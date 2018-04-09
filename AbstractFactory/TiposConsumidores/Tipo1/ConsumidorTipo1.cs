using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Tipo1
{
    internal class ConsumidorTipo1 : AConsumidor
    {
        internal ConsumidorTipo1(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
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
