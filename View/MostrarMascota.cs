using ENA_Rodrigo_Vera_3600.Controller;
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
    public partial class MostrarMascota : Form
    {
        Controlador cn = new Controlador();
        public MostrarMascota()
        {
            InitializeComponent();
        }

        private void MostrarMascota_Load(object sender, EventArgs e)
        {
            LlenarClientes();
        }
        private void LlenarClientes()
        {
            cboMascotas.Items.Clear();
            List<string> lista = new List<string>();

            lista = cn.LlenarMascotas();
            foreach (string item in lista)
            {
                cboMascotas.Items.Add(item);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = cboMascotas.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar a un cliente para mostrar.");
            }
            else
            {
                string nombre = cboMascotas.Items[indice].ToString();
                dg.Visible = true;
                cn.CargarMascotas(dg, nombre);
            }
        }

        private void btnBuscarTodo_Click(object sender, EventArgs e)
        {
            dg.Visible = true;
            cn.CargarTodoMascota(dg);
        }
    }
}
