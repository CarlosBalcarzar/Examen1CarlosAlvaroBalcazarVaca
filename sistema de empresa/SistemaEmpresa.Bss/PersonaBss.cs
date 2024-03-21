using SistemaEmpresa.Dal;
using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.Bss
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListaPersonaBss()
        {
            return dal.ListarPersonaDal();
        }
        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDal(persona);
        }
        public Persona ObtenerIdBss(int id)
        {
            return dal.obtenerPersonaId(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
