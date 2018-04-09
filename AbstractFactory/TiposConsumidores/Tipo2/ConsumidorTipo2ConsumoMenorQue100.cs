namespace AbstractFactory.TiposConsumidores.Tipo2
{
    internal class ConsumidorTipo2ConsumoMenorQue100 : ConsumidorTipo2
    {
        internal ConsumidorTipo2ConsumoMenorQue100(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
        {
        }

        public override decimal ValorMetroCubico()
        {
            return 0.5m;
        }
    }
}
