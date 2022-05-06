using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Modell
{
    class ControlMascotas
    {
        #region Atributo
        private int _controlMascotasId;
        private string _nombreCliente;
        private string _nombreMascota;
        private string _tipoMascota;
        private string _razaMascota;
        private string _detalle;
        private string _servicio;
        private string _programaVacuna;
        private DateTime _fecha;
        private int _total;
        private DateTime _fechaAtencion;


        #endregion
        #region Constructor
        public ControlMascotas()
        {
            _controlMascotasId = 0;
            _nombreCliente = string.Empty;
            _nombreMascota = string.Empty;
            _tipoMascota = string.Empty;
            _razaMascota = string.Empty;
            _detalle = string.Empty;
            _servicio = string.Empty;
            _programaVacuna = string.Empty;
            _fecha = DateTime.Today;
            _total = 0;
            _fechaAtencion = DateTime.Today;
        }
        public ControlMascotas(int id, string nombreCliente, string nombreMascota, string tipoMascota, string razaMascota, string detalle, string servicio, string programaVacuna, DateTime fecha, int total, DateTime fechaAtencion)
        {
            _controlMascotasId = id;
            _nombreCliente = nombreCliente;
            _nombreMascota = nombreMascota;
            _tipoMascota = tipoMascota;
            _razaMascota = razaMascota;
            _detalle = detalle;
            _servicio = servicio;
            _programaVacuna = programaVacuna;
            _fecha = fecha;
            _total = total;
            _fechaAtencion = fechaAtencion;
        }
        #endregion
        #region Propiedades
        public int ControlMascotasId { get => _controlMascotasId; set => _controlMascotasId = value; }
        public string NombreCliente { get => _nombreCliente; set => _nombreCliente = value; }
        public string NombreMascota { get => _nombreMascota; set => _nombreMascota = value; }
        public string TipoMascota { get => _tipoMascota; set => _tipoMascota = value; }
        public string RazaMascota { get => _razaMascota; set => _razaMascota = value; }
        public string Detalle { get => _detalle; set => _detalle = value; }
        public string Servicio { get => _servicio; set => _servicio = value; }
        public string ProgramaVacuna { get => _programaVacuna; set => _programaVacuna = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public int Total { get => _total; set => _total = value; }
        public DateTime FechaAtencion { get => _fechaAtencion; set => _fechaAtencion = value; }
        public List<TablaIntermedia> TablaIntermedias { get; set; }
       
        #endregion
        #region Metodo


        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Id                   :").Append(_controlMascotasId).Append(Environment.NewLine);
            sb.Append("Nombe del Cliente    :").Append(_nombreCliente).Append(Environment.NewLine);
            sb.Append("Nombre de Mascota    :").Append(_nombreMascota).Append(Environment.NewLine);
            sb.Append("Tipo de Mascota      :").Append(_tipoMascota).Append(Environment.NewLine);
            sb.Append("Raza de Mascota      :").Append(_razaMascota).Append(Environment.NewLine);
            sb.Append("Detalle de consulta  :").Append(_detalle).Append(Environment.NewLine);
            sb.Append("Tipo de Servicio     :").Append(_servicio).Append(Environment.NewLine);
            sb.Append("Programa Vacuna      :").Append(_programaVacuna).Append(Environment.NewLine);
            sb.Append("Fecha                :").Append(_fecha.ToString()).Append(Environment.NewLine);
            sb.Append("Total                :").Append(_total).Append(Environment.NewLine);
            sb.Append("Fecha de Atencion    :").Append(_fecha).Append(Environment.NewLine);

            // consultar al profesor  sb.Append("Total a Cancelar     :").Append(_fecha.ToString()).Append(Environment.NewLine);


            return sb.ToString();
        }
        #endregion
    }
}
