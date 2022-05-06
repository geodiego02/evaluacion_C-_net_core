using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENA_Rodrigo_Vera_3600.Modell;
using ENA_Rodrigo_Vera_3600.View;
using ENA_Rodrigo_Vera_3600.View.Ingresar_Cliente;

namespace ENA_Rodrigo_Vera_3600
{
    public partial class fr_Menu : Form
    {
        bool x = false;
        public fr_Menu()
        {
            InitializeComponent();
        }

        private void btn_IngrClienMasc_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fic = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarCliente);
            Form fic2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarControl);
            Form fic3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta);
            
            if(fic2 != null)
            {
                fic2.Close();
            }
            
            if(fic3 != null)
            {
                fic3.Close();
            }

            if (fic != null)
            {
                //si la instancia existe la pongo en primer plano
                fic.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            fic = new IngresarCliente();
            fic.Show();
        }

        private void btn_IngrControlServ_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fic = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarControl);
            Form fic2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarCliente);
            Form fic3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta);

            if (fic2 != null)
            {
                fic2.Close();
            }

            if (fic3 != null)
            {
                fic3.Close();
            }

            if (fic != null)
            {
                //si la instancia existe la pongo en primer plano
                fic.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            fic = new IngresarControl();
            fic.Show();
        }

        private void btn_ConsControlServ_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fic = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta);
            Form fic2 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarControl);
            Form fic3 = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is IngresarCliente);

            if (fic2 != null)
            {
                fic2.Close();
            }

            if (fic3 != null)
            {
                fic3.Close();
            }

            if (fic != null)
            {
                //si la instancia existe la pongo en primer plano
                fic.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva
            fic = new Consulta();
            fic.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void fr_Menu_Load(object sender, EventArgs e)
        {
            btn_IngrClienMasc.Enabled=false;
            btn_IngrControlServ.Enabled = false;
            btn_ConsControlServ.Enabled = false;
            btnRegistrar.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            btnMostrarClientes.Enabled = false;
            btnMostrarMascotas.Enabled = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
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
                            x = true;
                            HabilitarBotones(x);
                        }
                        HabilitarBotones(x);
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtUsuario.Visible = false;
                        txtClave.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        btnInicio.Visible = false;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarUsuario ru = new RegistrarUsuario();
            ru.Show();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario eu = new EliminarUsuario();

            eu.Show();
        }

        private void btnMostrarClientes_Click(object sender, EventArgs e)
        {
            MostrarCliente mos = new MostrarCliente();
            mos.Show();
        }
    }
}
