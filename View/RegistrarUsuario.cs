using ENA_Rodrigo_Vera_3600.Controller;
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
    
    public partial class RegistrarUsuario : Form
    {
        bool bandera = false;
        ValidacionYFormato val = new ValidacionYFormato();
        public RegistrarUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int c = cmbCargo.SelectedIndex;
            string cargo = string.Empty;
            string usuario = txtUsuario.Text;
            string contraseña = txtClave.Text;
            if (val.vTexto(nombre) == false)
            {
                MessageBox.Show("Debe ingresar su nombre para registrarse.");
                txtNombre.Focus();
            }
            else if (val.vTexto(usuario) == false)
            {
                MessageBox.Show("Debe ingresar el nombre de usuario para registrarse.");
                txtUsuario.Focus();
            }
            else if (c == -1)
            {
                MessageBox.Show("Debe seleccionar un cargo para registrarse.");
                cmbCargo.Focus();
            }
            else if (val.vTexto(contraseña) == false)
            {
                MessageBox.Show("Debe ingresar una contraseña para registrarse.");
                txtClave.Focus();
            }
            else
            {
                using (ConexionDbContext db = new ConexionDbContext())
                {
                    try
                    {
                        var us = db.Usuario.Single();
                        if (nombre == us.Nombre)
                        {
                            MessageBox.Show("El nombre de usuario ya se encuentra registrado.");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        cargo = cmbCargo.Items[c].ToString();
                        if (cargo == "Colaborador" && bandera==false)
                        {
                            MessageBox.Show("Si selecciona como cargo a Colaborador no podrá registrar a otros usuarios" +
                                "en el futuro. De lo contrario cambie a Administrador.");
                            bandera = true;
                            return;
                        }
                    }
                    Usuario usu = new Usuario();
                    usu.Nombre = nombre;
                    usu.Cargo = cargo;
                    usu.NombreUsuario = usuario;
                    usu.Contraseña = contraseña;
                    db.Usuario.Add(usu);
                    db.SaveChanges();
                }
                txtNombre.Text = string.Empty;
                cmbCargo.Items.Clear();
                txtUsuario.Text = string.Empty;
                txtClave.Text = string.Empty;
                bandera = false;
                this.Close();
            }
        }

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
    
}
