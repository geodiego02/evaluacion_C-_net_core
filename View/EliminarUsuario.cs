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
    public partial class EliminarUsuario : Form
    {
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = cmbUsuarios.SelectedIndex;
            if (indice==-1)
            {
                MessageBox.Show("Debe seleccionar un usuario.");
            }
            else
            {
                string usuario = cmbUsuarios.Items[indice].ToString();
                using (ConexionDbContext db = new ConexionDbContext())
                {
                    var x4 = db.Usuario.Where(x => x.NombreUsuario == usuario).First();
                    db.Usuario.Remove(x4);
                    db.SaveChanges();
                }
                cmbUsuarios.Items.Clear();
                this.Close();
            }
            
        }

        private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            List<string> lista = new List<string>();
            Controlador cn = new Controlador();
            lista=cn.LlenarUsuarios();
            foreach (string item in lista)
            {
                cmbUsuarios.Items.Add(item);
            }

        }
    }
}
