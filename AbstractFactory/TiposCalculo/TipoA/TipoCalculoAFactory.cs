
using AbstractFactory.Contract;

namespace AbstractFactory.TiposCalculo.TipoA
{
    internal class TipoCalculoAFactory
    {
        internal static ATipoCalculo CreateConsumidor(int leituraAnterior, int leituraAtual)
        {
            return new TipoCalculoA(leituraAnterior, leituraAtual);
        }
    }
}
