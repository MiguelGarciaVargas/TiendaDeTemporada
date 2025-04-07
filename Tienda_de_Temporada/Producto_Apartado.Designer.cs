namespace Tienda_de_Temporada
{
    partial class Producto_Apartado
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
            this.label_nombre = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.label_producto = new System.Windows.Forms.Label();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProdTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabla_prodApart = new System.Windows.Forms.DataGridView();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label_existencias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIdApartado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodApart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(33, 22);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 47;
            this.comboBox_pantallas.Text = "Producto - Apartado";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nombre.Location = new System.Drawing.Point(29, 172);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(98, 23);
            this.label_nombre.TabIndex = 48;
            this.label_nombre.Text = "Producto:";
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(256, 266);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 57;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.ForeColor = System.Drawing.Color.Navy;
            this.label_producto.Location = new System.Drawing.Point(232, 60);
            this.label_producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(334, 38);
            this.label_producto.TabIndex = 51;
            this.label_producto.Text = "Producto - Apartado";
            // 
            // combo_producto
            // 
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Location = new System.Drawing.Point(195, 172);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(292, 21);
            this.combo_producto.TabIndex = 52;
            this.combo_producto.Text = "Selecciona un producto";
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(33, 266);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 54;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // temporada
            // 
            this.temporada.FillWeight = 75F;
            this.temporada.HeaderText = "Temporada";
            this.temporada.Name = "temporada";
            // 
            // IdTemporada
            // 
            this.IdTemporada.FillWeight = 50F;
            this.IdTemporada.HeaderText = "IdTemporada";
            this.IdTemporada.Name = "IdTemporada";
            // 
            // producto
            // 
            this.producto.FillWeight = 75F;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // IdProducto
            // 
            this.IdProducto.FillWeight = 50F;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // IdProdTemp
            // 
            this.IdProdTemp.FillWeight = 20F;
            this.IdProdTemp.HeaderText = "Id";
            this.IdProdTemp.Name = "IdProdTemp";
            // 
            // tabla_prodApart
            // 
            this.tabla_prodApart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_prodApart.BackgroundColor = System.Drawing.Color.White;
            this.tabla_prodApart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_prodApart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProdTemp,
            this.IdProducto,
            this.producto,
            this.IdTemporada,
            this.temporada});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_prodApart.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_prodApart.Location = new System.Drawing.Point(33, 327);
            this.tabla_prodApart.Name = "tabla_prodApart";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_prodApart.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_prodApart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_prodApart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_prodApart.Size = new System.Drawing.Size(836, 210);
            this.tabla_prodApart.TabIndex = 55;
            this.tabla_prodApart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_apartado_CellClick);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(482, 266);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 56;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.BackColor = System.Drawing.Color.Lavender;
            this.textBox_cantidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cantidad.Location = new System.Drawing.Point(195, 212);
            this.textBox_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(292, 33);
            this.textBox_cantidad.TabIndex = 59;
            this.textBox_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_KeyPress);
            // 
            // label_existencias
            // 
            this.label_existencias.AutoSize = true;
            this.label_existencias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_existencias.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_existencias.Location = new System.Drawing.Point(29, 216);
            this.label_existencias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_existencias.Name = "label_existencias";
            this.label_existencias.Size = new System.Drawing.Size(104, 23);
            this.label_existencias.TabIndex = 58;
            this.label_existencias.Text = "Cantidad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(29, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Apartado:";
            // 
            // lblIdApartado
            // 
            this.lblIdApartado.AutoSize = true;
            this.lblIdApartado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdApartado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdApartado.Location = new System.Drawing.Point(191, 122);
            this.lblIdApartado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdApartado.Name = "lblIdApartado";
            this.lblIdApartado.Size = new System.Drawing.Size(0, 23);
            this.lblIdApartado.TabIndex = 61;
            // 
            // Producto_Apartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 563);
            this.Controls.Add(this.lblIdApartado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.label_existencias);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_prodApart);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.combo_producto);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.comboBox_pantallas);
            this.Name = "Producto_Apartado";
            this.Text = "Producto_Apartado";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodApart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdTemp;
        private System.Windows.Forms.DataGridView tabla_prodApart;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label_existencias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdApartado;
    }
}