using AbstractFactory.Contract;
using AbstractFactory.TiposCalculo.Padrao;
using AbstractFactory.TiposCalculo.TipoA;
using AbstractFactory.TiposCalculo.TipoB;

namespace AbstractFactory
{
    internal class CalculoAguaFactory
    {
        internal static ATipoCalculo CreateConsumidor(int tipoConsumidor, int leituraAnterior, int leituraAtual)
        {
            switch(tipoConsumidor)
            {
                case 1:
                    return TipoCalculoAFactory.CreateConsumidor(leituraAnterior, leituraAtual);
                case 2:
                    return TipoCalculoBFactory.CreateConsumidor(leituraAnterior, leituraAtual);
                default:
                    return CalculoPadraoFactory.CreateConsumidor(leituraAnterior, leituraAtual);
            }
        }
    }
}