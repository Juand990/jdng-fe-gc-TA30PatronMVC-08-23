namespace TA30_03
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
            this.label1 = new System.Windows.Forms.Label();
            this.bxDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bxNomApels = new System.Windows.Forms.TextBox();
            this.lsvCientificos = new System.Windows.Forms.ListView();
            this.ID_C = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMAPELS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrCient = new System.Windows.Forms.Button();
            this.btnBCient = new System.Windows.Forms.Button();
            this.btnMoCient = new System.Windows.Forms.Button();
            this.btnAcCient = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lsvProy = new System.Windows.Forms.ListView();
            this.ID_P = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NOMBRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HORAS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bxNomProy = new System.Windows.Forms.TextBox();
            this.bxHoras = new System.Windows.Forms.TextBox();
            this.btnCrProy = new System.Windows.Forms.Button();
            this.btnMosProy = new System.Windows.Forms.Button();
            this.btnBorProy = new System.Windows.Forms.Button();
            this.btnActProy = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.lsvAsignado = new System.Windows.Forms.ListView();
            this.ID_A = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DNICien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdProy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCrAsig = new System.Windows.Forms.Button();
            this.btnMosAsig = new System.Windows.Forms.Button();
            this.btnBorAsig = new System.Windows.Forms.Button();
            this.btnActAsig = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bxAsigCient = new System.Windows.Forms.TextBox();
            this.bxAsigProy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bxIdProy = new System.Windows.Forms.TextBox();
            this.msjProy = new System.Windows.Forms.Label();
            this.msjAsig = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI:";
            // 
            // bxDNI
            // 
            this.bxDNI.Location = new System.Drawing.Point(95, 41);
            this.bxDNI.Name = "bxDNI";
            this.bxDNI.Size = new System.Drawing.Size(100, 20);
            this.bxDNI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "NomApels:";
            // 
            // bxNomApels
            // 
            this.bxNomApels.Location = new System.Drawing.Point(95, 72);
            this.bxNomApels.Name = "bxNomApels";
            this.bxNomApels.Size = new System.Drawing.Size(100, 20);
            this.bxNomApels.TabIndex = 3;
            // 
            // lsvCientificos
            // 
            this.lsvCientificos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_C,
            this.DNI,
            this.NOMAPELS});
            this.lsvCientificos.HideSelection = false;
            this.lsvCientificos.Location = new System.Drawing.Point(12, 182);
            this.lsvCientificos.Name = "lsvCientificos";
            this.lsvCientificos.Size = new System.Drawing.Size(214, 144);
            this.lsvCientificos.TabIndex = 4;
            this.lsvCientificos.UseCompatibleStateImageBehavior = false;
            this.lsvCientificos.View = System.Windows.Forms.View.Details;
            // 
            // ID_C
            // 
            this.ID_C.Text = "ID";
            this.ID_C.Width = 34;
            // 
            // DNI
            // 
            this.DNI.Text = "DNI";
            this.DNI.Width = 76;
            // 
            // NOMAPELS
            // 
            this.NOMAPELS.Text = "NOMAPELS";
            this.NOMAPELS.Width = 82;
            // 
            // btnCrCient
            // 
            this.btnCrCient.Location = new System.Drawing.Point(19, 122);
            this.btnCrCient.Name = "btnCrCient";
            this.btnCrCient.Size = new System.Drawing.Size(75, 23);
            this.btnCrCient.TabIndex = 5;
            this.btnCrCient.Text = "Crear";
            this.btnCrCient.UseVisualStyleBackColor = true;
            this.btnCrCient.Click += new System.EventHandler(this.btnCrCient_Click);
            // 
            // btnBCient
            // 
            this.btnBCient.Location = new System.Drawing.Point(151, 122);
            this.btnBCient.Name = "btnBCient";
            this.btnBCient.Size = new System.Drawing.Size(75, 23);
            this.btnBCient.TabIndex = 6;
            this.btnBCient.Text = "Borrar";
            this.btnBCient.UseVisualStyleBackColor = true;
            this.btnBCient.Click += new System.EventHandler(this.btnBCient_Click);
            // 
            // btnMoCient
            // 
            this.btnMoCient.Location = new System.Drawing.Point(19, 151);
            this.btnMoCient.Name = "btnMoCient";
            this.btnMoCient.Size = new System.Drawing.Size(75, 23);
            this.btnMoCient.TabIndex = 7;
            this.btnMoCient.Text = "Mostrar";
            this.btnMoCient.UseVisualStyleBackColor = true;
            this.btnMoCient.Click += new System.EventHandler(this.btnMoCient_Click);
            // 
            // btnAcCient
            // 
            this.btnAcCient.Location = new System.Drawing.Point(151, 151);
            this.btnAcCient.Name = "btnAcCient";
            this.btnAcCient.Size = new System.Drawing.Size(75, 23);
            this.btnAcCient.TabIndex = 8;
            this.btnAcCient.Text = "Actualizar";
            this.btnAcCient.UseVisualStyleBackColor = true;
            this.btnAcCient.Click += new System.EventHandler(this.btnAcCient_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(10, 319);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lsvProy
            // 
            this.lsvProy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_P,
            this.NOMBRE,
            this.HORAS});
            this.lsvProy.HideSelection = false;
            this.lsvProy.Location = new System.Drawing.Point(248, 182);
            this.lsvProy.Name = "lsvProy";
            this.lsvProy.Size = new System.Drawing.Size(207, 144);
            this.lsvProy.TabIndex = 10;
            this.lsvProy.UseCompatibleStateImageBehavior = false;
            this.lsvProy.View = System.Windows.Forms.View.Details;
            // 
            // ID_P
            // 
            this.ID_P.Text = "ID";
            this.ID_P.Width = 33;
            // 
            // NOMBRE
            // 
            this.NOMBRE.Text = "NOMBRE";
            this.NOMBRE.Width = 90;
            // 
            // HORAS
            // 
            this.HORAS.Text = "HORAS";
            this.HORAS.Width = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CIENTIFICOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PROYECTOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(268, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Horas:";
            // 
            // bxNomProy
            // 
            this.bxNomProy.Location = new System.Drawing.Point(320, 60);
            this.bxNomProy.Name = "bxNomProy";
            this.bxNomProy.Size = new System.Drawing.Size(100, 20);
            this.bxNomProy.TabIndex = 15;
            // 
            // bxHoras
            // 
            this.bxHoras.Location = new System.Drawing.Point(320, 85);
            this.bxHoras.Name = "bxHoras";
            this.bxHoras.Size = new System.Drawing.Size(100, 20);
            this.bxHoras.TabIndex = 16;
            // 
            // btnCrProy
            // 
            this.btnCrProy.Location = new System.Drawing.Point(248, 125);
            this.btnCrProy.Name = "btnCrProy";
            this.btnCrProy.Size = new System.Drawing.Size(58, 22);
            this.btnCrProy.TabIndex = 17;
            this.btnCrProy.Text = "Crear";
            this.btnCrProy.UseVisualStyleBackColor = true;
            this.btnCrProy.Click += new System.EventHandler(this.btnCrProy_Click);
            // 
            // btnMosProy
            // 
            this.btnMosProy.Location = new System.Drawing.Point(318, 154);
            this.btnMosProy.Name = "btnMosProy";
            this.btnMosProy.Size = new System.Drawing.Size(58, 23);
            this.btnMosProy.TabIndex = 18;
            this.btnMosProy.Text = "Mostrar";
            this.btnMosProy.UseVisualStyleBackColor = true;
            this.btnMosProy.Click += new System.EventHandler(this.btnMosProy_Click);
            // 
            // btnBorProy
            // 
            this.btnBorProy.Location = new System.Drawing.Point(248, 155);
            this.btnBorProy.Name = "btnBorProy";
            this.btnBorProy.Size = new System.Drawing.Size(58, 22);
            this.btnBorProy.TabIndex = 19;
            this.btnBorProy.Text = "Borrar";
            this.btnBorProy.UseVisualStyleBackColor = true;
            this.btnBorProy.Click += new System.EventHandler(this.btnBorProy_Click);
            // 
            // btnActProy
            // 
            this.btnActProy.Location = new System.Drawing.Point(382, 153);
            this.btnActProy.Name = "btnActProy";
            this.btnActProy.Size = new System.Drawing.Size(73, 24);
            this.btnActProy.TabIndex = 20;
            this.btnActProy.Text = "Actualizar";
            this.btnActProy.UseVisualStyleBackColor = true;
            this.btnActProy.Click += new System.EventHandler(this.btnActProy_Click);
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(461, 6);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(10, 320);
            this.listView2.TabIndex = 21;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // lsvAsignado
            // 
            this.lsvAsignado.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_A,
            this.DNICien,
            this.IdProy});
            this.lsvAsignado.HideSelection = false;
            this.lsvAsignado.Location = new System.Drawing.Point(477, 182);
            this.lsvAsignado.Name = "lsvAsignado";
            this.lsvAsignado.Size = new System.Drawing.Size(207, 143);
            this.lsvAsignado.TabIndex = 22;
            this.lsvAsignado.UseCompatibleStateImageBehavior = false;
            this.lsvAsignado.View = System.Windows.Forms.View.Details;
            // 
            // ID_A
            // 
            this.ID_A.Text = "ID";
            this.ID_A.Width = 27;
            // 
            // DNICien
            // 
            this.DNICien.Text = "CIENTIFICO";
            this.DNICien.Width = 85;
            // 
            // IdProy
            // 
            this.IdProy.Text = "PROYECTO";
            this.IdProy.Width = 77;
            // 
            // btnCrAsig
            // 
            this.btnCrAsig.Location = new System.Drawing.Point(490, 122);
            this.btnCrAsig.Name = "btnCrAsig";
            this.btnCrAsig.Size = new System.Drawing.Size(75, 23);
            this.btnCrAsig.TabIndex = 23;
            this.btnCrAsig.Text = "Crear";
            this.btnCrAsig.UseVisualStyleBackColor = true;
            this.btnCrAsig.Click += new System.EventHandler(this.btnCrAsig_Click);
            // 
            // btnMosAsig
            // 
            this.btnMosAsig.Location = new System.Drawing.Point(490, 150);
            this.btnMosAsig.Name = "btnMosAsig";
            this.btnMosAsig.Size = new System.Drawing.Size(75, 23);
            this.btnMosAsig.TabIndex = 24;
            this.btnMosAsig.Text = "Mostrar";
            this.btnMosAsig.UseVisualStyleBackColor = true;
            this.btnMosAsig.Click += new System.EventHandler(this.btnMosAsig_Click);
            // 
            // btnBorAsig
            // 
            this.btnBorAsig.Location = new System.Drawing.Point(584, 122);
            this.btnBorAsig.Name = "btnBorAsig";
            this.btnBorAsig.Size = new System.Drawing.Size(75, 23);
            this.btnBorAsig.TabIndex = 25;
            this.btnBorAsig.Text = "Borrar";
            this.btnBorAsig.UseVisualStyleBackColor = true;
            this.btnBorAsig.Click += new System.EventHandler(this.btnBorAsig_Click);
            // 
            // btnActAsig
            // 
            this.btnActAsig.Location = new System.Drawing.Point(584, 153);
            this.btnActAsig.Name = "btnActAsig";
            this.btnActAsig.Size = new System.Drawing.Size(75, 23);
            this.btnActAsig.TabIndex = 26;
            this.btnActAsig.Text = "Actualizar";
            this.btnActAsig.UseVisualStyleBackColor = true;
            this.btnActAsig.Click += new System.EventHandler(this.btnActAsig_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "ASIGNADO A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "DNI_Cientifico:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(487, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "ID_Proyecto:";
            // 
            // bxAsigCient
            // 
            this.bxAsigCient.Location = new System.Drawing.Point(559, 41);
            this.bxAsigCient.Name = "bxAsigCient";
            this.bxAsigCient.Size = new System.Drawing.Size(100, 20);
            this.bxAsigCient.TabIndex = 30;
            // 
            // bxAsigProy
            // 
            this.bxAsigProy.Location = new System.Drawing.Point(559, 76);
            this.bxAsigProy.Name = "bxAsigProy";
            this.bxAsigProy.Size = new System.Drawing.Size(100, 20);
            this.bxAsigProy.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(285, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "ID:";
            // 
            // bxIdProy
            // 
            this.bxIdProy.Location = new System.Drawing.Point(320, 36);
            this.bxIdProy.Name = "bxIdProy";
            this.bxIdProy.Size = new System.Drawing.Size(100, 20);
            this.bxIdProy.TabIndex = 33;
            // 
            // msjProy
            // 
            this.msjProy.AutoSize = true;
            this.msjProy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msjProy.Location = new System.Drawing.Point(312, 127);
            this.msjProy.Name = "msjProy";
            this.msjProy.Size = new System.Drawing.Size(0, 13);
            this.msjProy.TabIndex = 34;
            // 
            // msjAsig
            // 
            this.msjAsig.AutoSize = true;
            this.msjAsig.Location = new System.Drawing.Point(478, 103);
            this.msjAsig.Name = "msjAsig";
            this.msjAsig.Size = new System.Drawing.Size(0, 13);
            this.msjAsig.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 338);
            this.Controls.Add(this.msjAsig);
            this.Controls.Add(this.msjProy);
            this.Controls.Add(this.bxIdProy);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bxAsigProy);
            this.Controls.Add(this.bxAsigCient);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnActAsig);
            this.Controls.Add(this.btnBorAsig);
            this.Controls.Add(this.btnMosAsig);
            this.Controls.Add(this.btnCrAsig);
            this.Controls.Add(this.lsvAsignado);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.btnActProy);
            this.Controls.Add(this.btnBorProy);
            this.Controls.Add(this.btnMosProy);
            this.Controls.Add(this.btnCrProy);
            this.Controls.Add(this.bxHoras);
            this.Controls.Add(this.bxNomProy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsvProy);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAcCient);
            this.Controls.Add(this.btnMoCient);
            this.Controls.Add(this.btnBCient);
            this.Controls.Add(this.btnCrCient);
            this.Controls.Add(this.lsvCientificos);
            this.Controls.Add(this.bxNomApels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bxDNI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bxDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bxNomApels;
        private System.Windows.Forms.ListView lsvCientificos;
        private System.Windows.Forms.Button btnCrCient;
        private System.Windows.Forms.Button btnBCient;
        private System.Windows.Forms.Button btnMoCient;
        private System.Windows.Forms.Button btnAcCient;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lsvProy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bxNomProy;
        private System.Windows.Forms.TextBox bxHoras;
        private System.Windows.Forms.Button btnCrProy;
        private System.Windows.Forms.Button btnMosProy;
        private System.Windows.Forms.Button btnBorProy;
        private System.Windows.Forms.Button btnActProy;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView lsvAsignado;
        private System.Windows.Forms.Button btnCrAsig;
        private System.Windows.Forms.Button btnMosAsig;
        private System.Windows.Forms.Button btnBorAsig;
        private System.Windows.Forms.Button btnActAsig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox bxAsigCient;
        private System.Windows.Forms.TextBox bxAsigProy;
        private System.Windows.Forms.ColumnHeader ID_C;
        private System.Windows.Forms.ColumnHeader DNI;
        private System.Windows.Forms.ColumnHeader NOMAPELS;
        private System.Windows.Forms.ColumnHeader ID_P;
        private System.Windows.Forms.ColumnHeader NOMBRE;
        private System.Windows.Forms.ColumnHeader HORAS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bxIdProy;
        private System.Windows.Forms.ColumnHeader ID_A;
        private System.Windows.Forms.ColumnHeader DNICien;
        private System.Windows.Forms.ColumnHeader IdProy;
        private System.Windows.Forms.Label msjProy;
        private System.Windows.Forms.Label msjAsig;
    }
}

