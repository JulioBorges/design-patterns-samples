namespace AbstractFactory.Contract
{
    internal abstract class ATipoCalculo
    {
        public int LeituraAnterior { get; private set; }
        public int LeituraAtual { get; private set; }

        public abstract decimal ValorMetroCubico();
        public abstract decimal PercentualEsgoto();

        protected ATipoCalculo(int leituraAnterior, int leituraAtual)
        {
            LeituraAnterior = leituraAnterior;
            LeituraAtual = leituraAtual;
        }

        protected virtual decimal ConsumoMedido()
        {
            var consumo = LeituraAtual - LeituraAnterior;
            return consumo;
        }

        protected virtual decimal ValorAgua()
        {
            var consumo = ConsumoMedido();
            
            return consumo * ValorMetroCubico();
        }

        public virtual decimal ValorEsgoto()
        {
            var valorAgua = ValorAgua();
            return ValorAgua() * PercentualEsgoto();
        }

        public virtual decimal ValorTotalFatura()
        {
            var valorAgua = ValorAgua();
            var valorEsgoto = ValorEsgoto();

            return ValorAgua() + ValorEsgoto();
        }
    }
}
