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
    public partial class FormUsers : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //(nom, apel, edad, tel, user, pass);
            cn.InsertarUsuario(text_nombre.Text, text_apellidos.Text, text_edad.Text, text_telefono.Text, text_usuario.Text, text_contraseña.Text);
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void Btn_modificarusuario_Click(object sender, EventArgs e)
        {

            cn.ModificarUsuario(text_nombre.Text, text_apellidos.Text, text_edad.Text, text_telefono.Text, text_usuario.Text, text_contraseña.Text);
            dataGridView1.DataSource = cn.ConsultaDT();

        }

        private void Btn_eliminarusuario_Click(object sender, EventArgs e)
        {
            cn.EliminarUsuario(text_edad.Text);
            dataGridView1.DataSource  = cn.ConsultaDT();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void text_edad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void text_usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
