namespace puntodeventa2
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_menu_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Impues_edit = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_descuen_edit = new System.Windows.Forms.ToolStripTextBox();
            this.btn_menu_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_codigo_producto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_agregar_producto = new System.Windows.Forms.Button();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.text_factura = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.text_Codigo_Cliente = new System.Windows.Forms.TextBox();
            this.btn_buscar1 = new System.Windows.Forms.Button();
            this.text_imventa_edit = new System.Windows.Forms.TextBox();
            this.text_descu_edit = new System.Windows.Forms.TextBox();
            this.Btn_facturar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(688, 415);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 23);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_menu_Archivo,
            this.btn_menu_Usuarios,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_menu_Archivo
            // 
            this.btn_menu_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.btn_menu_Archivo.Name = "btn_menu_Archivo";
            this.btn_menu_Archivo.Size = new System.Drawing.Size(60, 20);
            this.btn_menu_Archivo.Text = "Archivo";
            this.btn_menu_Archivo.Click += new System.EventHandler(this.btn_menu_Archivo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 22);
            this.toolStripMenuItem2.Text = "Impuesto y Descuento";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_Impues_edit});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem6.Text = "Impuesto";
            // 
            // txt_Impues_edit
            // 
            this.txt_Impues_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Impues_edit.Name = "txt_Impues_edit";
            this.txt_Impues_edit.Size = new System.Drawing.Size(100, 23);
            this.txt_Impues_edit.Text = "10";
            this.txt_Impues_edit.TextChanged += new System.EventHandler(this.ImpVentayDescuentoChange);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_descuen_edit});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem7.Text = "Descuento";
            // 
            // txt_descuen_edit
            // 
            this.txt_descuen_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_descuen_edit.Name = "txt_descuen_edit";
            this.txt_descuen_edit.Size = new System.Drawing.Size(100, 23);
            this.txt_descuen_edit.Text = "0";
            this.txt_descuen_edit.Click += new System.EventHandler(this.txt_descuen_edit_Click);
            // 
            // btn_menu_Usuarios
            // 
            this.btn_menu_Usuarios.Name = "btn_menu_Usuarios";
            this.btn_menu_Usuarios.Size = new System.Drawing.Size(64, 20);
            this.btn_menu_Usuarios.Text = "Usuarios";
            this.btn_menu_Usuarios.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem1.Text = "Inventario";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem3.Text = "Reportes";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(181, 22);
            this.toolStripMenuItem4.Text = "HIstorial de Facturas";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem5.Text = "Clientes";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::puntodeventa2.Properties.Resources.pngtree_the_online_shop_logo_uses_a_colorful_house_concept_png_image_3096020;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txt_codigo_producto
            // 
            this.txt_codigo_producto.Location = new System.Drawing.Point(452, 314);
            this.txt_codigo_producto.Name = "txt_codigo_producto";
            this.txt_codigo_producto.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo_producto.TabIndex = 3;
            this.txt_codigo_producto.TextChanged += new System.EventHandler(this.txt_codigo_producto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo de Producto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(177, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(612, 241);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(222, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0.00";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descuento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cantidad";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 308);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Imp de Venta";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(217, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Numero de Factura";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Codigo Cliente";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Cliente";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Btn_agregar_producto
            // 
            this.Btn_agregar_producto.Location = new System.Drawing.Point(450, 350);
            this.Btn_agregar_producto.Name = "Btn_agregar_producto";
            this.Btn_agregar_producto.Size = new System.Drawing.Size(207, 41);
            this.Btn_agregar_producto.TabIndex = 25;
            this.Btn_agregar_producto.Text = "Agregar Producto";
            this.Btn_agregar_producto.UseVisualStyleBackColor = true;
            this.Btn_agregar_producto.Click += new System.EventHandler(this.Btn_agregar_producto_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(557, 314);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidad.TabIndex = 26;
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_cantidad_TextChanged);
            // 
            // text_factura
            // 
            this.text_factura.Location = new System.Drawing.Point(321, 20);
            this.text_factura.Name = "text_factura";
            this.text_factura.ReadOnly = true;
            this.text_factura.Size = new System.Drawing.Size(100, 20);
            this.text_factura.TabIndex = 27;
            this.text_factura.TextChanged += new System.EventHandler(this.text_factura_TextChanged);
            // 
            // txt_cliente
            // 
            this.txt_cliente.Location = new System.Drawing.Point(558, 20);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.ReadOnly = true;
            this.txt_cliente.Size = new System.Drawing.Size(231, 20);
            this.txt_cliente.TabIndex = 28;
            this.txt_cliente.TextChanged += new System.EventHandler(this.txt_cliente_TextChanged);
            // 
            // text_Codigo_Cliente
            // 
            this.text_Codigo_Cliente.Location = new System.Drawing.Point(12, 212);
            this.text_Codigo_Cliente.Name = "text_Codigo_Cliente";
            this.text_Codigo_Cliente.ReadOnly = true;
            this.text_Codigo_Cliente.Size = new System.Drawing.Size(100, 20);
            this.text_Codigo_Cliente.TabIndex = 29;
            this.text_Codigo_Cliente.TextChanged += new System.EventHandler(this.text_Codigo_Cliente_TextChanged);
            // 
            // btn_buscar1
            // 
            this.btn_buscar1.Location = new System.Drawing.Point(12, 238);
            this.btn_buscar1.Name = "btn_buscar1";
            this.btn_buscar1.Size = new System.Drawing.Size(80, 26);
            this.btn_buscar1.TabIndex = 30;
            this.btn_buscar1.Text = "Buscar";
            this.btn_buscar1.UseVisualStyleBackColor = true;
            this.btn_buscar1.Click += new System.EventHandler(this.btn_buscar1_Click);
            // 
            // text_imventa_edit
            // 
            this.text_imventa_edit.Location = new System.Drawing.Point(281, 308);
            this.text_imventa_edit.Name = "text_imventa_edit";
            this.text_imventa_edit.ReadOnly = true;
            this.text_imventa_edit.Size = new System.Drawing.Size(100, 20);
            this.text_imventa_edit.TabIndex = 31;
            this.text_imventa_edit.TextChanged += new System.EventHandler(this.text_imventa_edit_TextChanged);
            // 
            // text_descu_edit
            // 
            this.text_descu_edit.Location = new System.Drawing.Point(281, 338);
            this.text_descu_edit.Name = "text_descu_edit";
            this.text_descu_edit.ReadOnly = true;
            this.text_descu_edit.Size = new System.Drawing.Size(100, 20);
            this.text_descu_edit.TabIndex = 32;
            this.text_descu_edit.TextChanged += new System.EventHandler(this.text_descu_edit_TextChanged_1);
            // 
            // Btn_facturar
            // 
            this.Btn_facturar.Location = new System.Drawing.Point(687, 350);
            this.Btn_facturar.Name = "Btn_facturar";
            this.Btn_facturar.Size = new System.Drawing.Size(101, 41);
            this.Btn_facturar.TabIndex = 33;
            this.Btn_facturar.Text = "Facturar";
            this.Btn_facturar.UseVisualStyleBackColor = true;
            this.Btn_facturar.Click += new System.EventHandler(this.Btn_facturar_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 467);
            this.Controls.Add(this.Btn_facturar);
            this.Controls.Add(this.text_descu_edit);
            this.Controls.Add(this.text_imventa_edit);
            this.Controls.Add(this.btn_buscar1);
            this.Controls.Add(this.text_Codigo_Cliente);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.text_factura);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.Btn_agregar_producto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_codigo_producto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Archivo;
        private System.Windows.Forms.ToolStripMenuItem btn_menu_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo_producto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripTextBox txt_Impues_edit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripTextBox txt_descuen_edit;
        private System.Windows.Forms.Button Btn_agregar_producto;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.TextBox text_factura;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox text_Codigo_Cliente;
        private System.Windows.Forms.Button btn_buscar1;
        private System.Windows.Forms.TextBox text_imventa_edit;
        private System.Windows.Forms.TextBox text_descu_edit;
        private System.Windows.Forms.Button Btn_facturar;
    }
}