namespace TA30_01
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bxNombre = new System.Windows.Forms.TextBox();
            this.bxApellido = new System.Windows.Forms.TextBox();
            this.bxDireccion = new System.Windows.Forms.TextBox();
            this.bxDni = new System.Windows.Forms.TextBox();
            this.bxFecha = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.crearCliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DNI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha";
            // 
            // bxNombre
            // 
            this.bxNombre.Location = new System.Drawing.Point(75, 12);
            this.bxNombre.Name = "bxNombre";
            this.bxNombre.Size = new System.Drawing.Size(100, 20);
            this.bxNombre.TabIndex = 9;
            // 
            // bxApellido
            // 
            this.bxApellido.Location = new System.Drawing.Point(75, 36);
            this.bxApellido.Name = "bxApellido";
            this.bxApellido.Size = new System.Drawing.Size(100, 20);
            this.bxApellido.TabIndex = 10;
            // 
            // bxDireccion
            // 
            this.bxDireccion.Location = new System.Drawing.Point(75, 60);
            this.bxDireccion.Name = "bxDireccion";
            this.bxDireccion.Size = new System.Drawing.Size(100, 20);
            this.bxDireccion.TabIndex = 11;
            // 
            // bxDni
            // 
            this.bxDni.Location = new System.Drawing.Point(75, 82);
            this.bxDni.Name = "bxDni";
            this.bxDni.Size = new System.Drawing.Size(100, 20);
            this.bxDni.TabIndex = 12;
            // 
            // bxFecha
            // 
            this.bxFecha.Location = new System.Drawing.Point(75, 105);
            this.bxFecha.Name = "bxFecha";
            this.bxFecha.Size = new System.Drawing.Size(100, 20);
            this.bxFecha.TabIndex = 13;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(100, 141);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(281, 140);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.DNI,
            this.Fecha});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(13, 170);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(343, 180);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(191, 141);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 18;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(368, 362);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.bxFecha);
            this.Controls.Add(this.bxDni);
            this.Controls.Add(this.bxDireccion);
            this.Controls.Add(this.bxApellido);
            this.Controls.Add(this.bxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bxNombre;
        private System.Windows.Forms.TextBox bxApellido;
        private System.Windows.Forms.TextBox bxDireccion;
        private System.Windows.Forms.TextBox bxDni;
        private System.Windows.Forms.TextBox bxFecha;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader Apellido;
        private System.Windows.Forms.ColumnHeader Direccion;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.Button btnMostrar;
    }
}

