using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario == "" || password == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            D_Usuario servicio = new D_Usuario();

            

            MessageBox.Show("Usuario registrado correctamente");

            txtUsuario.Clear();
            txtPassword.Clear();
        }
    }
}

