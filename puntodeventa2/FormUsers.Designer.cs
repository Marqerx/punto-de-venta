namespace puntodeventa2
{
    partial class FormUsers
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
            this.text_nombre = new System.Windows.Forms.TextBox();
            this.text_apellidos = new System.Windows.Forms.TextBox();
            this.text_edad = new System.Windows.Forms.TextBox();
            this.text_telefono = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.text_contraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_nuevousuario = new System.Windows.Forms.Button();
            this.Btn_modificarusuario = new System.Windows.Forms.Button();
            this.Btn_eliminarusuario = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_nombre
            // 
            this.text_nombre.Location = new System.Drawing.Point(34, 358);
            this.text_nombre.Name = "text_nombre";
            this.text_nombre.Size = new System.Drawing.Size(100, 20);
            this.text_nombre.TabIndex = 0;
            // 
            // text_apellidos
            // 
            this.text_apellidos.Location = new System.Drawing.Point(171, 358);
            this.text_apellidos.Name = "text_apellidos";
            this.text_apellidos.Size = new System.Drawing.Size(100, 20);
            this.text_apellidos.TabIndex = 1;
            // 
            // text_edad
            // 
            this.text_edad.Location = new System.Drawing.Point(310, 358);
            this.text_edad.Name = "text_edad";
            this.text_edad.Size = new System.Drawing.Size(100, 20);
            this.text_edad.TabIndex = 2;
            this.text_edad.TextChanged += new System.EventHandler(this.text_edad_TextChanged);
            // 
            // text_telefono
            // 
            this.text_telefono.Location = new System.Drawing.Point(431, 358);
            this.text_telefono.Name = "text_telefono";
            this.text_telefono.Size = new System.Drawing.Size(100, 20);
            this.text_telefono.TabIndex = 3;
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(556, 358);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(100, 20);
            this.text_usuario.TabIndex = 4;
            this.text_usuario.TextChanged += new System.EventHandler(this.text_usuario_TextChanged);
            // 
            // text_contraseña
            // 
            this.text_contraseña.Location = new System.Drawing.Point(679, 358);
            this.text_contraseña.Name = "text_contraseña";
            this.text_contraseña.Size = new System.Drawing.Size(100, 20);
            this.text_contraseña.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codigo Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contraseña";
            // 
            // Btn_nuevousuario
            // 
            this.Btn_nuevousuario.Location = new System.Drawing.Point(34, 402);
            this.Btn_nuevousuario.Name = "Btn_nuevousuario";
            this.Btn_nuevousuario.Size = new System.Drawing.Size(100, 36);
            this.Btn_nuevousuario.TabIndex = 12;
            this.Btn_nuevousuario.Text = "Nuevo Usuario";
            this.Btn_nuevousuario.UseVisualStyleBackColor = true;
            this.Btn_nuevousuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_modificarusuario
            // 
            this.Btn_modificarusuario.Location = new System.Drawing.Point(171, 402);
            this.Btn_modificarusuario.Name = "Btn_modificarusuario";
            this.Btn_modificarusuario.Size = new System.Drawing.Size(100, 36);
            this.Btn_modificarusuario.TabIndex = 13;
            this.Btn_modificarusuario.Text = "Modificar Usuario";
            this.Btn_modificarusuario.UseVisualStyleBackColor = true;
            this.Btn_modificarusuario.Click += new System.EventHandler(this.Btn_modificarusuario_Click);
            // 
            // Btn_eliminarusuario
            // 
            this.Btn_eliminarusuario.Location = new System.Drawing.Point(310, 402);
            this.Btn_eliminarusuario.Name = "Btn_eliminarusuario";
            this.Btn_eliminarusuario.Size = new System.Drawing.Size(100, 36);
            this.Btn_eliminarusuario.TabIndex = 14;
            this.Btn_eliminarusuario.Text = "Eliminar Usuario";
            this.Btn_eliminarusuario.UseVisualStyleBackColor = true;
            this.Btn_eliminarusuario.Click += new System.EventHandler(this.Btn_eliminarusuario_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(679, 402);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(100, 36);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(767, 309);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.Btn_eliminarusuario);
            this.Controls.Add(this.Btn_modificarusuario);
            this.Controls.Add(this.Btn_nuevousuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_contraseña);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.text_telefono);
            this.Controls.Add(this.text_edad);
            this.Controls.Add(this.text_apellidos);
            this.Controls.Add(this.text_nombre);
            this.Name = "FormUsers";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_nombre;
        private System.Windows.Forms.TextBox text_apellidos;
        private System.Windows.Forms.TextBox text_edad;
        private System.Windows.Forms.TextBox text_telefono;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.TextBox text_contraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_nuevousuario;
        private System.Windows.Forms.Button Btn_modificarusuario;
        private System.Windows.Forms.Button Btn_eliminarusuario;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}