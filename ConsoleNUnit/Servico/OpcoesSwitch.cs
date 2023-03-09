using ConsoleNUnit.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNUnit.Servico
{
    public class OpcoesSwitch
    {
        private readonly IServico _servico;
        public OpcoesSwitch(IServico servico) 
        {
            _servico = servico;
        }

        double result;
        public string Opcao(string opcao)
        {
            switch(opcao)
            {
                case "1":
                    result = _servico.Subtarir();
                    break;
                case "2":
                    result = _servico.Somar();
                    break; 
                case "3":
                    result = _servico.Multiplicar();
                    break;
                case "4":
                    result = _servico.Dividir();
                    break;
                case "5":
                    result = _servico.Media();
                    break;
                case "6":
                    Console.WriteLine("Pressione Enter pra sair...");
                    break;
                default:
                    throw new Exception("Erro: Valor Invalido.");
            }
            if (opcao != "6")
                Console.WriteLine($"Resultado é {result}");

            return result.ToString();//retorno é uma string
        }
    }
}
