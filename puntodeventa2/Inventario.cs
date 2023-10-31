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
    public partial class Inventario : Form
    {
        ConexionSQLN cn = new ConexionSQLN();
        public Inventario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultainvenDT();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cn.Agregar(text_id.Text, text_producto.Text, text_proveedor.Text, text_precio.Text, text_cantidad.Text);
            dataGridView1.DataSource = cn.ConsultainvenDT();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            cn.Editar(text_id.Text, text_producto.Text, text_proveedor.Text, text_precio.Text, text_cantidad.Text);
            dataGridView1.DataSource = cn.ConsultainvenDT();
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            cn.Eliminar(text_id.Text);
            dataGridView1.DataSource = cn.ConsultainvenDT();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
