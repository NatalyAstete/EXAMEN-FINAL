namespace EXAMEN_FINAL
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumHIjos = new System.Windows.Forms.TextBox();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbxCondicion = new System.Windows.Forms.ComboBox();
            this.cbxArea = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvListar = new System.Windows.Forms.ListView();
            this.columheade0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EMP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDetalles = new System.Windows.Forms.ListView();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnConsulta1 = new System.Windows.Forms.Button();
            this.btnConsulta2 = new System.Windows.Forms.Button();
            this.btnConsulta3 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE PAGO DE EMPLEADOS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNumHIjos);
            this.groupBox1.Controls.Add(this.txtEmpleado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL EMPLEADO";
            // 
            // txtNumHIjos
            // 
            this.txtNumHIjos.Location = new System.Drawing.Point(269, 44);
            this.txtNumHIjos.Name = "txtNumHIjos";
            this.txtNumHIjos.Size = new System.Drawing.Size(84, 20);
            this.txtNumHIjos.TabIndex = 4;
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(9, 44);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(232, 20);
            this.txtEmpleado.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NUM. DE HIJOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "EMPLEADO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRegistrar);
            this.groupBox2.Controls.Add(this.dtFecha);
            this.groupBox2.Controls.Add(this.cbxCondicion);
            this.groupBox2.Controls.Add(this.cbxArea);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(535, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS DE PLANILLA";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(455, 28);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 37);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dtFecha
            // 
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha.Location = new System.Drawing.Point(307, 45);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 5;
            // 
            // cbxCondicion
            // 
            this.cbxCondicion.FormattingEnabled = true;
            this.cbxCondicion.Items.AddRange(new object[] {
            "Personal",
            "Comisión"});
            this.cbxCondicion.Location = new System.Drawing.Point(165, 44);
            this.cbxCondicion.Name = "cbxCondicion";
            this.cbxCondicion.Size = new System.Drawing.Size(109, 21);
            this.cbxCondicion.TabIndex = 4;
            // 
            // cbxArea
            // 
            this.cbxArea.FormattingEnabled = true;
            this.cbxArea.Items.AddRange(new object[] {
            "Ventas",
            "Marketing",
            "Logistica",
            "Prestamo"});
            this.cbxArea.Location = new System.Drawing.Point(6, 44);
            this.cbxArea.Name = "cbxArea";
            this.cbxArea.Size = new System.Drawing.Size(111, 21);
            this.cbxArea.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "FECHA DE ING.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CONDICIÓN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "AREA";
            // 
            // lvListar
            // 
            this.lvListar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columheade0,
            this.EMP,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader11});
            this.lvListar.HideSelection = false;
            this.lvListar.Location = new System.Drawing.Point(23, 194);
            this.lvListar.Name = "lvListar";
            this.lvListar.Size = new System.Drawing.Size(1078, 241);
            this.lvListar.TabIndex = 3;
            this.lvListar.UseCompatibleStateImageBehavior = false;
            this.lvListar.View = System.Windows.Forms.View.Details;
            // 
            // columheade0
            // 
            this.columheade0.Text = "ID";
            this.columheade0.Width = 31;
            // 
            // EMP
            // 
            this.EMP.Text = "EMPLEADO";
            this.EMP.Width = 218;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "HIJOS";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "AREA";
            this.columnHeader2.Width = 93;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CONDICIÓN";
            this.columnHeader3.Width = 95;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TIEMPO DE SERV.";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "SUELDO BASE";
            this.columnHeader5.Width = 99;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "MOVILIDAD";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ASIGNACIÓN";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "DESCUENTOS";
            this.columnHeader8.Width = 83;
            // 
            // lvDetalles
            // 
            this.lvDetalles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader10});
            this.lvDetalles.HideSelection = false;
            this.lvDetalles.Location = new System.Drawing.Point(23, 460);
            this.lvDetalles.Name = "lvDetalles";
            this.lvDetalles.Size = new System.Drawing.Size(919, 162);
            this.lvDetalles.TabIndex = 4;
            this.lvDetalles.UseCompatibleStateImageBehavior = false;
            this.lvDetalles.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "CONDICIÓN";
            this.columnHeader9.Width = 808;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "VALOR";
            this.columnHeader10.Width = 104;
            // 
            // btnConsulta1
            // 
            this.btnConsulta1.Location = new System.Drawing.Point(967, 460);
            this.btnConsulta1.Name = "btnConsulta1";
            this.btnConsulta1.Size = new System.Drawing.Size(134, 36);
            this.btnConsulta1.TabIndex = 5;
            this.btnConsulta1.Text = "CONSULTA 1";
            this.btnConsulta1.UseVisualStyleBackColor = true;
            // 
            // btnConsulta2
            // 
            this.btnConsulta2.Location = new System.Drawing.Point(967, 502);
            this.btnConsulta2.Name = "btnConsulta2";
            this.btnConsulta2.Size = new System.Drawing.Size(134, 36);
            this.btnConsulta2.TabIndex = 6;
            this.btnConsulta2.Text = "CONSULTA 2";
            this.btnConsulta2.UseVisualStyleBackColor = true;
            // 
            // btnConsulta3
            // 
            this.btnConsulta3.Location = new System.Drawing.Point(967, 544);
            this.btnConsulta3.Name = "btnConsulta3";
            this.btnConsulta3.Size = new System.Drawing.Size(134, 36);
            this.btnConsulta3.TabIndex = 7;
            this.btnConsulta3.Text = "CONSULTA 3";
            this.btnConsulta3.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(967, 586);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(134, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "NETO A COBRAR";
            this.columnHeader11.Width = 105;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 645);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsulta3);
            this.Controls.Add(this.btnConsulta2);
            this.Controls.Add(this.btnConsulta1);
            this.Controls.Add(this.lvDetalles);
            this.Controls.Add(this.lvListar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumHIjos;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbxCondicion;
        private System.Windows.Forms.ComboBox cbxArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvListar;
        private System.Windows.Forms.ColumnHeader columheade0;
        private System.Windows.Forms.ColumnHeader EMP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lvDetalles;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button btnConsulta1;
        private System.Windows.Forms.Button btnConsulta2;
        private System.Windows.Forms.Button btnConsulta3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}

