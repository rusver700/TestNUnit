using ConsoleNUnit.Modelo;
using ConsoleNUnit.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNUnit.Servico
{
    public class Servico : IServico
    {
        private readonly ValorEntrada _valorEntrada;
        public Servico(ValorEntrada valorEntrada) 
        {
            _valorEntrada= valorEntrada;
        }

        public double Dividir()
        {
            return _valorEntrada.Numero1 / _valorEntrada.Numero2;
        }

        public double Media()
        {
            return (_valorEntrada.Numero1 + _valorEntrada.Numero2) / 2;
        }

        public double Multiplicar()
        {
            return _valorEntrada.Numero1 * _valorEntrada.Numero2;
        }

        public double Somar()
        {
            return _valorEntrada.Numero1 + _valorEntrada.Numero2;
        }

        public double Subtarir()
        {
            return _valorEntrada.Numero1 - _valorEntrada.Numero2;
        }
    }
}
