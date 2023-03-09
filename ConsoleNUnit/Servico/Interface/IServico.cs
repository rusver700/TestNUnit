using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNUnit.Servico.Interface
{
    public interface IServico
    {
        public double Somar();
        public double Subtarir();
        public double Multiplicar();
        public double Dividir();
        public double Media();
    }
}
