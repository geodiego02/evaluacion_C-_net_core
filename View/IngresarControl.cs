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
using ENA_Rodrigo_Vera_3600.View.Ingresar_Cliente;

namespace ENA_Rodrigo_Vera_3600.View
{
    public partial class IngresarControl : Form
    {
        ValidacionYFormato vf = new ValidacionYFormato();
        Controlador cont = new Controlador();
        
        public IngresarControl()
        {
            InitializeComponent();
        }
        // Al iniciar el Form
        private void IngresarControl_Load(object sender, EventArgs e)
        {
            cb_servicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nombreCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_nombreMascota.DropDownStyle = ComboBoxStyle.DropDownList;

            cb_nombreCliente.Items.Clear();
            cb_nombreMascota.Items.Clear();
            cb_servicio.Items.Clear();

            cb_nombreCliente.Text = string.Empty;
            cb_nombreMascota.Text = string.Empty;
            cb_servicio.Text = string.Empty;

            cont.LlenarComboServicio(cb_servicio);
            cont.llenarCBCliente(cb_nombreCliente);

            rtb_detalle.Text = string.Empty;
            dt_fechaAtencion.Value = DateTime.Now;
            dt_fechaVacuna.Value = DateTime.Now;

            rb_si.Checked = false;
            rb_no.Checked = false;

            tb_total.Text = string.Empty;
        }
        // Boton para ingresar al Form de Consultas
        private void btn_Consulta_Click(object sender, EventArgs e)
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
        // Boton para salir del form y regresar al menu.
        private void btn_volver2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Al Seleccionar un Cliente
        private void cb_nombreCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nom = cb_nombreCliente.Text;
            cb_nombreMascota.Items.Clear();
            cont.llenarCBMascota(cb_nombreMascota, nom);
        }
        // Boton para guardar la Consulta (Agendar la Hora).
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string nomC = cb_nombreCliente.Text;            // Nombre cliente
            string nomM = cb_nombreMascota.Text;            // Nombre Mascota
            string det = rtb_detalle.Text;                  // Detalle de Atencion
            string serv = cb_servicio.Text;                 // Servicio Solicitado
            DateTime fechaAt = dt_fechaAtencion.Value.Date; // Fecha de Atencion
            string vac = string.Empty;                      // Vacuna. (Agenda si/no)
            DateTime fechaVac = dt_fechaVacuna.Value.Date;  // Fecha de Vacuna
            string total = tb_total.Text;                   // Valor total de la consulta.
            DateTime fec2 = DateTime.Today;                 //  Fecha actual.
            
            // Comprobamos los campos
            if (vf.vTexto(nomC) == false)
            {
                MessageBox.Show("Debe seleccionar un Cliente.");
                cb_nombreCliente.Focus();
            }
            else if (vf.vTexto(nomM) == false)
            {
                MessageBox.Show("Debe seleccionar una Mascota.");
                cb_nombreMascota.Focus();
            }
            else if (vf.vTexto(det) == false)
            {
                MessageBox.Show("Debe escribir el detalle de la revision.");
                rtb_detalle.Focus();
            }
            else if (vf.vTexto(serv) == false)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
                cb_servicio.Focus();
            }
            if(rb_si.Checked == false && rb_no.Checked == false)
            {
                MessageBox.Show("Debe seleccionar program de vacunas, si / no.");
                rb_si.Focus();
            }
            if (fechaAt < fec2)
            {
                MessageBox.Show("La fecha seleccionada no puede ser menor a hoy");
                dt_fechaAtencion.Focus();
            }
            if(vf.vTexto(total) == false || vf.vNumero(total) == false)
            {
                MessageBox.Show("El dato ingresado en Total esta vacio o no es numero.");
                tb_total.Focus();
            }
            else
            {
                int id = cont.nuevoIDControl();
                int tot = Convert.ToInt32(total);

                if(rb_si.Checked == true)
                {
                    vac = rb_si.Text;
                }
                else if(rb_no.Checked == true)
                {
                    vac = rb_no.Text;
                }

       
                cont.agregarControl(id, nomC, nomM, det, serv, vac, fechaVac, tot, fechaAt);

                if (rb_si.Checked == true)
                {
                    MessageBox.Show("Se a agendado la consulta para el dia. "+ fechaAt.ToString() + " \n Se ha agendado la vacuna para el dia " + fechaVac.ToString());
                }
                else
                {
                    MessageBox.Show("Se a agendado la consulta para el dia. " + fechaAt.ToString());
                }

                

                rtb_detalle.Text = string.Empty;
                dt_fechaAtencion.Value = DateTime.Now;
                dt_fechaVacuna.Value = DateTime.Now;

                rb_si.Checked = false;
                rb_no.Checked = false;

                tb_total.Text = string.Empty;

                cb_nombreMascota.Items.Clear();
                cb_servicio.Items.Clear();
                cont.LlenarComboServicio(cb_servicio);


            }

        }
    }
}
