using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Ciclos
    {
        private Proceso Primero;
        //private Proceso Ultimo;

        public Ciclos()
        {
            Primero = null;
            //Ultimo = null;
        }


        public void agregarProceso(Proceso nuevo)
        {
  
            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
            }
            else
                agregarProceso(Primero, nuevo);
    
        }


        private void agregarProceso(Proceso ultimo, Proceso nuevo)
        {
            if (ultimo.Siguiente == null)
                ultimo.Siguiente = nuevo;
            else
                agregarProceso(ultimo.Siguiente, nuevo);

        }



        public void sacar()
        {
            Primero = Primero.Siguiente;
        }

        public Proceso verActual()
        {
            return Primero;
        }


    }
}
