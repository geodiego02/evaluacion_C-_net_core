namespace ENA_Rodrigo_Vera_3600.View
{
    partial class IngresarControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_nombreCliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_nombreMascota = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dt_fechaVacuna = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.dt_fechaAtencion = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rb_no = new System.Windows.Forms.RadioButton();
            this.rb_si = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_detalle = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_servicio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Consulta = new System.Windows.Forms.Button();
            this.btn_volver2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_nombreCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // cb_nombreCliente
            // 
            this.cb_nombreCliente.FormattingEnabled = true;
            this.cb_nombreCliente.Location = new System.Drawing.Point(59, 27);
            this.cb_nombreCliente.Name = "cb_nombreCliente";
            this.cb_nombreCliente.Size = new System.Drawing.Size(197, 21);
            this.cb_nombreCliente.TabIndex = 2;
            this.cb_nombreCliente.Text = "Seleccione Cliente";
            this.cb_nombreCliente.SelectedIndexChanged += new System.EventHandler(this.cb_nombreCliente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_nombreMascota);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox2.Location = new System.Drawing.Point(11, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 71);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Mascota";
            // 
            // cb_nombreMascota
            // 
            this.cb_nombreMascota.FormattingEnabled = true;
            this.cb_nombreMascota.Location = new System.Drawing.Point(59, 27);
            this.cb_nombreMascota.Name = "cb_nombreMascota";
            this.cb_nombreMascota.Size = new System.Drawing.Size(197, 21);
            this.cb_nombreMascota.TabIndex = 2;
            this.cb_nombreMascota.Text = "Seleccione Mascota";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dt_fechaVacuna);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tb_total);
            this.groupBox3.Controls.Add(this.dt_fechaAtencion);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.rb_no);
            this.groupBox3.Controls.Add(this.rb_si);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.rtb_detalle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cb_servicio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox3.Location = new System.Drawing.Point(11, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 245);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Mascota";
            // 
            // dt_fechaVacuna
            // 
            this.dt_fechaVacuna.CustomFormat = "";
            this.dt_fechaVacuna.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaVacuna.Location = new System.Drawing.Point(114, 179);
            this.dt_fechaVacuna.MinDate = new System.DateTime(2020, 5, 22, 0, 0, 0, 0);
            this.dt_fechaVacuna.Name = "dt_fechaVacuna";
            this.dt_fechaVacuna.Size = new System.Drawing.Size(102, 20);
            this.dt_fechaVacuna.TabIndex = 14;
            this.dt_fechaVacuna.Value = new System.DateTime(2020, 5, 22, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Fecha Vacuna:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "Si la respuesta es SI";
            // 
            // tb_total
            // 
            this.tb_total.Location = new System.Drawing.Point(114, 206);
            this.tb_total.Name = "tb_total";
            this.tb_total.Size = new System.Drawing.Size(102, 20);
            this.tb_total.TabIndex = 11;
            // 
            // dt_fechaAtencion
            // 
            this.dt_fechaAtencion.CustomFormat = "";
            this.dt_fechaAtencion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_fechaAtencion.Location = new System.Drawing.Point(114, 106);
            this.dt_fechaAtencion.MinDate = new System.DateTime(2020, 5, 22, 15, 44, 38, 0);
            this.dt_fechaAtencion.Name = "dt_fechaAtencion";
            this.dt_fechaAtencion.Size = new System.Drawing.Size(102, 20);
            this.dt_fechaAtencion.TabIndex = 10;
            this.dt_fechaAtencion.Value = new System.DateTime(2020, 5, 22, 15, 44, 38, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Total a Pagar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha Atención:";
            // 
            // rb_no
            // 
            this.rb_no.AutoSize = true;
            this.rb_no.Location = new System.Drawing.Point(187, 139);
            this.rb_no.Name = "rb_no";
            this.rb_no.Size = new System.Drawing.Size(38, 17);
            this.rb_no.TabIndex = 7;
            this.rb_no.TabStop = true;
            this.rb_no.Text = "No";
            this.rb_no.UseVisualStyleBackColor = true;
            // 
            // rb_si
            // 
            this.rb_si.AutoSize = true;
            this.rb_si.Location = new System.Drawing.Point(114, 139);
            this.rb_si.Name = "rb_si";
            this.rb_si.Size = new System.Drawing.Size(33, 17);
            this.rb_si.TabIndex = 6;
            this.rb_si.TabStop = true;
            this.rb_si.Text = "Si";
            this.rb_si.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Programa Vacunas:";
            // 
            // rtb_detalle
            // 
            this.rtb_detalle.Location = new System.Drawing.Point(114, 25);
            this.rtb_detalle.Name = "rtb_detalle";
            this.rtb_detalle.Size = new System.Drawing.Size(237, 44);
            this.rtb_detalle.TabIndex = 4;
            this.rtb_detalle.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Detalle de Revisión:";
            // 
            // cb_servicio
            // 
            this.cb_servicio.FormattingEnabled = true;
            this.cb_servicio.Location = new System.Drawing.Point(114, 75);
            this.cb_servicio.Name = "cb_servicio";
            this.cb_servicio.Size = new System.Drawing.Size(216, 21);
            this.cb_servicio.TabIndex = 2;
            this.cb_servicio.Text = "Seleccione Servicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Servicio:";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Guardar.Location = new System.Drawing.Point(478, 19);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(130, 42);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "Guardar Datos";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Consulta
            // 
            this.btn_Consulta.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_Consulta.Location = new System.Drawing.Point(478, 80);
            this.btn_Consulta.Name = "btn_Consulta";
            this.btn_Consulta.Size = new System.Drawing.Size(130, 42);
            this.btn_Consulta.TabIndex = 6;
            this.btn_Consulta.Text = "Consultar Control/Servicio";
            this.btn_Consulta.UseVisualStyleBackColor = true;
            this.btn_Consulta.Click += new System.EventHandler(this.btn_Consulta_Click);
            // 
            // btn_volver2
            // 
            this.btn_volver2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_volver2.Location = new System.Drawing.Point(489, 340);
            this.btn_volver2.Name = "btn_volver2";
            this.btn_volver2.Size = new System.Drawing.Size(119, 36);
            this.btn_volver2.TabIndex = 17;
            this.btn_volver2.Text = "Volver al Menu Principal";
            this.btn_volver2.UseVisualStyleBackColor = true;
            this.btn_volver2.Click += new System.EventHandler(this.btn_volver2_Click);
            // 
            // IngresarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 424);
            this.Controls.Add(this.btn_volver2);
            this.Controls.Add(this.btn_Consulta);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngresarControl";
            this.Text = "Toma de Horas";
            this.Load += new System.EventHandler(this.IngresarControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_nombreCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_nombreMascota;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tb_total;
        private System.Windows.Forms.DateTimePicker dt_fechaAtencion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rb_no;
        private System.Windows.Forms.RadioButton rb_si;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtb_detalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_servicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Consulta;
        private System.Windows.Forms.Button btn_volver2;
        private System.Windows.Forms.DateTimePicker dt_fechaVacuna;
        private System.Windows.Forms.Label label9;
    }
}