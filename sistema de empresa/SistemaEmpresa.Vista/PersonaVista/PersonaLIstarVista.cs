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

namespace SistemaEmpresa.Vista.PersonaVista
{
    public partial class PersonaLIstarVista : Form
    {
        public PersonaLIstarVista()
        {
            InitializeComponent();
        }
        PersonaBss Bss = new PersonaBss();
        private void PersonaLIstarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            PersonaIngresarVista fr = new PersonaIngresarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Esta seguro de eliminar esta persona", "Eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Bss.EliminarPersonBss(IdPersonaSeleccionada);
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarVista fr = new PersonaEditarVista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }
    }
}
/*
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioIngresarVIsta.IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int IdPersonaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            PersonaEditarvista fr = new PersonaEditarvista(IdPersonaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = Bss.ListaPersonaBss();
            }
            dataGridView1.DataSource = Bss.ListaPersonaBss();
        }*/