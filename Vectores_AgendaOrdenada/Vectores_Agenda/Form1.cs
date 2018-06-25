using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores_Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string apellidop = txtApellidoPaterno.Text;
            string apellidom = txtApellidoMaterno.Text;
            int edad = Convert.ToInt16(txtEdad.Text);
            string email = txtEmail.Text;
            int telefono = Convert.ToInt32(txtTelefono.Text);
            int codigo = Convert.ToInt32(txtCodigo.Text);

           // if (agenda._position < 15)
            
                agenda.Agregar(new Contacto(nombre, apellidop, apellidom, edad, email, telefono, codigo));
            

            MessageBox.Show("¡Se agregó el registro con éxito!", "aviso", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //agenda.Eliminar();

            MessageBox.Show("El registro se eliminó de la agenda");

            txtResultados.Text = agenda.Listar();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultados.Text = agenda.Listar();

            txtNombre.Clear();
            txtApellidoPaterno.Clear();
            txtApellidoMaterno.Clear();
            txtEdad.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtResultados.Text = agenda.Buscar(Convert.ToInt32(txtTelefono.Text)).ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if(agenda._position < agenda.book.Length)
            {
                string nombre = txtNombre.Text;
                string apellidop = txtApellidoPaterno.Text;
                string apellidom = txtApellidoMaterno.Text;
                int edad = Convert.ToInt16(txtEdad.Text);
                string email = txtEmail.Text;
                int telefono = Convert.ToInt32(txtTelefono.Text);
                int codigo = Convert.ToInt32(txtCodigo.Text);

                
            }

            MessageBox.Show("Se insertó el contacto con éxito");
        }

    }
}
