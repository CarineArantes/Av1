using System.ComponentModel;

namespace Av1_v1._0._0;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu() {

        Veiculo veiculo = new();
        bool opcaoInvalida = false;

        do {

            Console.WriteLine(" -------------------------");
            Console.WriteLine("|  Vamos Abastecer Hoje?  |");
            Console.WriteLine(" -------------------------\n");

            Console.WriteLine("1 - Calcular combustível ");
            Console.WriteLine("2 - Editar Dados     ");
            Console.WriteLine("3 - Sair         \n");

            Console.Write($"Selecione uma opção{(opcaoInvalida ? " válida" : "")}:");

            string strFormatada = Console.ReadLine()!
                .ToLower()
                .Replace("-", "")
                .Replace(" ", "");

            if ("1calcularcombustivel".Contains(strFormatada))
            {
                opcaoInvalida = false;
                CalcularCombustivel(veiculo);
            }
            else if ("2editardados".Contains(strFormatada))
            {
                opcaoInvalida = false;
                EditarDados(veiculo);
            }
            else if ("3sair".Contains(strFormatada))
            {
                opcaoInvalida = false;
                Sair();
            }else
            {
                opcaoInvalida = true;
                Console.Clear();
            }

        } while (opcaoInvalida);
    }

    static void SubMenu(Veiculo veiculo) {

        bool opcaoInvalida = false;
        do
        {
            Console.Write("0 - Voltar ao Menu   ");
            Console.Write("1 - Calcular combustível  ");
            Console.Write("2 - Editar Dados   ");
            Console.Write("3 - Sair\n\n");
            Console.Write($"Selecione uma opção{(opcaoInvalida ? " válida" : "")}:\n");

            string strFormatada = Console.ReadLine()!
                .ToLower()
                .Replace("-", "")
                .Replace(" ", "");

            Console.Clear();

            if ("0voltaraomenu".Contains(strFormatada))
            {
                Menu();
            }
            else if ("1calcularcombustivel".Contains(strFormatada))
            {
                opcaoInvalida = false;
                CalcularCombustivel(veiculo);
            }
            else if ("2editardados".Contains(strFormatada))
            {
                opcaoInvalida = false;
                EditarDados(veiculo);
            }
            else if ("3sair".Contains(strFormatada))
            {
                opcaoInvalida = false;
                Sair();
            }
            else
            {
                opcaoInvalida = true;
            }

        } while (opcaoInvalida);
    }

    static void CalcularCombustivel(Veiculo veiculo)
    {

        Console.Clear();
        veiculo.InformarDados();
        Console.Clear();
        Calculo.CustoBeneficio(veiculo);
        Console.WriteLine("------------------------------------------------\n");

        SubMenu(veiculo);
    }

    static void EditarDados(Veiculo veiculo)
    {
        veiculo.InformarConsumo();
        Console.WriteLine("------------------------------------------------\n");
        SubMenu(veiculo);
    }

    static void Sair()
    {
        Environment.Exit(0);

    }
}


