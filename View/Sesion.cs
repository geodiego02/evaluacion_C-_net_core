using ENA_Rodrigo_Vera_3600.Modell;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENA_Rodrigo_Vera_3600.View
{
    public partial class Sesion : Form
    {
        public Sesion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConexionDbContext db = new ConexionDbContext())
            {
                Usuario usu = new Usuario();
                string usuario = txtUsuario.Text;
                string contraseña = txtClave.Text;

                try
                {
                    var us = db.Usuario.Single(x => x.NombreUsuario == usuario);
                    if (us.Contraseña == contraseña)
                    {
                        
                        
                        if (us.Cargo == "Administrador")
                        {
                            bool x = true;
                        }
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("La contraseña ingresada no es válida. Intente nuevamente");
                        txtClave.Text = string.Empty;
                        txtClave.Focus();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("El usuario no se encuentra registrado");

                    try
                    {
                        txtClave.Text = "";
                        var us = db.Usuario.Single();
                    }
                    catch (Exception)
                    {
                        RegistrarUsuario ru = new RegistrarUsuario();
                        ru.Show();
                    }
                }
            }

        }

        private void Sesion_Load(object sender, EventArgs e)
        {

        }
    }
}
