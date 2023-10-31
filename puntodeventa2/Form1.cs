using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace puntodeventa2
{
   
    public partial class Form1 : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {

            if (cn.conSQL(txt_Usuario.Text,txt_Contaseña.Text) == 1)
            {

                MessageBox.Show("El Usuario a sido encontrado");


                this.Hide();
                VentanaPrincipal v1 = new VentanaPrincipal();
                v1.Show();

            }
            else
            {
                MessageBox.Show("El Usuario no hs sido encontrado");
            }


        }
    }
}
