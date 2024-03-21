using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.Dal
{
    public class PersonaDal
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from Persona";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarPersonaDal(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.NOMBRE + "'," +
                                                         "'" + persona.APELLIDO + "'," +
                                                         "'Activo')";
            Conexion.Ejecutar(consulta);
        }
        public Persona obtenerPersonaId(int id)
        {
            string consulta = "select * from persona where Idpersona =" + id;
            DataTable table = Conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (table.Rows.Count > 0)
            {
                p.IDPERSONA = Convert.ToInt32(table.Rows[0]["IDPERSONA"]);
                p.NOMBRE = table.Rows[0]["NOMBRE"].ToString();
                p.APELLIDO = table.Rows[0]["APELLIDO"].ToString();
                p.ESTADO = table.Rows[0]["Correo"].ToString();
            }
            return p;
        }
        public void EditarPersonaDal(Persona persona)
        {
            string consulta = "UPDATE persona SET NOMBRE='" + persona.NOMBRE + "', " +
                                                  "APELLIDO='" + persona.APELLIDO + "', " +
                              "WHERE IDPERSONA=" + persona.IDPERSONA;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where IDPERSONA=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
