using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExámenFinalProgramacion
{
    

        public class Laptop : Dispositivo
        {
            public int MemoriaRAM { get; set; } // en GB
            public int Almacenamiento { get; set; } // en GB

            public Laptop(string numeroDeSerie, string marca, string modelo, int memoriaRAM, int almacenamiento)
                : base(numeroDeSerie, marca, modelo)
            {
                MemoriaRAM = memoriaRAM;
                Almacenamiento = almacenamiento;
            }
        }

    }

