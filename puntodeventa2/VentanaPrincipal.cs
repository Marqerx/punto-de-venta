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
    public partial class VentanaPrincipal : Form
    {
        private DataTable dt;
        ConexionSQLN cn = new ConexionSQLN();
        public VentanaPrincipal()
        {
            InitializeComponent();
            text_imventa_edit.Text = txt_Impues_edit.Text;
            text_descu_edit.Text = txt_descuen_edit.Text;

            dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio x Unidad");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio total");

            dataGridView1.DataSource = dt;

            text_factura.Text = cn.consultaFactura();



        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Inventario v1 = new Inventario();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_Archivo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void ImpVentayDescuentoChange(object sender, EventArgs e)
        {

            text_imventa_edit.Text = txt_Impues_edit.Text;
           text_descu_edit.Text = txt_descuen_edit.Text;
        }

        private void txt_descuen_edit_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_agregar_producto_Click(object sender, EventArgs e)
        {
            DataRow row = dt.NewRow();
            
            
            row["Codigo"] = txt_codigo_producto.Text;
            row["Producto"] = "Producto x";
            row["Precio x Unidad"] = " 3500";
            row["Cantidad"] = txt_cantidad.Text;
            row["Descuento"] = text_descu_edit.Text;
            row["Precio total"] = "500";

            dt.Rows.Add(row);



        }

        private void txt_codigo_producto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_descu_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_factura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_Codigo_Cliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_buscar1_Click(object sender, EventArgs e)
        {

        }

        private void text_imventa_edit_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_descu_edit_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_facturar_Click(object sender, EventArgs e)
        {

        }
    }
}
