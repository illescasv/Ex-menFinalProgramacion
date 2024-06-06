using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExámenFinalProgramacion
{
    public class Smartphone : Dispositivo
    {
        public string SistemaOperativo { get; set; }
        public int NumeroDeCamaras { get; set; }

        public Smartphone(string numeroDeSerie, string marca, string modelo, string sistemaOperativo, int numeroDeCamaras)
            : base(numeroDeSerie, marca, modelo)
        {
            SistemaOperativo = sistemaOperativo;
            NumeroDeCamaras = numeroDeCamaras;
        }
    }

}
