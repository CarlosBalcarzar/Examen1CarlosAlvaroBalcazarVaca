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
    public partial class PersonaIngresarVista : Form
    {
        public PersonaIngresarVista()
        {
            InitializeComponent();
        }
        PersonaBss bss = new PersonaBss();
        private void button1_Click(object sender, EventArgs e)
        {

            Persona persona = new Persona();
            persona.NOMBRE = textBox1.Text;
            persona.APELLIDO = textBox2.Text;
            bss.InsertarPersonaBss(persona);
            MessageBox.Show("Se guardo correctamente la persona");

        }
    }
}
