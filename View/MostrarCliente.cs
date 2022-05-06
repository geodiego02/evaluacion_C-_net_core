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
    public partial class MostrarCliente : Form
    {
        bool eliminar = false;
        Controlador cn = new Controlador();
        public MostrarCliente()
        {
            InitializeComponent();
        }

        private void MostrarCliente_Load(object sender, EventArgs e)
        {
            LlenarClientes();
        }
        private void LlenarClientes()
        {
            comboBox1.Items.Clear();
            List<string> lista = new List<string>();

            lista = cn.LlenarClientes();
            foreach (string item in lista)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indice=comboBox1.SelectedIndex;
            if (indice == -1)
            {
                MessageBox.Show("Debe seleccionar a un cliente para mostrar.");
            }
            else
            {
                string nombre = comboBox1.Items[indice].ToString();
                dataGridView1.Visible = true;
                cn.CargarClientes(dataGridView1,nombre);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (eliminar==false)
            {
                MessageBox.Show("Considere que al eliminar a un cliente también estará eliminando a las mascotas que tiene.");
            }
            Int32 grill = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);

            if (grill > 0)
            {
                if (dataGridView1.AreAllCellsSelected(true))
                {
                    MessageBox.Show("Se han seleccionado todos los elementos.");
                }
                else
                {
                    string nombre =dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    try
                    {
                        using (ConexionDbContext db = new ConexionDbContext())
                        {
                            var cli = db.Cliente.Where(x => x.Nombre == nombre).First();
                            int id = cli.ClienteId;

                            var mas = db.Mascota.Where(x => x.ClienteId == id);
                            foreach (Mascota mascota in mas)
                            {
                                try
                                {
                                    if (mascota!=null)
                                    {
                                        db.Mascota.Remove(mascota);
                                    }
                                    
                                }
                                catch (Exception)
                                {

                                    MessageBox.Show("Error al intentar eliminar a una mascota.");
                                }
                            }
                            db.Cliente.Remove(cli);
                            db.SaveChanges();
                            LlenarClientes();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Error en la conexión a la base de datos. Intente nuevamente.");
                    }
                    
                    MessageBox.Show("Se ha eliminado al cliente . "+nombre);
                    dataGridView1.Columns.Clear();
                    dataGridView1.Visible = false;
                }
            }
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            cn.CargarTodoCliente(dataGridView1);
        }
    }
}
