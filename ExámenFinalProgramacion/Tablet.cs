using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExámenFinalProgramacion
{
    public class Tablet : Dispositivo
    {
        public float TamanoDePantalla { get; set; } // en pulgadas
        public bool SoporteParaStylus { get; set; }

        public Tablet(string numeroDeSerie, string marca, string modelo, float tamanoDePantalla, bool soporteParaStylus)
            : base(numeroDeSerie, marca, modelo)
        {
            TamanoDePantalla = tamanoDePantalla;
            SoporteParaStylus = soporteParaStylus;
        }
    }

}
