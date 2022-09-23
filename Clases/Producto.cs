using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Producto
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public double Precio { get; set; }
        public int Codigo { get; set; }
        public int Stock { get; set; }


        //private int ID_producto;
        /*
        public void set_ID(int paramCodigo)
        {
            ID_producto = paramCodigo;
        }
        public int get_ID()
        {
            return ID_producto;
        }*/

        public void mostrarDatos()
        {
            Console.WriteLine("Datos del producto " + Environment.NewLine);
        }

        public string verDatos()
        {
            return Nombre + " - " + Descripcion + " - " + Precio + " - " + Stock + " - " + Codigo;
        }
    }
}
