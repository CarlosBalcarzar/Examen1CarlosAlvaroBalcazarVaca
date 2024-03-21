using SistemaEmpresa.Bss;
using SistemaEmpresa.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEmpresa.Vista.PersonaVista
{
    public partial class PersonaEditarVista : Form
    {
        int idx = 0;
        Persona persona = new Persona();
        PersonaBss bss = new PersonaBss();
        public PersonaEditarVista(int id)
        {
            idx = id;
            InitializeComponent();
        }
        private void PersonaEditarVista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerIdBss(idx);
            textBox1.Text = persona.NOMBRE;
            textBox2.Text = persona.APELLIDO;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            persona.NOMBRE = textBox1.Text;
            persona.APELLIDO = textBox2.Text;
            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos actulizados");
        }

        
    }
}
/*
  public partial class PersonaEditarvista : Form
    {
        private void PersonaEditarvista_Load(object sender, EventArgs e)
        {
            persona = bss.ObtenerIdBss(idx);
            textBox1.Text = persona.Nombre;
            textBox2.Text = persona.Apellido;
            textBox3.Text = persona.Telefono;
            textBox4.Text = persona.Ci;
            textBox5.Text = persona.Correo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = textBox1.Text;
            persona.Apellido = textBox2.Text;
            persona.Telefono = textBox3.Text;
            persona.Ci = textBox4.Text;
            persona.Correo = textBox5.Text;

            bss.EditarPersonaBss(persona);
            MessageBox.Show("Datos actulizados");
        }

        
    }
 */