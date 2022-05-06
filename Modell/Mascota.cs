using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Modell
{
    class Mascota
    {
        #region Atributo
        private string _tipoMascota;
        private string _razaMascota;
        private string _sexoMascota;
        private string _vacunasMascota;
        private string _colorMascota;
        private string _nombreMascota;
        private int _edadMascota;
        #endregion
        #region Constructor
        public Mascota()
        {
            _tipoMascota = string.Empty;
            _razaMascota = string.Empty;
            _sexoMascota = string.Empty;
            _vacunasMascota = string.Empty;
            _colorMascota = string.Empty;
            _nombreMascota = string.Empty;
            _edadMascota = 0;
        }
        public Mascota( string tipoMascota, string razaMascota, string sexoMascota, string vacunasMascota, string colorMascota, string nombreMascota, int edadMascota)
        {
            _tipoMascota = tipoMascota;
            _razaMascota = razaMascota;
            _sexoMascota = sexoMascota;
            _vacunasMascota = vacunasMascota;
            _colorMascota = colorMascota;
            _nombreMascota = nombreMascota;
            _edadMascota = edadMascota;
        }
        #endregion
        #region Propiedades
        public int MascotaId { get; set; }
        public string TipoMascota { get => _tipoMascota; set => _tipoMascota = value; }
        public string RazaMascota { get => _razaMascota; set => _razaMascota = value; }
        public string SexoMascota { get => _sexoMascota; set => _sexoMascota = value; }
        public string VacunasMascota { get => _vacunasMascota; set => _vacunasMascota = value; }
        public string ColorMascota { get => _colorMascota; set => _colorMascota = value; }
        public string NombreMascota { get => _nombreMascota; set => _nombreMascota = value; }
        public int EdadMascota { get => _edadMascota; set => _edadMascota = value; }
        public Cliente Cliente { get; set; }
        public int? ClienteId { get; set; }
      
        #endregion
        #region Metodo

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Tipo             :").Append(_tipoMascota).Append(Environment.NewLine);
            sb.Append("Raza             :").Append(_razaMascota).Append(Environment.NewLine);
            sb.Append("Sexo             :").Append(_sexoMascota).Append(Environment.NewLine);
            sb.Append("Vacunas al día   :").Append(_vacunasMascota).Append(Environment.NewLine);
            sb.Append("Color            :").Append(_colorMascota).Append(Environment.NewLine);
            sb.Append("Nombre           :").Append(_nombreMascota).Append(Environment.NewLine);
            sb.Append("Edad             :").Append(Convert.ToInt32(_edadMascota)).Append(Environment.NewLine);

            return sb.ToString();
        }

        #endregion
    }
}
