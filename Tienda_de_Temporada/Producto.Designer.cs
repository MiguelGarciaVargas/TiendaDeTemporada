namespace Tienda_de_Temporada
{
    partial class Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_pantallas = new System.Windows.Forms.ComboBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.tabla_producto = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label_producto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.textBox_existencias = new System.Windows.Forms.TextBox();
            this.label_existencias = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(31, 12);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 31;
            this.comboBox_pantallas.Text = "Producto";
            this.comboBox_pantallas.SelectedIndexChanged += new System.EventHandler(this.comboBox_pantallas_SelectedIndexChanged);
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(254, 269);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 30;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(480, 269);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 29;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // tabla_producto
            // 
            this.tabla_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_producto.BackgroundColor = System.Drawing.Color.White;
            this.tabla_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.precio,
            this.existencias});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_producto.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_producto.Location = new System.Drawing.Point(31, 330);
            this.tabla_producto.Name = "tabla_producto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_producto.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_producto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_producto.Size = new System.Drawing.Size(836, 210);
            this.tabla_producto.TabIndex = 28;
            this.tabla_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_producto_CellClick);
            // 
            // id
            // 
            this.id.FillWeight = 20F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // precio
            // 
            this.precio.FillWeight = 50F;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // existencias
            // 
            this.existencias.FillWeight = 50F;
            this.existencias.HeaderText = "Existencias";
            this.existencias.Name = "existencias";
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(31, 269);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 27;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.ForeColor = System.Drawing.Color.Navy;
            this.label_producto.Location = new System.Drawing.Point(308, 56);
            this.label_producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(155, 38);
            this.label_producto.TabIndex = 26;
            this.label_producto.Text = "Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_de_Temporada.Properties.Resources.img_productos;
            this.pictureBox1.Location = new System.Drawing.Point(708, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_precio
            // 
            this.textBox_precio.BackColor = System.Drawing.Color.Lavender;
            this.textBox_precio.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_precio.Location = new System.Drawing.Point(150, 145);
            this.textBox_precio.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.Size = new System.Drawing.Size(292, 33);
            this.textBox_precio.TabIndex = 24;
            // 
            // textBox_existencias
            // 
            this.textBox_existencias.BackColor = System.Drawing.Color.Lavender;
            this.textBox_existencias.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_existencias.Location = new System.Drawing.Point(150, 182);
            this.textBox_existencias.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_existencias.Name = "textBox_existencias";
            this.textBox_existencias.Size = new System.Drawing.Size(292, 33);
            this.textBox_existencias.TabIndex = 23;
            // 
            // label_existencias
            // 
            this.label_existencias.AutoSize = true;
            this.label_existencias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_existencias.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_existencias.Location = new System.Drawing.Point(28, 186);
            this.label_existencias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_existencias.Name = "label_existencias";
            this.label_existencias.Size = new System.Drawing.Size(116, 23);
            this.label_existencias.TabIndex = 21;
            this.label_existencias.Text = "Existencias:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.Lavender;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(150, 108);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(518, 33);
            this.textBox_nombre.TabIndex = 20;
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_precio.Location = new System.Drawing.Point(27, 149);
            this.label_precio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(73, 23);
            this.label_precio.TabIndex = 19;
            this.label_precio.Text = "Precio:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nombre.Location = new System.Drawing.Point(28, 112);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(90, 23);
            this.label_nombre.TabIndex = 17;
            this.label_nombre.Text = "Nombre:";
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 552);
            this.Controls.Add(this.comboBox_pantallas);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_producto);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_precio);
            this.Controls.Add(this.textBox_existencias);
            this.Controls.Add(this.label_existencias);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Producto";
            this.Text = "Producto";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView tabla_producto;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.TextBox textBox_existencias;
        private System.Windows.Forms.Label label_existencias;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
    }
}