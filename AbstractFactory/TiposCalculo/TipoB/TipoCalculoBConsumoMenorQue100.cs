namespace AbstractFactory.TiposCalculo.TipoB
{
    internal class TipoCalculoBConsumoMenorQue100 : TipoCalculoB
    {
        internal TipoCalculoBConsumoMenorQue100(int leituraAnterior, int leituraAtual) : base(leituraAnterior, leituraAtual)
        {
        }

        public override decimal ValorMetroCubico()
        {
            return 0.5m;
        }
    }
}
