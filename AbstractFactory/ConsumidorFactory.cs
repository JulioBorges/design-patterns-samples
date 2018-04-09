using AbstractFactory.Contract;
using AbstractFactory.TiposConsumidores.Padrao;
using AbstractFactory.TiposConsumidores.Tipo1;
using AbstractFactory.TiposConsumidores.Tipo2;

namespace AbstractFactory
{
    internal class ConsumidorFactory
    {
        internal static AConsumidor CreateConsumidor(int tipoConsumidor, int leituraAnterior, int leituraAtual)
        {
            switch(tipoConsumidor)
            {
                case 1:
                    return ConsumidorTipo1Factory.CreateConsumidor(leituraAnterior, leituraAtual);
                case 2:
                    return ConsumidorTipo2Factory.CreateConsumidor(leituraAnterior, leituraAtual);
                default:
                    return ConsumidorPadraoFactory.CreateConsumidor(leituraAnterior, leituraAtual);
            }
        }
    }
}