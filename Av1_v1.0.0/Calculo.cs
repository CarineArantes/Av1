using System;

namespace Av1_v1._0._0
{
	public class Calculo
	{

        public static void CustoBeneficio(Veiculo veiculo)
		{
            switch (veiculo.Combustivel)
            {
                case Veiculo.TipoCombustivel.Etanol:
                    MsgCustoBeneficio("Etanol");
                    break;
                case Veiculo.TipoCombustivel.Gasolina:
                    MsgCustoBeneficio("Gasolina");
                    break;
                case Veiculo.TipoCombustivel.Flex:
                    CalcularCustoBeneficio(veiculo);
                    break;

            }
        }

        private static void CalcularCustoBeneficio(Veiculo veiculo)
        {
            double valorRef;
            if (veiculo.ConsumoEtanol != 0
                && veiculo.ConsumoGasolina != 0) {

                double porcentagem = ((veiculo.ConsumoEtanol * 100) / veiculo.ConsumoGasolina);
                valorRef = CalcularPorcentagem(
                    (double)veiculo.ValorLitroGasolina!,
                    porcentagem
                );
            }
            else
            {
                valorRef = CalcularPorcentagem(
                    (double)veiculo.ValorLitroGasolina!,
                    70
                );
            }
            if (veiculo.ValorLitroEtanol == valorRef)
                Console.WriteLine(
                       $"Abastece de acordo com sua preferencia\n"
                 );
            else
                if (veiculo.ValorLitroEtanol < valorRef)
                    MsgCustoBeneficio("Etanol");
                else
                MsgCustoBeneficio("Gasolina");
        }

        private static double CalcularPorcentagem(double valor, double porcentagem)
        {
            return valor * porcentagem / 100;
        }

        private static void MsgCustoBeneficio(string combustivel) {
            Console.WriteLine(
                $"O melhor custo beneficio é abastecer com {combustivel}\n"
            );
        }
    }
}