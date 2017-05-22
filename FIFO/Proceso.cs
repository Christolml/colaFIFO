using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Proceso
    {

        public Proceso Siguiente { get; set; }

        public int Tiempo { get; set; }


        public Proceso(int tiempo)
        {
            this.Tiempo = tiempo;
        }

    
    }
}
