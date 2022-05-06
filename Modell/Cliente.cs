using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENA_Rodrigo_Vera_3600.Modell
{
    class Cliente
    {
        #region Atributo
        private string _nombre;
        private string _rut;
        private string _direccion;
        private string _email;
        private int _fono;
        private List<Mascota> mascotas = new List<Mascota>();

        #endregion

        #region Constructor
        public Cliente()
        {
            _nombre = string.Empty;
            _rut = string.Empty;
            _direccion = string.Empty;
            _email = string.Empty;
            _fono = 0;
        }
        public Cliente(string nombre, string rut, string direccion, string email, int fono)
        {
            _nombre = nombre;
            _rut = rut;
            _direccion = direccion;
            _email = email;
            _fono = fono;
        }

        #endregion

        #region Propiedades
        public int ClienteId { get; set; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Rut { get => _rut; set => _rut = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email = value; }
        public int Fono { get => _fono; set => _fono = value; }
        public List<Mascota> Mascotas { get=> mascotas; set=>mascotas=value; }
        public List<TablaIntermedia> TablaIntermedias { get; set; }
        #endregion

        #region Metodo

        public string obtenerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre           :").Append(_nombre).Append(Environment.NewLine);
            sb.Append("Rut              :").Append(_rut).Append(Environment.NewLine);
            sb.Append("Direccion        :").Append(_direccion).Append(Environment.NewLine);
            sb.Append("Email            :").Append(_email).Append(Environment.NewLine);
            sb.Append("Fono             :").Append(Convert.ToInt32(_fono)).Append(Environment.NewLine);
            return sb.ToString();
        }
        public void AgregarMascota(Mascota mas)
        {
            
            Mascotas.Add(mas);
        }
        #endregion

    }
}
