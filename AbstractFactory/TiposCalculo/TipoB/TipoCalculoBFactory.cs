using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.TipoB
{
    internal class TipoCalculoBFactory
    {
        internal static ATipoCalculo CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            if ((leituraAtual - leituraAnterior) < 100)
                return new TipoCalculoBConsumoMenorQue100(leituraAnterior, leituraAtual);

            return new TipoCalculoB(leituraAnterior, leituraAtual);
        }
    }
}
