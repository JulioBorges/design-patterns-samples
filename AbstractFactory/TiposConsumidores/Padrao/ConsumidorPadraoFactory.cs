using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Padrao
{
    internal static class ConsumidorPadraoFactory
    {
        internal static AConsumidor CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            return new ConsumidorPadrao(leituraAnterior, leituraAtual);
        }
    }
}
