namespace puntodeventa2
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.txt_cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.Btn_editar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.text_id = new System.Windows.Forms.TextBox();
            this.text_producto = new System.Windows.Forms.TextBox();
            this.text_proveedor = new System.Windows.Forms.TextBox();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.text_cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cerrar
            // 
            this.txt_cerrar.Location = new System.Drawing.Point(707, 410);
            this.txt_cerrar.Name = "txt_cerrar";
            this.txt_cerrar.Size = new System.Drawing.Size(99, 41);
            this.txt_cerrar.TabIndex = 0;
            this.txt_cerrar.Text = "Cerrar";
            this.txt_cerrar.UseVisualStyleBackColor = true;
            this.txt_cerrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(121, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 275);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.Location = new System.Drawing.Point(29, 396);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(99, 37);
            this.Btn_agregar.TabIndex = 2;
            this.Btn_agregar.Text = "Agregar";
            this.Btn_agregar.UseVisualStyleBackColor = true;
            this.Btn_agregar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Btn_editar
            // 
            this.Btn_editar.Location = new System.Drawing.Point(198, 396);
            this.Btn_editar.Name = "Btn_editar";
            this.Btn_editar.Size = new System.Drawing.Size(94, 37);
            this.Btn_editar.TabIndex = 3;
            this.Btn_editar.Text = "Editar";
            this.Btn_editar.UseVisualStyleBackColor = true;
            this.Btn_editar.Click += new System.EventHandler(this.Btn_editar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.Location = new System.Drawing.Point(361, 396);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(100, 37);
            this.Btn_eliminar.TabIndex = 4;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = true;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(29, 342);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(100, 20);
            this.text_id.TabIndex = 6;
            // 
            // text_producto
            // 
            this.text_producto.Location = new System.Drawing.Point(192, 342);
            this.text_producto.Name = "text_producto";
            this.text_producto.Size = new System.Drawing.Size(100, 20);
            this.text_producto.TabIndex = 7;
            // 
            // text_proveedor
            // 
            this.text_proveedor.Location = new System.Drawing.Point(361, 342);
            this.text_proveedor.Name = "text_proveedor";
            this.text_proveedor.Size = new System.Drawing.Size(100, 20);
            this.text_proveedor.TabIndex = 8;
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(507, 342);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(100, 20);
            this.text_precio.TabIndex = 9;
            // 
            // text_cantidad
            // 
            this.text_cantidad.Location = new System.Drawing.Point(643, 342);
            this.text_cantidad.Name = "text_cantidad";
            this.text_cantidad.Size = new System.Drawing.Size(100, 20);
            this.text_cantidad.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Precio";
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 463);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_cantidad);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.text_proveedor);
            this.Controls.Add(this.text_producto);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_editar);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_cerrar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txt_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_agregar;
        private System.Windows.Forms.Button Btn_editar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.TextBox text_producto;
        private System.Windows.Forms.TextBox text_proveedor;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.TextBox text_cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}