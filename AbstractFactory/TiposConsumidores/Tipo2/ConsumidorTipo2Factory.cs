
using AbstractFactory.Contract;

namespace AbstractFactory.TiposConsumidores.Tipo2
{
    internal static class ConsumidorTipo2Factory
    {
        internal static AConsumidor CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            if ((leituraAtual - leituraAnterior) < 100)
                return new ConsumidorTipo2ConsumoMenorQue100(leituraAnterior, leituraAtual);

            return new ConsumidorTipo2(leituraAnterior, leituraAtual);
        }
    }
}
