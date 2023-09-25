using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadListar
{
    public class EntListar
    {
        #region Atributos
        private int IdDNI;
        private string Nombre;
        private string Apellido;
        private string Direccion;
        private string Barrio;
        private int Telefono;
        private string Consolidador;
        private DateTime Fecha_de_nacimiento;
        private string Detalle;
        #endregion

        #region Constructor

        public EntListar()
        {}

        public EntListar(int DNI, string Nom, string Ape, string Dire, string Barr, int Tel, string Con, DateTime Fec, string Det)
        {
            IdDNI = DNI;
            Nombre = Nom;
            Apellido = Ape;
            Direccion = Dire;
            Barrio = Barr;
            Telefono = Tel;
            Consolidador = Con;
            Fecha_de_nacimiento = Fec;
            Detalle = Det;
        }

        #endregion

        #region Propiedades

        public int _dni
        {
            set { IdDNI = value; }
            get { return IdDNI; }
        }

        public string _nombre
        {
            set { Nombre = value; }
            get { return Nombre; }
        }
        public string _apellido
        {
            set { Apellido = value; }
            get { return Apellido; }
        }
        public string _direccion
        {
            set { Direccion = value; }
            get { return Direccion; }
        }
        public string _barrio
        {
            set { Barrio = value; }
            get { return Barrio; }
        }
        public int _telefono
        {
            set { Telefono = value; }
            get { return Telefono; }
        }
        public string _consolidador
        {
            set { Consolidador = value; }
            get { return Consolidador; }
        }

        public DateTime _fechanacimiento
        {
            set { Fecha_de_nacimiento = value; }
            get { return Fecha_de_nacimiento; }
        }

        public string _detalle
        {
            set { Detalle = value; }
            get { return Detalle; }
        }
        #endregion
    }
}
