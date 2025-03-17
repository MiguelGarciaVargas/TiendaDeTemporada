namespace Tienda_de_Temporada
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_correo = new System.Windows.Forms.Label();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label_cliente = new System.Windows.Forms.Label();
            this.button_agregar = new System.Windows.Forms.Button();
            this.tabla_cliente = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.comboBox_pantallas = new System.Windows.Forms.ComboBox();
            this.button_borrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nombre.Location = new System.Drawing.Point(25, 112);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(90, 23);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_telefono.Location = new System.Drawing.Point(25, 223);
            this.label_telefono.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(92, 23);
            this.label_telefono.TabIndex = 1;
            this.label_telefono.Text = "Teléfono:";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_direccion.Location = new System.Drawing.Point(24, 149);
            this.label_direccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(103, 23);
            this.label_direccion.TabIndex = 2;
            this.label_direccion.Text = "Dirección:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.Lavender;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(140, 108);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(518, 33);
            this.textBox_nombre.TabIndex = 3;
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correo.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_correo.Location = new System.Drawing.Point(25, 186);
            this.label_correo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(78, 23);
            this.label_correo.TabIndex = 4;
            this.label_correo.Text = "Correo:";
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.Color.Lavender;
            this.textBox_telefono.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(140, 219);
            this.textBox_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(518, 33);
            this.textBox_telefono.TabIndex = 5;
            // 
            // textBox_correo
            // 
            this.textBox_correo.BackColor = System.Drawing.Color.Lavender;
            this.textBox_correo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_correo.Location = new System.Drawing.Point(140, 182);
            this.textBox_correo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(518, 33);
            this.textBox_correo.TabIndex = 6;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.Color.Lavender;
            this.textBox_direccion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion.Location = new System.Drawing.Point(140, 145);
            this.textBox_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(518, 33);
            this.textBox_direccion.TabIndex = 7;
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cliente.ForeColor = System.Drawing.Color.Navy;
            this.label_cliente.Location = new System.Drawing.Point(305, 56);
            this.label_cliente.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(127, 38);
            this.label_cliente.TabIndex = 9;
            this.label_cliente.Text = "Cliente";
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(28, 269);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 11;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // tabla_cliente
            // 
            this.tabla_cliente.AllowUserToAddRows = false;
            this.tabla_cliente.AllowUserToDeleteRows = false;
            this.tabla_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tabla_cliente.BackgroundColor = System.Drawing.Color.White;
            this.tabla_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.direccion,
            this.correo,
            this.telefono});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_cliente.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_cliente.Location = new System.Drawing.Point(28, 330);
            this.tabla_cliente.Name = "tabla_cliente";
            this.tabla_cliente.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_cliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_cliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_cliente.Size = new System.Drawing.Size(876, 210);
            this.tabla_cliente.TabIndex = 12;
            this.tabla_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_cliente_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.Frozen = true;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 60;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 210;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.direccion.Frozen = true;
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 230;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.correo.Frozen = true;
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 210;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.telefono.Frozen = true;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 150;
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(477, 269);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 13;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(251, 269);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 14;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto",
            "Temporada",
            "Proveedor",
            "Producto-Temporada"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(28, 12);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 16;
            this.comboBox_pantallas.Text = "Cliente";
            this.comboBox_pantallas.SelectedIndexChanged += new System.EventHandler(this.comboBox_pantallas_SelectedIndexChanged);
            // 
            // button_borrar
            // 
            this.button_borrar.BackColor = System.Drawing.Color.White;
            this.button_borrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar.ForeColor = System.Drawing.Color.White;
            this.button_borrar.Image = global::Tienda_de_Temporada.Properties.Resources.img_borrador;
            this.button_borrar.Location = new System.Drawing.Point(758, 269);
            this.button_borrar.Margin = new System.Windows.Forms.Padding(2);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(50, 47);
            this.button_borrar.TabIndex = 17;
            this.button_borrar.UseVisualStyleBackColor = false;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_de_Temporada.Properties.Resources.img_cliente;
            this.pictureBox1.Location = new System.Drawing.Point(705, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 552);
            this.Controls.Add(this.button_borrar);
            this.Controls.Add(this.comboBox_pantallas);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_cliente);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_correo);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label_correo);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.DataGridView tabla_cliente;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}

