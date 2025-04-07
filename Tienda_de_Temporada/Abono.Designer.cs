namespace Tienda_de_Temporada
{
    partial class Abono
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIdApartado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_cantidad = new System.Windows.Forms.TextBox();
            this.label_existencias = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.tabla_prodApart = new System.Windows.Forms.DataGridView();
            this.IdProdTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label_producto = new System.Windows.Forms.Label();
            this.comboBox_pantallas = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodApart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdApartado
            // 
            this.lblIdApartado.AutoSize = true;
            this.lblIdApartado.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdApartado.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdApartado.Location = new System.Drawing.Point(181, 116);
            this.lblIdApartado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIdApartado.Name = "lblIdApartado";
            this.lblIdApartado.Size = new System.Drawing.Size(0, 23);
            this.lblIdApartado.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(19, 116);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 72;
            this.label1.Text = "Apartado:";
            // 
            // textBox_cantidad
            // 
            this.textBox_cantidad.BackColor = System.Drawing.Color.Lavender;
            this.textBox_cantidad.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_cantidad.Location = new System.Drawing.Point(186, 164);
            this.textBox_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_cantidad.Name = "textBox_cantidad";
            this.textBox_cantidad.Size = new System.Drawing.Size(292, 33);
            this.textBox_cantidad.TabIndex = 71;
            // 
            // label_existencias
            // 
            this.label_existencias.AutoSize = true;
            this.label_existencias.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_existencias.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_existencias.Location = new System.Drawing.Point(20, 168);
            this.label_existencias.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_existencias.Name = "label_existencias";
            this.label_existencias.Size = new System.Drawing.Size(104, 23);
            this.label_existencias.TabIndex = 70;
            this.label_existencias.Text = "Cantidad:";
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(246, 222);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 69;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_prodApart.DefaultCellStyle = dataGridViewCellStyle5;
            this.tabla_prodApart.Location = new System.Drawing.Point(23, 283);
            this.tabla_prodApart.Name = "tabla_prodApart";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_prodApart.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tabla_prodApart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_prodApart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_prodApart.Size = new System.Drawing.Size(836, 210);
            this.tabla_prodApart.TabIndex = 67;
            // 
            // IdProdTemp
            // 
            this.IdProdTemp.FillWeight = 20F;
            this.IdProdTemp.HeaderText = "Id";
            this.IdProdTemp.Name = "IdProdTemp";
            // 
            // IdProducto
            // 
            this.IdProducto.FillWeight = 50F;
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            // 
            // producto
            // 
            this.producto.FillWeight = 75F;
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // IdTemporada
            // 
            this.IdTemporada.FillWeight = 50F;
            this.IdTemporada.HeaderText = "IdTemporada";
            this.IdTemporada.Name = "IdTemporada";
            // 
            // temporada
            // 
            this.temporada.FillWeight = 75F;
            this.temporada.HeaderText = "Temporada";
            this.temporada.Name = "temporada";
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(23, 222);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 66;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.ForeColor = System.Drawing.Color.Navy;
            this.label_producto.Location = new System.Drawing.Point(239, 62);
            this.label_producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(121, 38);
            this.label_producto.TabIndex = 64;
            this.label_producto.Text = "Abono";
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(23, 16);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 62;
            this.comboBox_pantallas.Text = "Producto - Apartado";
            // 
            // Abono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 546);
            this.Controls.Add(this.lblIdApartado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cantidad);
            this.Controls.Add(this.label_existencias);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.tabla_prodApart);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.comboBox_pantallas);
            this.Name = "Abono";
            this.Text = "Abono";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_prodApart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdApartado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cantidad;
        private System.Windows.Forms.Label label_existencias;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.DataGridView tabla_prodApart;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.ComboBox comboBox_pantallas;
    }
}