using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using EntidadListar;

namespace ListarDatos
{
    public class Listar
    {
        public List<EntListar> ObtenerDNI()
        {
            List<EntListar> Lista = new List<EntListar>();
            string Orden1 = "select IdDNI From Personas";
            OleDbCommand cmd = new OleDbCommand(Orden1);
            OleDbDataReader dr;
            try
            {

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    EntListar t = new EntListar();
                    t._dni = dr.GetInt16(0);
                    Lista.Add(t);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error al Listar los Servicios", e);
            }
            finally
            {

                cmd.Dispose();
            }
            return Lista;
        }
    }
}
