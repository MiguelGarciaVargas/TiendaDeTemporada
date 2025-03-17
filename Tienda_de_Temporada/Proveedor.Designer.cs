namespace Tienda_de_Temporada
{
    partial class Proveedor
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
            this.tabla_proveedor = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label_proveedor = new System.Windows.Forms.Label();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_correo = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label_correo = new System.Windows.Forms.Label();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label_telefono = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto",
            "Temporada"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(31, 12);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 31;
            this.comboBox_pantallas.Text = "Proveedor";
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
            // tabla_proveedor
            // 
            this.tabla_proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_proveedor.BackgroundColor = System.Drawing.Color.White;
            this.tabla_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.direccion,
            this.correo,
            this.telefono});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_proveedor.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_proveedor.Location = new System.Drawing.Point(31, 330);
            this.tabla_proveedor.Name = "tabla_proveedor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_proveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_proveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_proveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_proveedor.Size = new System.Drawing.Size(836, 210);
            this.tabla_proveedor.TabIndex = 28;
            this.tabla_proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_proveedor_CellClick);
            // 
            // id
            // 
            this.id.FillWeight = 30F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // telefono
            // 
            this.telefono.FillWeight = 70F;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
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
            // label_proveedor
            // 
            this.label_proveedor.AutoSize = true;
            this.label_proveedor.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proveedor.ForeColor = System.Drawing.Color.Navy;
            this.label_proveedor.Location = new System.Drawing.Point(308, 56);
            this.label_proveedor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_proveedor.Name = "label_proveedor";
            this.label_proveedor.Size = new System.Drawing.Size(174, 38);
            this.label_proveedor.TabIndex = 26;
            this.label_proveedor.Text = "Proveedor";
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.Color.Lavender;
            this.textBox_direccion.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion.Location = new System.Drawing.Point(143, 145);
            this.textBox_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(518, 33);
            this.textBox_direccion.TabIndex = 24;
            // 
            // textBox_correo
            // 
            this.textBox_correo.BackColor = System.Drawing.Color.Lavender;
            this.textBox_correo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_correo.Location = new System.Drawing.Point(143, 182);
            this.textBox_correo.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_correo.Name = "textBox_correo";
            this.textBox_correo.Size = new System.Drawing.Size(518, 33);
            this.textBox_correo.TabIndex = 23;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.Color.Lavender;
            this.textBox_telefono.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(143, 219);
            this.textBox_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(518, 33);
            this.textBox_telefono.TabIndex = 22;
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_correo.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_correo.Location = new System.Drawing.Point(28, 186);
            this.label_correo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(78, 23);
            this.label_correo.TabIndex = 21;
            this.label_correo.Text = "Correo:";
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.Lavender;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(143, 108);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(518, 33);
            this.textBox_nombre.TabIndex = 20;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_direccion.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_direccion.Location = new System.Drawing.Point(27, 149);
            this.label_direccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(103, 23);
            this.label_direccion.TabIndex = 19;
            this.label_direccion.Text = "Dirección:";
            // 
            // label_telefono
            // 
            this.label_telefono.AutoSize = true;
            this.label_telefono.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefono.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_telefono.Location = new System.Drawing.Point(28, 223);
            this.label_telefono.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_telefono.Name = "label_telefono";
            this.label_telefono.Size = new System.Drawing.Size(92, 23);
            this.label_telefono.TabIndex = 18;
            this.label_telefono.Text = "Teléfono:";
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_de_Temporada.Properties.Resources.img_proveedor;
            this.pictureBox1.Location = new System.Drawing.Point(708, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 552);
            this.Controls.Add(this.comboBox_pantallas);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_proveedor);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_proveedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_correo);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.label_correo);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.label_telefono);
            this.Controls.Add(this.label_nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Proveedor";
            this.Text = "Proveedor";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView tabla_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label_proveedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_correo;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label_telefono;
        private System.Windows.Forms.Label label_nombre;
    }
}