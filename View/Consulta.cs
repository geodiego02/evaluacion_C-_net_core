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
using ENA_Rodrigo_Vera_3600.Controller;

namespace ENA_Rodrigo_Vera_3600.View
{
    public partial class Consulta : Form
    {
        Controlador cont = new Controlador();
        ValidacionYFormato v = new ValidacionYFormato();
        public Consulta()
        {
            InitializeComponent();
        }
        private void Consulta_Load(object sender, EventArgs e)
        {
            cb_ClienteConsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_MascotaConsulta.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_ClienteConsulta.Items.Clear();
            cb_MascotaConsulta.Items.Clear();

            cb_ClienteConsulta.Text = string.Empty;
            cb_MascotaConsulta.Text = string.Empty;

            cont.llenarCBCliente(cb_ClienteConsulta);
            dgv_Consulta.Visible = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string nomCli = cb_ClienteConsulta.Text;
            string nomMas = cb_MascotaConsulta.Text;

            if (v.vTexto(nomCli) == false || v.vTexto(nomMas) == false)
            {
                MessageBox.Show("Debe seleccionar Cliente y Mascota.");
            }
            else
            {
                if (cont.buscarNombreConsulta(nomCli) == false)
                {
                    MessageBox.Show("El cliente no tiene Control agendado.");
                }
                else
                {
                    dgv_Consulta.Visible = true;
                    cont.cargaDatos(dgv_Consulta, nomCli);
                }
            }
        }

        private void btn_volver3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_ClienteConsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = false;
            dgv_Consulta.Columns.Clear();
            dgv_Consulta.Visible = false;
            string nom = cb_ClienteConsulta.Text;
            cb_MascotaConsulta.Items.Clear();
            cont.llenarCBMascota(cb_MascotaConsulta, nom);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Int32 grill = dgv_Consulta.GetCellCount(DataGridViewElementStates.Selected);

            if (grill > 0)
            {
                if (dgv_Consulta.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Se han seleccionado todos los elementos.");
                }
                else
                {
                    string id = dgv_Consulta.CurrentRow.Cells[0].Value.ToString();
                    string nom = dgv_Consulta.CurrentRow.Cells[1].Value.ToString();
                    int ide = Convert.ToInt32(id);
                    cont.eliminar(ide);
                    MessageBox.Show("Se ha eliminado la Hora agendada \n para el cliente  " + nom );
                    dgv_Consulta.Columns.Clear();
                    dgv_Consulta.Visible = false;
                    btn_Eliminar.Enabled = false;
                }
            }



        }

        private void btn_buscarTodos_Click(object sender, EventArgs e)
        {
            dgv_Consulta.Visible = true;
            cont.cargaDatosTodos(dgv_Consulta);

            if (dgv_Consulta.Rows.Count == 0)
            {
                MessageBox.Show("No hay consultas registradas.");
                dgv_Consulta.Visible = false;
            }            
        }

        private void dgv_Consulta_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
        }
    }
}
