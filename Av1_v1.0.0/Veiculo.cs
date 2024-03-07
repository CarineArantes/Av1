using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Av1_v1._0._0
{
	public class Veiculo
    {

        public enum TipoCombustivel
        {
            Gasolina,
            Etanol,
            Flex
        }
        public TipoCombustivel Combustivel { get; private set; }
        public double? ValorLitroEtanol { get; private set; }
        public double? ValorLitroGasolina { get; private set; }
        public double ConsumoEtanol { get; private set; }
        public double ConsumoGasolina { get; private set; }
    
        public Veiculo() {
            ConsumoGasolina = 0;
            ConsumoEtanol = 0;

        }

        public void InformarDados()
        {

            bool opcaoInvalida = false;
            do
            {
                Console.WriteLine("1 - Apenas etanol");
                Console.WriteLine("2 - Apenas gasolina");
                Console.WriteLine("3 - Etanol ou gasolina (Flex)\n");

                Console.Write($"Selecione uma tipo{(opcaoInvalida ? " válida" : "")}:");

                string strFormatada = Console.ReadLine()!
                    .ToLower()
                    .Replace("-", "")
                    .Replace(" ", "");

                if ("1apenasetanol".Contains(strFormatada))
                {
                    opcaoInvalida = false;
                    Combustivel = TipoCombustivel.Etanol;
                }
                else if ("2apenasgasolina".Contains(strFormatada))
                {
                    opcaoInvalida = false;
                    Combustivel = TipoCombustivel.Gasolina;
                }
                else if ("3etanolougasolina(flex)".Contains(strFormatada))
                {
                    opcaoInvalida = false;
                    Combustivel = TipoCombustivel.Flex;
                }
                else
                {
                    opcaoInvalida = true;
                    Console.Clear();
                }

            } while (opcaoInvalida);


            if (Combustivel == TipoCombustivel.Flex)
            {

                do
                {
                    Console.Clear();
                    Console.Write($"Informe " +
                        $"{(opcaoInvalida
                        ? "um valor valido para o"
                        : "o valor do"
                        )} litro do etanol:");


                    string str = Console.ReadLine()!.Replace(",", ".");

                    if (Regex.IsMatch(str, @"^\d+(\.\d{1,3})?$"))
                    {
                        ValorLitroEtanol = double.Parse(str);
                        opcaoInvalida = false;
                    }
                    else
                    {
                        opcaoInvalida = true;
                    }
                } while (opcaoInvalida);

                do
                {
                    Console.Clear();
                    Console.Write($"Informe " +
                        $"{(opcaoInvalida
                        ? "um valor valido para o"
                        : "o valor do"
                        )} litro do gasolina:");

                    string str = Console.ReadLine()!.Replace(",", ".");

                    if (Regex.IsMatch(str, @"^\d+(\.\d{1,3})?$"))
                    {
                        ValorLitroGasolina = double.Parse(str);
                        opcaoInvalida = false;
                    }
                    else
                    {
                        opcaoInvalida = true;
                    }
                } while (opcaoInvalida);

            }
        }

        public void InformarConsumo()
        {
            bool opcaoInvalida = false;

            do
            {
                Console.Clear();
                Console.Write($"Informe" +
                    $"{(opcaoInvalida
                    ? "um valor valido para o"
                    : "o"
                    )} consumo do veiculo (Km/L) com Etanol:");


                string str = Console.ReadLine()!.Replace(",", ".");
                if (Regex.IsMatch(str, @"^\d+(\.\d{1,2})?$") && str != "0")
                {
                    if (double.Parse(str) > 0)
                    {
                        ConsumoEtanol = double.Parse(str);
                        opcaoInvalida = false;
                    }
                    else {
                        opcaoInvalida = true;
                    }
                }
                else
                {
                    opcaoInvalida = true;
                }
            } while (opcaoInvalida);

            do
            {
                Console.Clear();
                Console.Write($"Informe" +
                    $"{(opcaoInvalida
                    ? "um valor valido para o"
                    : "o"
                    )} consumo do veiculo (Km/L) com Gasolina:");


                string str = Console.ReadLine()!.Replace(",", ".");
                if (Regex.IsMatch(str, @"^\d+(\.\d{1,2})?$") && str != "0")
                {
                    if (double.Parse(str) > 0)
                    {
                        ConsumoGasolina = double.Parse(str);
                        opcaoInvalida = false;
                    }
                    else {
                        opcaoInvalida = true;
                    }
                }
                else
                {
                    opcaoInvalida = true;
                }
            } while (opcaoInvalida);

        }

    }
}

