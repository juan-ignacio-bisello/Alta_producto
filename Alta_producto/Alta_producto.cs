using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Runtime.InteropServices;   //to free move the form in the screen

namespace Alta_producto
{
    public partial class Alta_producto : Form
    {
        public Alta_producto()
        {
            InitializeComponent();
        }

        //to free move the form in the screen
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lParam);

        private void Btn_agregar_producto_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Nombre = txtboxNombre.Text;
            p.Descripcion = txtboxDescripcion.Text;
            p.Marca = txtboxMarca.Text;
            p.Precio = Convert.ToDouble(txtboxPrecio.Text);
            p.Stock = Convert.ToInt32(txtboxStock.Text);
            p.Codigo = Convert.ToInt32(txtboxCodigo.Text);

            // label6.Text = p.Nombre + " - " + p.Descripcion + " - " + p.Precio + " - " + p.Stock;
            label2.Text = p.verDatos();
        }

        private void txtboxNombre_Enter(object sender, EventArgs e)
        {
            if (txtboxNombre.Text == "Nombre:")     //to clean the default text of the form
            {
                txtboxNombre.Text = "";
                txtboxNombre.ForeColor = Color.White;
            }
        }

        private void txtboxNombre_Leave(object sender, EventArgs e)
        {
            if (txtboxNombre.Text == "")        //to put the default text of the form if it is empty
            {
                txtboxNombre.Text = "Nombre:";
                txtboxNombre.ForeColor = Color.White;
            }
        }

        private void txtboxDescripcion_Enter(object sender, EventArgs e)
        {
            if (txtboxDescripcion.Text == "Descripción:")
            {
                txtboxDescripcion.Text = "";
                txtboxDescripcion.ForeColor = Color.White;
            }

        }

        private void txtboxDescripcion_Leave(object sender, EventArgs e)
        {
            if (txtboxDescripcion.Text == "")
            {
                txtboxDescripcion.Text = "Descripción:";
                txtboxDescripcion.ForeColor = Color.White;
            }
        }

        private void txtboxMarca_Enter(object sender, EventArgs e)
        {
            if (txtboxMarca.Text == "Marca:")
            {
                txtboxMarca.Text = "";
                txtboxMarca.ForeColor = Color.White;
            }
        }

        private void txtboxMarca_Leave(object sender, EventArgs e)
        {
            if (txtboxMarca.Text == "")
            {
                txtboxMarca.Text = "Marca:";
                txtboxMarca.ForeColor = Color.White;
            }
        }

        private void txtboxPrecio_Enter(object sender, EventArgs e)
        {
            if (txtboxPrecio.Text == "Precio:")
            {
                txtboxPrecio.Text = "";
                txtboxPrecio.ForeColor = Color.White;
            }
        }

        private void txtboxPrecio_Leave(object sender, EventArgs e)
        {
            if (txtboxPrecio.Text == "")
            {
                txtboxPrecio.Text = "Precio:";
                txtboxPrecio.ForeColor = Color.White;
            }
        }

        private void txtboxStock_Enter(object sender, EventArgs e)
        {
            if (txtboxStock.Text == "Cantidad en stock:")
            {
                txtboxStock.Text = "";
                txtboxStock.ForeColor = Color.White;
            }
        }

        private void txtboxStock_Leave(object sender, EventArgs e)
        {
            if (txtboxStock.Text == "")
            {
                txtboxStock.Text = "Cantidad en stock:";
                txtboxStock.ForeColor = Color.White;
            }
        }

        private void txtboxCodigo_Enter(object sender, EventArgs e)
        {
            if (txtboxCodigo.Text == "Codigo de producto:")
            {
                txtboxCodigo.Text = "";
                txtboxCodigo.ForeColor = Color.White;
            }
        }

        private void txtboxCodigo_Leave(object sender, EventArgs e)
        {
            if (txtboxCodigo.Text == "")
            {
                txtboxCodigo.Text = "Codigo de producto:";
                txtboxCodigo.ForeColor = Color.White;
            }
        }

        private void Alta_producto_MouseDown(object sender, MouseEventArgs e)
        {
            //to free move the form in the screen
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //to minimize the form
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
