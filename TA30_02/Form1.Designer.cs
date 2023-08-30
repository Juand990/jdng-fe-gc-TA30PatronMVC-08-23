namespace TA30_02
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
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Apellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Direccion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bxTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bxDirector = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bxIdCliente = new System.Windows.Forms.TextBox();
            this.btnCrVideo = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrVideo = new System.Windows.Forms.Button();
            this.btnMsVideo = new System.Windows.Forms.Button();
            this.btnAcVideo = new System.Windows.Forms.Button();
            this.ltViewVideo = new System.Windows.Forms.ListView();
            this.Titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_Cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNoID = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 43);
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
            this.bxNombre.Location = new System.Drawing.Point(75, 34);
            this.bxNombre.Name = "bxNombre";
            this.bxNombre.Size = new System.Drawing.Size(100, 20);
            this.bxNombre.TabIndex = 9;
            // 
            // bxApellido
            // 
            this.bxApellido.Location = new System.Drawing.Point(231, 36);
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
            this.ID,
            this.Nombre,
            this.Apellido,
            this.Direccion,
            this.DNI,
            this.Fecha});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(11, 170);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(343, 180);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 32;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 51;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 50;
            // 
            // Direccion
            // 
            this.Direccion.Text = "Direccion";
            this.Direccion.Width = 66;
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.Width = 51;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.Width = 69;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Añadir Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Añadir Video";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Titulo";
            // 
            // bxTitulo
            // 
            this.bxTitulo.Location = new System.Drawing.Point(446, 34);
            this.bxTitulo.Name = "bxTitulo";
            this.bxTitulo.Size = new System.Drawing.Size(100, 20);
            this.bxTitulo.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Director";
            // 
            // bxDirector
            // 
            this.bxDirector.Location = new System.Drawing.Point(446, 62);
            this.bxDirector.Name = "bxDirector";
            this.bxDirector.Size = new System.Drawing.Size(100, 20);
            this.bxDirector.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(376, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "ID Cliente";
            // 
            // bxIdCliente
            // 
            this.bxIdCliente.Location = new System.Drawing.Point(446, 88);
            this.bxIdCliente.Name = "bxIdCliente";
            this.bxIdCliente.Size = new System.Drawing.Size(100, 20);
            this.bxIdCliente.TabIndex = 26;
            // 
            // btnCrVideo
            // 
            this.btnCrVideo.Location = new System.Drawing.Point(382, 141);
            this.btnCrVideo.Name = "btnCrVideo";
            this.btnCrVideo.Size = new System.Drawing.Size(75, 23);
            this.btnCrVideo.TabIndex = 27;
            this.btnCrVideo.Text = "Crear";
            this.btnCrVideo.UseVisualStyleBackColor = true;
            this.btnCrVideo.Click += new System.EventHandler(this.btnCrVideo_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(364, 11);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(12, 339);
            this.listView1.TabIndex = 28;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(379, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 29;
            // 
            // btnBrVideo
            // 
            this.btnBrVideo.Location = new System.Drawing.Point(471, 141);
            this.btnBrVideo.Name = "btnBrVideo";
            this.btnBrVideo.Size = new System.Drawing.Size(75, 23);
            this.btnBrVideo.TabIndex = 30;
            this.btnBrVideo.Text = "Borrar";
            this.btnBrVideo.UseVisualStyleBackColor = true;
            this.btnBrVideo.Click += new System.EventHandler(this.btnBrVideo_Click);
            // 
            // btnMsVideo
            // 
            this.btnMsVideo.Location = new System.Drawing.Point(552, 141);
            this.btnMsVideo.Name = "btnMsVideo";
            this.btnMsVideo.Size = new System.Drawing.Size(75, 23);
            this.btnMsVideo.TabIndex = 31;
            this.btnMsVideo.Text = "Mostrar";
            this.btnMsVideo.UseVisualStyleBackColor = true;
            this.btnMsVideo.Click += new System.EventHandler(this.btnMsVideo_Click);
            // 
            // btnAcVideo
            // 
            this.btnAcVideo.Location = new System.Drawing.Point(640, 141);
            this.btnAcVideo.Name = "btnAcVideo";
            this.btnAcVideo.Size = new System.Drawing.Size(75, 23);
            this.btnAcVideo.TabIndex = 32;
            this.btnAcVideo.Text = "Actualizar";
            this.btnAcVideo.UseVisualStyleBackColor = true;
            this.btnAcVideo.Click += new System.EventHandler(this.btnAcVideo_Click);
            // 
            // ltViewVideo
            // 
            this.ltViewVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Titulo,
            this.Director,
            this.ID_Cliente});
            this.ltViewVideo.HideSelection = false;
            this.ltViewVideo.Location = new System.Drawing.Point(382, 170);
            this.ltViewVideo.Name = "ltViewVideo";
            this.ltViewVideo.Size = new System.Drawing.Size(333, 180);
            this.ltViewVideo.TabIndex = 33;
            this.ltViewVideo.UseCompatibleStateImageBehavior = false;
            this.ltViewVideo.View = System.Windows.Forms.View.Details;
            // 
            // Titulo
            // 
            this.Titulo.Text = "Titulo";
            this.Titulo.Width = 51;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 57;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.Text = "ID_Cliente";
            this.ID_Cliente.Width = 79;
            // 
            // txtNoID
            // 
            this.txtNoID.AutoSize = true;
            this.txtNoID.Location = new System.Drawing.Point(385, 121);
            this.txtNoID.Name = "txtNoID";
            this.txtNoID.Size = new System.Drawing.Size(47, 13);
            this.txtNoID.TabIndex = 34;
            this.txtNoID.Text = "Mensaje";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(727, 364);
            this.Controls.Add(this.txtNoID);
            this.Controls.Add(this.ltViewVideo);
            this.Controls.Add(this.btnAcVideo);
            this.Controls.Add(this.btnMsVideo);
            this.Controls.Add(this.btnBrVideo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnCrVideo);
            this.Controls.Add(this.bxIdCliente);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bxDirector);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bxTitulo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox bxTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bxDirector;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bxIdCliente;
        private System.Windows.Forms.Button btnCrVideo;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBrVideo;
        private System.Windows.Forms.Button btnMsVideo;
        private System.Windows.Forms.Button btnAcVideo;
        private System.Windows.Forms.ListView ltViewVideo;
        private System.Windows.Forms.ColumnHeader Titulo;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader ID_Cliente;
        private System.Windows.Forms.Label txtNoID;
        private System.Windows.Forms.ColumnHeader ID;
    }
}

