using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExámenFinalProgramacion
{
    public abstract class Dispositivo
    {
        public string NumeroDeSerie { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        protected Dispositivo(string numeroDeSerie, string marca, string modelo)
        {
            NumeroDeSerie = numeroDeSerie;
            Marca = marca;
            Modelo = modelo;
        }
    }
}
