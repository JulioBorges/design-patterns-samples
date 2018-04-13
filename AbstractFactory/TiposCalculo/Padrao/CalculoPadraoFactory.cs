using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.Padrao
{
    internal class CalculoPadraoFactory
    {
        internal static ATipoCalculo CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            return new CalculoPadrao(leituraAnterior, leituraAtual);
        }
    }
}
