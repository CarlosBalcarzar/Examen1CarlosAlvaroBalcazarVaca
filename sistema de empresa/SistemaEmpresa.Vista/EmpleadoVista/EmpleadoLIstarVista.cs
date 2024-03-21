using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEmpresa.Bss;
using SistemaEmpresa.Modelos;
using SistemaEmpresa.Vista.PersonaVista;

namespace SistemaEmpresa.Vista.EmpleadoVista
{
    public partial class EmpleadoLIstarVista : Form
    {
        public EmpleadoLIstarVista()
        {
            InitializeComponent();
        }
        EmpleadoBss Bss = new EmpleadoBss();
        private void EmpleadoLIstarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bss.ListaEmpleadoBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmpleadoIngresarVista fr = new EmpleadoIngresarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaEmpleadoBss();
            }
            dataGridView1.DataSource = Bss.ListaEmpleadoBss();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EmpleadoEditarVista fr = new EmpleadoEditarVista(IdEmpleadoSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaEmpleadoBss();
            }
            dataGridView1.DataSource = Bss.ListaEmpleadoBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdEmpleadoSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta Empleado", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Bss.EliminarEmpleadoBss(IdEmpleadoSeleccionada);
                dataGridView1.DataSource = Bss.ListaEmpleadoBss();
            }
        }
    }
}
