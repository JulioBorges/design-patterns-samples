using AbstractFactory.Contract;
using System;

namespace AbstractFactory
{
    class Program
    {
        public static void Main()
        {
            do
            {
                var tipoConsumidor = SelecionarTipoCalculo();
                var leituraAnterior = SelecionarLeituraAnterior();
                var leituraAtual = SelecionarLeituraAtual();

                ATipoCalculo calculo = CalculoAguaFactory.CreateConsumidor(tipoConsumidor, leituraAnterior, leituraAtual);

                Console.WriteLine($"\r\nValor Total da fatura: {calculo.ValorTotalFatura()}");
            }
            while (SaidaOuNovoTeste());
        }

        private static bool SaidaOuNovoTeste()
        {
            Console.WriteLine("\r\n\r\nDeseja Sair? (1: Sim)");
            Int32.TryParse(Console.ReadLine(), out int saida);
            Console.WriteLine("\r\n");
            return saida != 1;
        }

        private static int SelecionarTipoCalculo()
        {
            var tipoConsumidor = SelecaoValorInteiroNaTela("Tipo de cálculo");
            if (tipoConsumidor < 0 || tipoConsumidor > 2)
            {
                Console.WriteLine("Por favor digite um tipo de cálculo válido. 0: Padrão, 1: Tipo 1, 2: Tipo 3");
                return SelecionarTipoCalculo();
            }

            return tipoConsumidor;
        }

        private static int SelecionarLeituraAnterior()
        {
            return SelecaoValorInteiroNaTela("Leitura Anterior");
        }

        private static int SelecionarLeituraAtual()
        {
            return SelecaoValorInteiroNaTela("Leitura Atual");
        }

        private static int SelecaoValorInteiroNaTela(string informacao)
        {
            int? info = null;

            Console.WriteLine($"Informe {informacao}");

            while (info == null)
            {
                try
                {
                    info = Convert.ToInt32(Convert.ToInt32(Console.ReadLine()));
                }
                catch
                {
                    Console.WriteLine("Por favor digite um valor válido");
                }
            }

            return info.Value;
        }
    }
}
