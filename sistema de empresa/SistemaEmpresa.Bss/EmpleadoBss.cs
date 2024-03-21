using SistemaEmpresa.Dal;
using SistemaEmpresa.Modelos;
using System.Data;

namespace SistemaEmpresa.Bss
{
    public class EmpleadoBss
    {
        EmpleadoDal dal = new EmpleadoDal();
        public DataTable ListaEmpleadoBss()
        {
            return dal.ListarEmpleadoDal();
        }
        public void InsertarEmpleadoBss(Empleado empleado)
        {
            dal.InsertarEmpleadoDal(empleado);
        }
        /*public Empleado ObtenerIdBss(int id)
        {
            return dal.obtenerEmpleadoId(id);
        }*/
        public void EditarEmpleadoBss(Empleado e)
        {
            dal.EditarEmpleadoDal(e);
        }
        public void EliminarEmpleadoBss(int id)
        {
            dal.EliminarEmpleadoDal(id);
        }
    }
}