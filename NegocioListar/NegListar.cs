using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ListarDatos;
using EntidadListar;

namespace NegocioListar
{

    public class NegListar
    {
        Listar ObjDatosDNI = new Listar();


        public List<EntListar> ObtenerDNI()
        {
            return ObjDatosDNI.ObtenerDNI();
        }

    }
}
