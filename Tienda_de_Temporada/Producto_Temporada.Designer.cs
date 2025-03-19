namespace Tienda_de_Temporada
{
    partial class Producto_Temporada
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
            this.label_producto = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.combo_producto = new System.Windows.Forms.ComboBox();
            this.combo_temporada = new System.Windows.Forms.ComboBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.tabla_prodTemp = new System.Windows.Forms.DataGridView();
            this.button_agregar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IdProdTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto",
            "Producto-Temporada"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(19, 12);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 32;
            this.comboBox_pantallas.Text = "Producto-Temporada";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.ForeColor = System.Drawing.Color.Navy;
            this.label_producto.Location = new System.Drawing.Point(218, 50);
            this.label_producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(372, 38);
            this.label_producto.TabIndex = 40;
            this.label_producto.Text = "Producto - Temporada ";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_precio.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_precio.Location = new System.Drawing.Point(15, 176);
            this.label_precio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(123, 23);
            this.label_precio.TabIndex = 34;
            this.label_precio.Text = "Temporada:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nombre.Location = new System.Drawing.Point(15, 136);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(98, 23);
            this.label_nombre.TabIndex = 33;
            this.label_nombre.Text = "Producto:";
            // 
            // combo_producto
            // 
            this.combo_producto.FormattingEnabled = true;
            this.combo_producto.Location = new System.Drawing.Point(181, 136);
            this.combo_producto.Name = "combo_producto";
            this.combo_producto.Size = new System.Drawing.Size(192, 21);
            this.combo_producto.TabIndex = 41;
            this.combo_producto.Text = "Selecciona un producto";
            // 
            // combo_temporada
            // 
            this.combo_temporada.FormattingEnabled = true;
            this.combo_temporada.Location = new System.Drawing.Point(181, 178);
            this.combo_temporada.Name = "combo_temporada";
            this.combo_temporada.Size = new System.Drawing.Size(192, 21);
            this.combo_temporada.TabIndex = 42;
            this.combo_temporada.Text = "Selecciona una temporada";
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(235, 255);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 46;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(461, 255);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 45;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // tabla_prodTemp
            // 
            this.tabla_prodTemp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_prodTemp.BackgroundColor = System.Drawing.Color.White;
            this.tabla_prodTemp.CausesValidation = false;
            this.tabla_prodTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_prodTemp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tabla_prodTemp.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_prodTemp.Location = new System.Drawing.Point(12, 316);
            this.tabla_prodTemp.Name = "tabla_prodTemp";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_prodTemp.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_prodTemp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_prodTemp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_prodTemp.Size = new System.Drawing.Size(836, 210);
            this.tabla_prodTemp.TabIndex = 44;
            this.tabla_prodTemp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_prodTemp_CellClick);
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(12, 255);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 43;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_de_Temporada.Properties.Resources.img_productos;
            this.pictureBox1.Location = new System.Drawing.Point(689, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // IdProdTemp
            // 
            this.IdProdTemp.FillWeight = 27.41117F;
            this.IdProdTemp.HeaderText = "Id";
            this.IdProdTemp.MinimumWidth = 100;
            this.IdProdTemp.Name = "IdProdTemp";
            // 
            // IdProducto
            // 
            this.IdProducto.FillWeight = 0.6678971F;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // producto
            // 
            this.producto.FillWeight = 23.05247F;
            this.producto.HeaderText = "Producto";
            this.producto.MinimumWidth = 300;
            this.producto.Name = "producto";
            // 
            // IdTemporada
            // 
            this.IdTemporada.FillWeight = 0.6678971F;
            this.IdTemporada.HeaderText = "IdTemporada";
            this.IdTemporada.Name = "IdTemporada";
            // 
            // temporada
            // 
            this.temporada.FillWeight = 218.2005F;
            this.temporada.HeaderText = "Temporada";
            this.temporada.MinimumWidth = 350;
            this.temporada.Name = "temporada";
            // 
            // Producto_Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 561);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_prodTemp);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.combo_temporada);
            this.Controls.Add(this.combo_producto);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.comboBox_pantallas);
            this.Name = "Producto_Temporada";
            this.Text = "Producto_Temporada";
            this.Load += new System.EventHandler(this.Producto_Temporada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.ComboBox combo_producto;
        private System.Windows.Forms.ComboBox combo_temporada;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView tabla_prodTemp;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
    }
}