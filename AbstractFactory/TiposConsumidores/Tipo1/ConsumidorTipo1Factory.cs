
using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Tipo1
{
    internal static class ConsumidorTipo1Factory
    {
        internal static AConsumidor CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            return new ConsumidorTipo1(leituraAnterior, leituraAtual);
        }
    }
}
