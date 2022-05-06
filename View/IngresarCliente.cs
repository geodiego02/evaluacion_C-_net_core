using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENA_Rodrigo_Vera_3600.View;
using ENA_Rodrigo_Vera_3600.Controller;
using ENA_Rodrigo_Vera_3600.Modell;

namespace ENA_Rodrigo_Vera_3600.View.Ingresar_Cliente
{
    public partial class IngresarCliente : Form
    {
        ValidacionYFormato vf = new ValidacionYFormato();
        Controlador cont = new Controlador();
        bool clienteRepetido = false;
        bool valcli;
        
        public IngresarCliente()
        {
            InitializeComponent();

        }
        private void IngresarCliente_Load(object sender, EventArgs e)
        {   
            
            

            // Limpiamos datos del Cliente
            tb_NombreCliente.Text = string.Empty;
            tb_RutCliente.Text = string.Empty;
            tb_DireccionCliente.Text = string.Empty;
            tb_EmailCliente.Text = string.Empty;
            tb_FonoCliente.Text = string.Empty;
            // Limpiamos datos de la Mascota
            
            rb_Macho.Checked = false;
            rb_Hembra.Checked = false;
            rb_Si.Checked = false;
            rb_No.Checked = false;
            tb_ColorMascota.Text = string.Empty;
            tb_NombreMascota.Text = string.Empty;
            tb_Edad.Text = string.Empty;
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
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
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            // Cliente
            string nomCli = tb_NombreCliente.Text;
            string rut = tb_RutCliente.Text;
            string dir = tb_DireccionCliente.Text;
            string em = tb_EmailCliente.Text;
            string fo = tb_FonoCliente.Text;
            // Mascota
            string tipo = cb_TipoMascota.Text;


            
            string sexo;
            string vacunas;
            string color = tb_ColorMascota.Text;
            string nomMas = tb_NombreMascota.Text;
            string ed = tb_Edad.Text;



            //Aquí obtengo índice de combobox
            int indice = cb_RazaMascota.SelectedIndex;




            // Comprobamos
            if (vf.vTexto(nomCli) == false)
            {
                MessageBox.Show("El campo Nombre del Cliente esta vacio.");
                tb_NombreCliente.Focus();
            }
            else if(vf.vTexto(rut) == false)
            {
                MessageBox.Show("El campo Rut del Cliente esta vacio.");
                tb_RutCliente.Focus();
            }
            else if (vf.vTexto(dir) == false)
            {
                MessageBox.Show("El campo Direccion del Cliente esta vacio.");
                tb_DireccionCliente.Focus();
            }
            else if (vf.vTexto(em) == false)
            {
                MessageBox.Show("El campo Email del Cliente esta vacio.");
                tb_EmailCliente.Focus();
            }
            else if (vf.vTexto(fo) == false || vf.vNumero(fo) == false)
            {
                MessageBox.Show("El campo Fono del Cliente esta vacio o no es numero.");
                tb_FonoCliente.Focus();
            }
            else if (tipo == "Tipo de Mascota" || tipo == null)
            {
                MessageBox.Show("Debe seleccionar el tipo de Mascota.");
                cb_TipoMascota.Focus();
            }
            else if (indice==-1)
            {
                MessageBox.Show("Debe seleccionar la raza de la Mascota.");
                cb_RazaMascota.Focus();
            }
            else if (!rb_Macho.Checked && !rb_Hembra.Checked)
            {
                MessageBox.Show("Debe seleccionar sexo de la mascota.");
            }
            else if (!rb_Si.Checked && !rb_No.Checked)
            {
                MessageBox.Show("Debe seleccionar si las vacunas de la mascota estan al día.");
            }
            else if (vf.vTexto(color) == false)
            {
                MessageBox.Show("El campo Color de la Mascota esta vacío.");
                tb_ColorMascota.Focus();
            }
            else if (vf.vTexto(nomMas) == false)
            {
                MessageBox.Show("El campo Nombre de la Mascota esta vacío.");
                tb_NombreMascota.Focus();
            }
            else if (vf.vTexto(ed) == false || vf.vNumero(ed) == false)
            {
                MessageBox.Show("El campo Edad de la Mascota esta vacio o no es numero.");
                tb_Edad.Focus();
            }
            else if(cont.comprobarNombre(nomCli) == false && clienteRepetido==false)
            {
                MessageBox.Show("El Nombre del Cliente ya se encuentra ingresado. Si desea agregar una mascota a este " +
                    "cliente debe intentarlo nuevamente, sino debe volver a intentar con otro cliente.");
                tb_NombreCliente.Focus();
                clienteRepetido = true;
            }
            
            else
            {
                if (rb_Macho.Checked)
                {
                    sexo = rb_Macho.Text;
                }
                else
                {
                    sexo = rb_Hembra.Text;
                }

                if (rb_Si.Checked)
                {
                    vacunas = rb_Si.Text;
                }
                else
                {
                    vacunas = rb_No.Text;
                }
                int fon = Convert.ToInt32(fo);
                int eda = Convert.ToInt32(ed);
                string raza= cb_RazaMascota.Items[indice].ToString();

                //int id = cont.nuevoID();

                // Agregamos al Cliente
                if (clienteRepetido == false)
                {
                    valcli = cont.agregarCliente(nomCli, rut, dir, em, fon);
                }
                cont.MandarCliente(nomCli);
                bool valmas = cont.agregarMascota(tipo, raza, sexo, vacunas, color, nomMas, eda);

                // comprobamos la ejecucion (Verdadero / Falso)
                if ((valcli == false && clienteRepetido==false) || valmas == false)
                {
                    MessageBox.Show("Hubo un error al ingrear los datos del cliente.");
                }
                else
                {
                    MessageBox.Show("Los datos del Cliente y Mascota se ingresaron correctamente.");
                    // Limpiamos datos del Cliente
                    tb_NombreCliente.Text = string.Empty;
                    tb_RutCliente.Text = string.Empty;
                    tb_DireccionCliente.Text = string.Empty;
                    tb_EmailCliente.Text = string.Empty;
                    tb_FonoCliente.Text = string.Empty;
                    // Limpiamos datos de la Mascota
                    rb_Macho.Checked = false;
                    rb_Hembra.Checked = false;
                    rb_Si.Checked = false;
                    rb_No.Checked = false;
                    tb_ColorMascota.Text = string.Empty;
                    tb_NombreMascota.Text = string.Empty;
                    tb_Edad.Text = string.Empty;

                    cb_TipoMascota.Items.Clear();
                    cont.llenarCBTipo(cb_TipoMascota);
                    cb_RazaMascota.Items.Clear();

                }
            }
        }
        private void cb_TipoMascota_SelectedIndexChanged(object sender, EventArgs e)
        {   // Cargamos ComboBox Mascota dependiendo de la seleccion del CB tipo.
            
            if (cb_TipoMascota.Text == "Perro")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasPerro(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Gato")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasGato(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Loro")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasAve(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Conejo")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasAve(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Gallina")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasAve(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Lobo")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasAve(cb_RazaMascota);
            }
            else if (cb_TipoMascota.Text == "Tigre")
            {
                cb_RazaMascota.Items.Clear();
                cb_RazaMascota.Text = string.Empty;
                cont.llenarCBMasAve(cb_RazaMascota);
            }
        }
        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
