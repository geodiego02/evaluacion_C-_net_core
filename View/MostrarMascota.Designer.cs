namespace ENA_Rodrigo_Vera_3600.View
{
    partial class MostrarMascota
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboMascotas = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnBuscarTodo = new System.Windows.Forms.Button();
            this.btnEliminarMascota = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mascotas";
            // 
            // cboMascotas
            // 
            this.cboMascotas.FormattingEnabled = true;
            this.cboMascotas.Location = new System.Drawing.Point(183, 82);
            this.cboMascotas.Name = "cboMascotas";
            this.cboMascotas.Size = new System.Drawing.Size(150, 21);
            this.cboMascotas.TabIndex = 1;
            this.cboMascotas.Text = "Seleccionar mascotas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(372, 82);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscarTodo
            // 
            this.btnBuscarTodo.Location = new System.Drawing.Point(498, 82);
            this.btnBuscarTodo.Name = "btnBuscarTodo";
            this.btnBuscarTodo.Size = new System.Drawing.Size(87, 23);
            this.btnBuscarTodo.TabIndex = 3;
            this.btnBuscarTodo.Text = "Buscar Todo";
            this.btnBuscarTodo.UseVisualStyleBackColor = true;
            this.btnBuscarTodo.Click += new System.EventHandler(this.btnBuscarTodo_Click);
            // 
            // btnEliminarMascota
            // 
            this.btnEliminarMascota.Location = new System.Drawing.Point(619, 82);
            this.btnEliminarMascota.Name = "btnEliminarMascota";
            this.btnEliminarMascota.Size = new System.Drawing.Size(89, 23);
            this.btnEliminarMascota.TabIndex = 4;
            this.btnEliminarMascota.Text = "Eliminar";
            this.btnEliminarMascota.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dg);
            this.groupBox1.Location = new System.Drawing.Point(22, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(740, 282);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(23, 20);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(699, 256);
            this.dg.TabIndex = 0;
            // 
            // MostrarMascota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEliminarMascota);
            this.Controls.Add(this.btnBuscarTodo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cboMascotas);
            this.Controls.Add(this.label1);
            this.Name = "MostrarMascota";
            this.Text = "MostrarMascota";
            this.Load += new System.EventHandler(this.MostrarMascota_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMascotas;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnBuscarTodo;
        private System.Windows.Forms.Button btnEliminarMascota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg;
    }
}