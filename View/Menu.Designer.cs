namespace ENA_Rodrigo_Vera_3600
{
    partial class fr_Menu
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

        public void HabilitarBotones(bool x)
        {
            if (x == true)
            {
                btnRegistrar.Enabled = true;
                btnEliminarUsuario.Enabled = true;
                this.Text = "Menú - Administrador";
            }
            else
            {
                this.Text = "Menú - Colaborador";
            }
            btn_IngrClienMasc.Enabled = true;
            btn_IngrControlServ.Enabled = true;
            btn_ConsControlServ.Enabled = true;
            btnMostrarClientes.Enabled = true;
            btnMostrarMascotas.Enabled = true;
        }


        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_IngrClienMasc = new System.Windows.Forms.Button();
            this.btn_IngrControlServ = new System.Windows.Forms.Button();
            this.btn_ConsControlServ = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMostrarClientes = new System.Windows.Forms.Button();
            this.btnMostrarMascotas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_IngrClienMasc
            // 
            this.btn_IngrClienMasc.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_IngrClienMasc.Location = new System.Drawing.Point(259, 12);
            this.btn_IngrClienMasc.Name = "btn_IngrClienMasc";
            this.btn_IngrClienMasc.Size = new System.Drawing.Size(127, 35);
            this.btn_IngrClienMasc.TabIndex = 0;
            this.btn_IngrClienMasc.Text = "Ingresar Cliente y Mascotas";
            this.btn_IngrClienMasc.UseVisualStyleBackColor = true;
            this.btn_IngrClienMasc.Click += new System.EventHandler(this.btn_IngrClienMasc_Click);
            // 
            // btn_IngrControlServ
            // 
            this.btn_IngrControlServ.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_IngrControlServ.Location = new System.Drawing.Point(259, 120);
            this.btn_IngrControlServ.Name = "btn_IngrControlServ";
            this.btn_IngrControlServ.Size = new System.Drawing.Size(127, 35);
            this.btn_IngrControlServ.TabIndex = 1;
            this.btn_IngrControlServ.Text = "Ingresar Control/Servicio";
            this.btn_IngrControlServ.UseVisualStyleBackColor = true;
            this.btn_IngrControlServ.Click += new System.EventHandler(this.btn_IngrControlServ_Click);
            // 
            // btn_ConsControlServ
            // 
            this.btn_ConsControlServ.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_ConsControlServ.Location = new System.Drawing.Point(259, 163);
            this.btn_ConsControlServ.Name = "btn_ConsControlServ";
            this.btn_ConsControlServ.Size = new System.Drawing.Size(127, 35);
            this.btn_ConsControlServ.TabIndex = 2;
            this.btn_ConsControlServ.Text = "Consulta Control/Servicio";
            this.btn_ConsControlServ.UseVisualStyleBackColor = true;
            this.btn_ConsControlServ.Click += new System.EventHandler(this.btn_ConsControlServ_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Tahoma", 8F);
            this.btn_salir.Location = new System.Drawing.Point(259, 205);
            this.btn_salir.MaximumSize = new System.Drawing.Size(127, 35);
            this.btn_salir.MinimumSize = new System.Drawing.Size(127, 35);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(127, 35);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir de la Aplicación";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(41, 151);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(41, 193);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 6;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnInicio);
            this.groupBox1.Controls.Add(this.btnEliminarUsuario);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 222);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Administrar Usuarios";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(93, 66);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 20);
            this.txtClave.TabIndex = 11;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(93, 34);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuario:";
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(41, 110);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 31);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Iniciar Sesión";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMostrarClientes
            // 
            this.btnMostrarClientes.Location = new System.Drawing.Point(259, 54);
            this.btnMostrarClientes.Name = "btnMostrarClientes";
            this.btnMostrarClientes.Size = new System.Drawing.Size(127, 23);
            this.btnMostrarClientes.TabIndex = 8;
            this.btnMostrarClientes.Text = "Mostrar Clientes";
            this.btnMostrarClientes.UseVisualStyleBackColor = true;
            this.btnMostrarClientes.Click += new System.EventHandler(this.btnMostrarClientes_Click);
            // 
            // btnMostrarMascotas
            // 
            this.btnMostrarMascotas.Location = new System.Drawing.Point(259, 84);
            this.btnMostrarMascotas.Name = "btnMostrarMascotas";
            this.btnMostrarMascotas.Size = new System.Drawing.Size(127, 23);
            this.btnMostrarMascotas.TabIndex = 9;
            this.btnMostrarMascotas.Text = "Mostrar Mascotas";
            this.btnMostrarMascotas.UseVisualStyleBackColor = true;
            // 
            // fr_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 246);
            this.Controls.Add(this.btnMostrarMascotas);
            this.Controls.Add(this.btnMostrarClientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ConsControlServ);
            this.Controls.Add(this.btn_IngrControlServ);
            this.Controls.Add(this.btn_IngrClienMasc);
            this.MaximumSize = new System.Drawing.Size(414, 285);
            this.MinimumSize = new System.Drawing.Size(414, 285);
            this.Name = "fr_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.fr_Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_IngrClienMasc;
        private System.Windows.Forms.Button btn_IngrControlServ;
        private System.Windows.Forms.Button btn_ConsControlServ;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMostrarClientes;
        private System.Windows.Forms.Button btnMostrarMascotas;
    }
}

