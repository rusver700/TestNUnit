using ConsoleNUnit.Modelo;
using ConsoleNUnit.Servico;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    [ExcludeFromCodeCoverage]
    private static void Main(string[] args)
    {
        ValorEntrada valorEntrada = new ValorEntrada();
        Servico servico = new Servico(valorEntrada);
        OpcoesSwitch opcoesSwitch = new OpcoesSwitch(servico);

        Console.WriteLine("Escolha uma Opção: \n1= Subtrair \n2=Soma \n3=Multiplicar \n4=Dividir \n5=Média \n6=Sair \n");
        var valor = Console.ReadLine();

        if (valor == "1" || valor == "2" || valor == "3" || valor == "4" || valor == "5")
        {
            Console.WriteLine("Digite o primeiro número");
            double num1 = int.Parse(Console.ReadLine());
            valorEntrada.Numero1 = num1;

            Console.WriteLine("Digite o segundo número");
            valorEntrada.Numero2 = int.Parse(Console.ReadLine());
        }

        opcoesSwitch.Opcao(valor);
    }
}