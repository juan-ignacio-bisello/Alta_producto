using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Cliente
    {
        public string Nombre { get; set; }
        public string tipoCuenta { get; set; }
        public string Mail { get; set; }
        public string Direccion { get; set; }
        public int DNI { get; set; }
        public int Celular { get; set; }
        private int ID_clientes { get; set; }

        /*
        public void set_ID(int paramID)
        {
            ID_clientes = paramID;
        }*/

        public int get_ID()
        {
            return ID_clientes;
        }

        public string verDatos()
        {
            return Nombre + " - " + DNI + " - " + tipoCuenta + " - " + Mail + " - " + Celular + " - " + Direccion;
        }
    }
}
