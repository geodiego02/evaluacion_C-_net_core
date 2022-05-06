using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENA_Rodrigo_Vera_3600.Modell;
using ENA_Rodrigo_Vera_3600.View;

namespace ENA_Rodrigo_Vera_3600.Controller
{
    class Controlador
    {
        Mascota mascota = new Mascota();
        Cliente cli = new Cliente();
        #region List
        static List<Cliente> cl = new List<Cliente>();
        static List<Mascota> ma = new List<Mascota>();
        static List<ControlMascotas> co = new List<ControlMascotas>();
        List<Usuario> usu = new List<Usuario>();
        List<string> cadena = new List<string>();
        private string nombreCliente = string.Empty;
        #endregion

        #region IngresarCliente
        public bool agregarCliente(string nombre, string rut, string direccion, string email, int fono)
        {
            try
            {
                Cliente c = new Cliente(nombre, rut, direccion, email, fono);
                nombreCliente = nombre;
                using (ConexionDbContext db=new ConexionDbContext())
                {
                    
                    db.Cliente.Add(c);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool agregarMascota( string tipoMascota, string razaMascota, string sexoMascota, string vacunasMascota, string colorMascota, string nombreMascota, int edadMascota)
        {
            try
            {
                Mascota m = new Mascota( tipoMascota, razaMascota, sexoMascota, vacunasMascota, colorMascota, nombreMascota, edadMascota);


                using (ConexionDbContext db = new ConexionDbContext())
                {
                    var cliente = db.Cliente.Where(x=>x.Nombre==nombreCliente).First();
                    int id=cliente.ClienteId;
                    m.ClienteId = id;
                    db.Mascota.Add(m);
                    db.SaveChanges();
                    return true;
                }
                
                    
                
                
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Metodos
        public bool comprobarNombre(string a)
        {
            using (ConexionDbContext db=new ConexionDbContext())
            {
                try
                {
                    var cliente = db.Cliente.Where(x => x.Nombre == a).First();
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }
        public bool comprobarRut(string a)
        {
            using (ConexionDbContext db = new ConexionDbContext())
            {
                try
                {
                    var cliente = db.Cliente.Where(x => x.Rut == a).First();
                    return false;
                }
                catch (Exception)
                {
                    return true;
                }
            }
        }  
        public bool comprobarID(int a)
        {
            int b = 0;
            foreach (Mascota m in ma)
            {
                if (m.MascotaId == a)
                {
                    b = 1;
                }
            }
            if (b == 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int nuevoID()
        {
            int id;

            if (ma.Count() == 0)
            {
                id = 1;
            }
            else
            {
                id = (ma.Max(r => r.MascotaId)) + 1;
            }
            return id;
        }
        public int nuevoIDControl()
        {
            int id;

            if (co.Count() == 0)
            {
                id = 1;
            }
            else
            {
                id = (ma.Max(r => r.MascotaId)) + 1;
            }
            return id;
        }
        #endregion

        #region ControlMascotas
        public void agregarControl(int id, string nombreCliente, string nombreMascota, string detalle, string servicio, string programaVacuna, DateTime fecha, int total, DateTime fechaAntencion)
        {
            string tipo;
            string raza;
            int idM;

            foreach(Cliente cli in cl)
            {
                if(cli.Nombre == nombreCliente)
                {
                    //IdMascota***************************************************
                    //idM = cli.IdMascota;

                    foreach(Mascota m in ma)
                    {
                        /*
                        if(m.MascotaId == idM)
                        {
                            tipo = m.TipoMascota;
                            raza = m.RazaMascota;
                            ControlMascotas c = new ControlMascotas(id, nombreCliente, nombreMascota, tipo, raza,  detalle, servicio, programaVacuna, fecha, total, fechaAntencion);
                            co.Add(c);
                        }
                        */
                    }

                }
            }


        }



        #endregion

        #region Consulta
        public void cargaDatos(DataGridView d, string nom)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn cli = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn mas = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn tdm = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn rdm = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ua = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn det = new DataGridViewTextBoxColumn();

            id.HeaderText = "ID";
            cli.HeaderText = "Cliente";
            mas.HeaderText = "Mascota";
            tdm.HeaderText = "Tipo MAscota";
            rdm.HeaderText = "Raza";
            ua.HeaderText = "Ultima Actualizacion";
            det.HeaderText = "Detalle";

            d.Columns.Add(id);
            d.Columns.Add(cli);
            d.Columns.Add(mas);
            d.Columns.Add(tdm);
            d.Columns.Add(rdm);
            d.Columns.Add(ua);
            d.Columns.Add(det);
            d.DataSource = null;

            foreach(ControlMascotas con in co)
            {
                if(con.NombreCliente == nom)
                {
                    string Rid = con.ControlMascotasId.ToString();
                    string Rcli = con.NombreCliente.ToString();
                    string Rmas = con.NombreMascota.ToString();
                    string Rtdm = con.TipoMascota.ToString();
                    string Rrdm = con.RazaMascota.ToString();
                    string Rua = con.FechaAtencion.ToString();
                    string Rdet = con.Detalle.ToString();
                    d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm, Rua, Rdet);
                }
            }

        }
        public void CargarClientes(DataGridView d, string nom)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn nomb = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ru = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dire = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ema = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fon = new DataGridViewTextBoxColumn();

            nomb.HeaderText = "Nombre";
            ru.HeaderText = "Rut";
            dire.HeaderText = "Dirección";
            ema.HeaderText = "Email";
            fon.HeaderText = "Fono";

            d.Columns.Add(nomb);
            d.Columns.Add(ru);
            d.Columns.Add(dire);
            d.Columns.Add(ema);
            d.Columns.Add(fon);
            d.DataSource = null;
            using (ConexionDbContext db=new ConexionDbContext()) {
                try
                {
                    var co = db.Cliente.Where(x => x.Nombre == nom).First();

                    string Rid = co.Nombre;
                    string Rcli = co.Rut;
                    string Rmas = co.Direccion;
                    string Rtdm = co.Email;
                    string Rrdm = co.Fono.ToString();
                    d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la conexión a base de datos. Intente nuevamente.");
                }
                
            }
        }
        public void CargarTodoCliente(DataGridView d)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn nomb = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ru = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn dire = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ema = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn fon = new DataGridViewTextBoxColumn();

            nomb.HeaderText = "Nombre";
            ru.HeaderText = "Rut";
            dire.HeaderText = "Dirección";
            ema.HeaderText = "Email";
            fon.HeaderText = "Fono";

            d.Columns.Add(nomb);
            d.Columns.Add(ru);
            d.Columns.Add(dire);
            d.Columns.Add(ema);
            d.Columns.Add(fon);
            d.DataSource = null;

            using (ConexionDbContext db = new ConexionDbContext())
            {
                try
                {
                    var co = db.Cliente;
                    foreach (var item in co)
                    {
                        string Rid = item.Nombre;
                        string Rcli = item.Rut;
                        string Rmas = item.Direccion;
                        string Rtdm = item.Email;
                        string Rrdm = item.Fono.ToString();
                        d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la conexión a base de datos. Intente nuevamente.");
                }
                
            }


        }
        public void CargarTodoMascota(DataGridView d)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn tipo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn raza = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn sexo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn vacuna = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nombr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn edad = new DataGridViewTextBoxColumn();

            tipo.HeaderText = "TipoMascota";
            raza.HeaderText = "Raza";
            sexo.HeaderText = "Sexo";
            vacuna.HeaderText = "Vacuna";
            col.HeaderText = "Color";
            nombr.HeaderText = "NombreMascota";
            edad.HeaderText = "Edad";

            d.Columns.Add(tipo);
            d.Columns.Add(raza);
            d.Columns.Add(sexo);
            d.Columns.Add(vacuna);
            d.Columns.Add(col);
            d.Columns.Add(nombr);
            d.Columns.Add(edad);
            d.DataSource = null;

            using (ConexionDbContext db = new ConexionDbContext())
            {
                try
                {
                    var co = db.Mascota;
                    foreach (var item in co)
                    {
                        string Rid = item.TipoMascota;
                        string Rcli = item.RazaMascota;
                        string Rmas = item.SexoMascota;
                        string Rtdm = item.VacunasMascota;
                        string Rrdm = item.ColorMascota;
                        string Rrdm2 = item.NombreMascota;
                        string Rrdm3 = item.EdadMascota.ToString();
                        d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm, Rrdm2, Rrdm3);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la conexión a base de datos. Intente nuevamente.");
                }

            }


        }
        public void CargarMascotas(DataGridView d, string nom)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn tipo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn raza = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn sexo = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn vacuna = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn nombr = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn edad = new DataGridViewTextBoxColumn();

            tipo.HeaderText = "TipoMascota";
            raza.HeaderText = "Raza";
            sexo.HeaderText = "Sexo";
            vacuna.HeaderText = "Vacuna";
            col.HeaderText = "Color";
            nombr.HeaderText = "NombreMascota";
            edad.HeaderText = "Edad";

            d.Columns.Add(tipo);
            d.Columns.Add(raza);
            d.Columns.Add(sexo);
            d.Columns.Add(vacuna);
            d.Columns.Add(col);
            d.Columns.Add(nombr);
            d.Columns.Add(edad);
            d.DataSource = null;
            using (ConexionDbContext db = new ConexionDbContext())
            {
                try
                {
                    var co = db.Mascota.Where(x => x.NombreMascota == nom).First();

                    string Rid = co.TipoMascota;
                    string Rcli = co.RazaMascota;
                    string Rmas = co.SexoMascota;
                    string Rtdm = co.VacunasMascota;
                    string Rrdm = co.ColorMascota;
                    string Rrdm2 = co.NombreMascota;
                    string Rrdm3 = co.EdadMascota.ToString();
                    d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm,Rrdm2,Rrdm3);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error en la conexión a base de datos. Intente nuevamente.");
                }

            }
        }
        public void cargaDatosTodos(DataGridView d)
        {
            d.Rows.Clear();
            d.Columns.Clear();

            DataGridViewTextBoxColumn id = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn cli = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn mas = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn tdm = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn rdm = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn ua = new DataGridViewTextBoxColumn();
            DataGridViewTextBoxColumn det = new DataGridViewTextBoxColumn();

            id.HeaderText = "ID";
            cli.HeaderText = "Cliente";
            mas.HeaderText = "Mascota";
            tdm.HeaderText = "Tipo MAscota";
            rdm.HeaderText = "Raza";
            ua.HeaderText = "Ultima Actualizacion";
            det.HeaderText = "Detalle";

            d.Columns.Add(id);
            d.Columns.Add(cli);
            d.Columns.Add(mas);
            d.Columns.Add(tdm);
            d.Columns.Add(rdm);
            d.Columns.Add(ua);
            d.Columns.Add(det);
            d.DataSource = null;

            foreach (ControlMascotas con in co)
            {
                string Rid = con.ControlMascotasId.ToString();
                string Rcli = con.NombreCliente.ToString();
                string Rmas = con.NombreMascota.ToString();
                string Rtdm = con.TipoMascota.ToString();
                string Rrdm = con.RazaMascota.ToString();
                string Rua = con.FechaAtencion.ToString();
                string Rdet = con.Detalle.ToString();
                d.Rows.Add(Rid, Rcli, Rmas, Rtdm, Rrdm, Rua, Rdet);
            }

        }
        public bool buscarNombreConsulta(string nom)
        {
            foreach(ControlMascotas cm in co)
            {
                if(cm.NombreCliente == nom)
                {
                    return true;
                }
            }

            return false;
        }
        public bool eliminar(int id)
        {
            try
            {
                foreach (ControlMascotas c in co)
                {
                    if (c.ControlMascotasId == id)
                    {
                        co.Remove(c);
                        return true;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region ComboBoxPreCargados

        public void LlenarComboServicio(ComboBox cb)
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            cb.Items.Clear();

            //Incluir items

            cb.Items.Add("Control");
            cb.Items.Add("Radiografia");
            cb.Items.Add("Ecografia");
            cb.Items.Add("Peluqueria");
        }
        public void llenarCBTipo(ComboBox cb)
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            cb.Items.Clear();

            //Incluir items
            cb.Items.Add("Ave");
            cb.Items.Add("Gato");
            cb.Items.Add("Perro");

        }
        public void llenarCBMasPerro(ComboBox cb)
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            cb.Items.Clear();

            //Incluir items
            cb.Items.Add("Bulldog");
            cb.Items.Add("Dachshund");
            cb.Items.Add("Pug");
        }
        public void llenarCBMasGato(ComboBox cb)
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            cb.Items.Clear();

            //Incluir items
            cb.Items.Add("Bengala");
            cb.Items.Add("Siamés");
            cb.Items.Add("Siberiano");
        }
        public void llenarCBMasAve(ComboBox cb)
        {
            //Vaciar comboBox para que los items que vamos a añadir no se repitan
            cb.Items.Clear();

            //Incluir items
            cb.Items.Add("Agapornis");
            cb.Items.Add("Periquito");
            cb.Items.Add("Ninfas");

        }

        #endregion

        #region ComboBox
        public void llenarCBCliente(ComboBox cb)
        {
            cl.Sort((a, b) => string.Compare(a.Nombre, b.Nombre));
            cl = cl.OrderBy(a => a.Nombre).ToList();
            cb.DataSource = null;
            cb.DataSource = cl;
            cb.DisplayMember = "Nombre";
            cb.ValueMember = "IdMascota";
        }
        public void llenarCBMascota(ComboBox cb, string nom)
        {
            int id;
           string nomMas;

            foreach(Cliente c in cl)
            {
                if (c.Nombre == nom)
                {
                    //IdMascota*******************************************************************************
                    //id = c.IdMascota;
                    foreach (Mascota m in ma)
                    {/*
                        if (m.MascotaId == id)
                        {
                            nomMas = m.NombreMascota;
                            cb.Items.Add(nomMas);
                        }
                        */
                    }
                }
            }

        }

        public List<string> LlenarUsuarios()
        {
            using (ConexionDbContext db=new ConexionDbContext())
            {
                cadena.Clear();
                var lista=db.Usuario.OrderBy(x => x.NombreUsuario).ToList();
                foreach (var item in lista)
                {
                    cadena.Add(item.NombreUsuario);
                }

            }
            return cadena;
            
        }
        public List<string> LlenarClientes()
        {
            using (ConexionDbContext db = new ConexionDbContext())
            {
                cadena.Clear();
                var lista = db.Cliente.OrderBy(x => x.Nombre).ToList();
                foreach (var item in lista)
                {
                    cadena.Add(item.Nombre);
                }

            }
            return cadena;
        }
        public List<string> LlenarMascotas()
        {
            using (ConexionDbContext db = new ConexionDbContext())
            {
                cadena.Clear();
                var lista = db.Mascota.OrderBy(x => x.NombreMascota).ToList();
                foreach (var item in lista)
                {
                    cadena.Add(item.NombreMascota);
                }

            }
            return cadena;
        }

        public void MandarCliente(string nom)
        {
            nombreCliente = nom;
        }
        #endregion
    }
}
