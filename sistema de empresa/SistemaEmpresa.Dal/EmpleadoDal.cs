using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa.Dal
{
    public class EmpleadoDal
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from Empleado";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarEmpleadoDal(Empleado empleado)
        {
            string consulta = "insert into Empleado values('" + empleado.PUESTO + "'," +
                                                         "'" + empleado.SALARIO + "'," +
                                                         "'" + empleado.FECHA_CONTRATACION + "')";
                                                         
            Conexion.Ejecutar(consulta);
        }
        //public Empleado obtenerEmpleadoId(int id)
        //{
        //    string consulta = "select * from persona where IDEMPLEADO =" + id;
        //    DataTable table = Conexion.EjecutarDataTabla(consulta, "asdas");
        //    Empleado e = new Empleado();
        //    if (table.Rows.Count > 0)
        //    {
        //        e.IDEMPLEADO = Convert.ToInt32(table.Rows[0]["IDEMPLEADO"]);
        //        e.IDPERSONA = Convert.ToInt32(table.Rows[0]["IDPERSONA"]);
        //        e.PUESTO = table.Rows[0]["PUESTO"].ToString();
        //        e.SALARIO = table.Rows[0]["SALARIO"].ToString();
        //        e.FECHA_CONTRATACION = table.Rows[0]["FECHA_CONTRATACION"].ToString();
        //    }
        //    return e;
        //}
        public void EditarEmpleadoDal(Empleado empleado)
        {
            string consulta = "UPDATE Empleado SET IDPERSONA='" + empleado.IDPERSONA + "', " +
                                                  "PUESTO='" + empleado.PUESTO + "', " +
                                                  "SALARIO='" + empleado.SALARIO + "', " +
                                                  "FECHA_CONTRATACION='" + empleado.FECHA_CONTRATACION + "', " +
                              "WHERE IDEMPLEADO=" + empleado.IDEMPLEADO;
            Conexion.Ejecutar(consulta);
        }

        public void EliminarEmpleadoDal(int id)
        {
            string consulta = "delete from persona where IDEMPLEADO=" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
