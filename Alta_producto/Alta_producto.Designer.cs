
namespace Alta_producto
{
    partial class Alta_producto
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_agregar_producto = new System.Windows.Forms.Button();
            this.txtboxNombre = new System.Windows.Forms.TextBox();
            this.txtboxDescripcion = new System.Windows.Forms.TextBox();
            this.txtboxMarca = new System.Windows.Forms.TextBox();
            this.txtboxPrecio = new System.Windows.Forms.TextBox();
            this.txtboxStock = new System.Windows.Forms.TextBox();
            this.txtboxCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chocolate;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 414);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // Btn_agregar_producto
            // 
            this.Btn_agregar_producto.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Btn_agregar_producto.FlatAppearance.BorderSize = 0;
            this.Btn_agregar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar_producto.ForeColor = System.Drawing.Color.White;
            this.Btn_agregar_producto.Location = new System.Drawing.Point(445, 365);
            this.Btn_agregar_producto.Name = "Btn_agregar_producto";
            this.Btn_agregar_producto.Size = new System.Drawing.Size(116, 30);
            this.Btn_agregar_producto.TabIndex = 8;
            this.Btn_agregar_producto.Text = "Agregar producto";
            this.Btn_agregar_producto.UseVisualStyleBackColor = false;
            this.Btn_agregar_producto.Click += new System.EventHandler(this.Btn_agregar_producto_Click);
            // 
            // txtboxNombre
            // 
            this.txtboxNombre.BackColor = System.Drawing.Color.Black;
            this.txtboxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxNombre.ForeColor = System.Drawing.Color.White;
            this.txtboxNombre.Location = new System.Drawing.Point(239, 60);
            this.txtboxNombre.Name = "txtboxNombre";
            this.txtboxNombre.Size = new System.Drawing.Size(306, 17);
            this.txtboxNombre.TabIndex = 2;
            this.txtboxNombre.Text = "Nombre:";
            this.txtboxNombre.Enter += new System.EventHandler(this.txtboxNombre_Enter);
            this.txtboxNombre.Leave += new System.EventHandler(this.txtboxNombre_Leave);
            // 
            // txtboxDescripcion
            // 
            this.txtboxDescripcion.BackColor = System.Drawing.Color.Black;
            this.txtboxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtboxDescripcion.Location = new System.Drawing.Point(239, 110);
            this.txtboxDescripcion.Name = "txtboxDescripcion";
            this.txtboxDescripcion.Size = new System.Drawing.Size(306, 17);
            this.txtboxDescripcion.TabIndex = 3;
            this.txtboxDescripcion.Text = "Descripción:";
            this.txtboxDescripcion.Enter += new System.EventHandler(this.txtboxDescripcion_Enter);
            this.txtboxDescripcion.Leave += new System.EventHandler(this.txtboxDescripcion_Leave);
            // 
            // txtboxMarca
            // 
            this.txtboxMarca.BackColor = System.Drawing.Color.Black;
            this.txtboxMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMarca.ForeColor = System.Drawing.Color.White;
            this.txtboxMarca.Location = new System.Drawing.Point(239, 160);
            this.txtboxMarca.Name = "txtboxMarca";
            this.txtboxMarca.Size = new System.Drawing.Size(306, 17);
            this.txtboxMarca.TabIndex = 4;
            this.txtboxMarca.Text = "Marca:";
            this.txtboxMarca.Enter += new System.EventHandler(this.txtboxMarca_Enter);
            this.txtboxMarca.Leave += new System.EventHandler(this.txtboxMarca_Leave);
            // 
            // txtboxPrecio
            // 
            this.txtboxPrecio.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtboxPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrecio.ForeColor = System.Drawing.Color.White;
            this.txtboxPrecio.Location = new System.Drawing.Point(239, 210);
            this.txtboxPrecio.Name = "txtboxPrecio";
            this.txtboxPrecio.Size = new System.Drawing.Size(306, 17);
            this.txtboxPrecio.TabIndex = 5;
            this.txtboxPrecio.Text = "Precio:";
            this.txtboxPrecio.Enter += new System.EventHandler(this.txtboxPrecio_Enter);
            this.txtboxPrecio.Leave += new System.EventHandler(this.txtboxPrecio_Leave);
            // 
            // txtboxStock
            // 
            this.txtboxStock.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtboxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxStock.ForeColor = System.Drawing.Color.White;
            this.txtboxStock.Location = new System.Drawing.Point(239, 260);
            this.txtboxStock.Name = "txtboxStock";
            this.txtboxStock.Size = new System.Drawing.Size(306, 17);
            this.txtboxStock.TabIndex = 6;
            this.txtboxStock.Text = "Cantidad en stock:";
            this.txtboxStock.Enter += new System.EventHandler(this.txtboxStock_Enter);
            this.txtboxStock.Leave += new System.EventHandler(this.txtboxStock_Leave);
            // 
            // txtboxCodigo
            // 
            this.txtboxCodigo.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtboxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxCodigo.ForeColor = System.Drawing.Color.White;
            this.txtboxCodigo.Location = new System.Drawing.Point(239, 310);
            this.txtboxCodigo.Name = "txtboxCodigo";
            this.txtboxCodigo.Size = new System.Drawing.Size(306, 17);
            this.txtboxCodigo.TabIndex = 7;
            this.txtboxCodigo.Text = "Codigo de producto:";
            this.txtboxCodigo.Enter += new System.EventHandler(this.txtboxCodigo_Enter);
            this.txtboxCodigo.Leave += new System.EventHandler(this.txtboxCodigo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carga de productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(557, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 10;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(531, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Alta_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(589, 414);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxCodigo);
            this.Controls.Add(this.txtboxStock);
            this.Controls.Add(this.txtboxPrecio);
            this.Controls.Add(this.txtboxMarca);
            this.Controls.Add(this.txtboxDescripcion);
            this.Controls.Add(this.txtboxNombre);
            this.Controls.Add(this.Btn_agregar_producto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alta_producto";
            this.Opacity = 0.9D;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Alta_producto_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_agregar_producto;
        private System.Windows.Forms.TextBox txtboxNombre;
        private System.Windows.Forms.TextBox txtboxDescripcion;
        private System.Windows.Forms.TextBox txtboxMarca;
        private System.Windows.Forms.TextBox txtboxPrecio;
        private System.Windows.Forms.TextBox txtboxStock;
        private System.Windows.Forms.TextBox txtboxCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

