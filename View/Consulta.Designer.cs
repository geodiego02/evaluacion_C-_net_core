namespace ENA_Rodrigo_Vera_3600.View
{
    partial class Consulta
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
            this.cb_ClienteConsulta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_MascotaConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_Consulta = new System.Windows.Forms.DataGridView();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_volver3 = new System.Windows.Forms.Button();
            this.btn_buscarTodos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ClienteConsulta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // cb_ClienteConsulta
            // 
            this.cb_ClienteConsulta.FormattingEnabled = true;
            this.cb_ClienteConsulta.Location = new System.Drawing.Point(59, 27);
            this.cb_ClienteConsulta.Name = "cb_ClienteConsulta";
            this.cb_ClienteConsulta.Size = new System.Drawing.Size(197, 21);
            this.cb_ClienteConsulta.TabIndex = 2;
            this.cb_ClienteConsulta.Text = "Todos";
            this.cb_ClienteConsulta.SelectedIndexChanged += new System.EventHandler(this.cb_ClienteConsulta_SelectedIndexChanged);
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
            this.groupBox2.Controls.Add(this.cb_MascotaConsulta);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(471, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 71);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Mascota";
            // 
            // cb_MascotaConsulta
            // 
            this.cb_MascotaConsulta.FormattingEnabled = true;
            this.cb_MascotaConsulta.Location = new System.Drawing.Point(59, 27);
            this.cb_MascotaConsulta.Name = "cb_MascotaConsulta";
            this.cb_MascotaConsulta.Size = new System.Drawing.Size(197, 21);
            this.cb_MascotaConsulta.TabIndex = 2;
            this.cb_MascotaConsulta.Text = "Todos";
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
            this.groupBox3.Controls.Add(this.dgv_Consulta);
            this.groupBox3.Location = new System.Drawing.Point(12, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(923, 204);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // dgv_Consulta
            // 
            this.dgv_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consulta.Location = new System.Drawing.Point(8, 22);
            this.dgv_Consulta.Name = "dgv_Consulta";
            this.dgv_Consulta.Size = new System.Drawing.Size(909, 171);
            this.dgv_Consulta.TabIndex = 0;
            this.dgv_Consulta.Visible = false;
            this.dgv_Consulta.SelectionChanged += new System.EventHandler(this.dgv_Consulta_SelectionChanged);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(300, 133);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(99, 28);
            this.btn_Buscar.TabIndex = 6;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Enabled = false;
            this.btn_Eliminar.Location = new System.Drawing.Point(415, 133);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 28);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_volver3
            // 
            this.btn_volver3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_volver3.Location = new System.Drawing.Point(810, 376);
            this.btn_volver3.Name = "btn_volver3";
            this.btn_volver3.Size = new System.Drawing.Size(119, 36);
            this.btn_volver3.TabIndex = 17;
            this.btn_volver3.Text = "Volver al Menu Principal";
            this.btn_volver3.UseVisualStyleBackColor = true;
            this.btn_volver3.Click += new System.EventHandler(this.btn_volver3_Click);
            // 
            // btn_buscarTodos
            // 
            this.btn_buscarTodos.Location = new System.Drawing.Point(532, 133);
            this.btn_buscarTodos.Name = "btn_buscarTodos";
            this.btn_buscarTodos.Size = new System.Drawing.Size(99, 28);
            this.btn_buscarTodos.TabIndex = 18;
            this.btn_buscarTodos.Text = "Buscar Todos";
            this.btn_buscarTodos.UseVisualStyleBackColor = true;
            this.btn_buscarTodos.Click += new System.EventHandler(this.btn_buscarTodos_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 421);
            this.Controls.Add(this.btn_buscarTodos);
            this.Controls.Add(this.btn_volver3);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Name = "Consulta";
            this.Text = "Consulta";
            this.Load += new System.EventHandler(this.Consulta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_ClienteConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_MascotaConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_Consulta;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_volver3;
        private System.Windows.Forms.Button btn_buscarTodos;
    }
}