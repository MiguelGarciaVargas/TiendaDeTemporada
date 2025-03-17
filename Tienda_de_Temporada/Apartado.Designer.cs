﻿namespace Tienda_de_Temporada
{
    partial class Apartado
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
            this.tabla_apartado = new System.Windows.Forms.DataGridView();
            this.IdProdTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTemporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temporada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_tarjetas = new System.Windows.Forms.ComboBox();
            this.label_producto = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.comboBox_pantallas = new System.Windows.Forms.ComboBox();
            this.calendar_fecha_fin = new System.Windows.Forms.MonthCalendar();
            this.calendar_fecha_inicio = new System.Windows.Forms.MonthCalendar();
            this.label_fecha_inicio = new System.Windows.Forms.Label();
            this.label_fecha_fin = new System.Windows.Forms.Label();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_agregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_apartado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_apartado
            // 
            this.tabla_apartado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_apartado.BackgroundColor = System.Drawing.Color.White;
            this.tabla_apartado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_apartado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.tabla_apartado.DefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_apartado.Location = new System.Drawing.Point(17, 420);
            this.tabla_apartado.Name = "tabla_apartado";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_apartado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_apartado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_apartado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_apartado.Size = new System.Drawing.Size(836, 210);
            this.tabla_apartado.TabIndex = 55;
            this.tabla_apartado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_apartado_CellClick);
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
            // combo_tarjetas
            // 
            this.combo_tarjetas.FormattingEnabled = true;
            this.combo_tarjetas.Location = new System.Drawing.Point(124, 115);
            this.combo_tarjetas.Name = "combo_tarjetas";
            this.combo_tarjetas.Size = new System.Drawing.Size(192, 21);
            this.combo_tarjetas.TabIndex = 52;
            this.combo_tarjetas.Text = "Selecciona una tarjeta";
            // 
            // label_producto
            // 
            this.label_producto.AutoSize = true;
            this.label_producto.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_producto.ForeColor = System.Drawing.Color.Navy;
            this.label_producto.Location = new System.Drawing.Point(218, 63);
            this.label_producto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_producto.Name = "label_producto";
            this.label_producto.Size = new System.Drawing.Size(165, 38);
            this.label_producto.TabIndex = 51;
            this.label_producto.Text = "Apartado";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_nombre.Location = new System.Drawing.Point(15, 115);
            this.label_nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(78, 23);
            this.label_nombre.TabIndex = 48;
            this.label_nombre.Text = "Tarjeta:";
            // 
            // comboBox_pantallas
            // 
            this.comboBox_pantallas.BackColor = System.Drawing.Color.White;
            this.comboBox_pantallas.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.comboBox_pantallas.FormattingEnabled = true;
            this.comboBox_pantallas.Items.AddRange(new object[] {
            "Cliente",
            "Producto"});
            this.comboBox_pantallas.Location = new System.Drawing.Point(19, 25);
            this.comboBox_pantallas.Name = "comboBox_pantallas";
            this.comboBox_pantallas.Size = new System.Drawing.Size(246, 30);
            this.comboBox_pantallas.TabIndex = 47;
            this.comboBox_pantallas.Text = "Apartado";
            // 
            // calendar_fecha_fin
            // 
            this.calendar_fecha_fin.Location = new System.Drawing.Point(361, 190);
            this.calendar_fecha_fin.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.calendar_fecha_fin.Name = "calendar_fecha_fin";
            this.calendar_fecha_fin.TabIndex = 62;
            // 
            // calendar_fecha_inicio
            // 
            this.calendar_fecha_inicio.Location = new System.Drawing.Point(19, 190);
            this.calendar_fecha_inicio.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.calendar_fecha_inicio.Name = "calendar_fecha_inicio";
            this.calendar_fecha_inicio.TabIndex = 61;
            // 
            // label_fecha_inicio
            // 
            this.label_fecha_inicio.AutoSize = true;
            this.label_fecha_inicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_inicio.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_fecha_inicio.Location = new System.Drawing.Point(15, 158);
            this.label_fecha_inicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_fecha_inicio.Name = "label_fecha_inicio";
            this.label_fecha_inicio.Size = new System.Drawing.Size(190, 23);
            this.label_fecha_inicio.TabIndex = 60;
            this.label_fecha_inicio.Text = "Fecha de creacion:";
            // 
            // label_fecha_fin
            // 
            this.label_fecha_fin.AutoSize = true;
            this.label_fecha_fin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_fin.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_fecha_fin.Location = new System.Drawing.Point(357, 158);
            this.label_fecha_fin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_fecha_fin.Name = "label_fecha_fin";
            this.label_fecha_fin.Size = new System.Drawing.Size(222, 23);
            this.label_fecha_fin.TabIndex = 59;
            this.label_fecha_fin.Text = "Fecha de vencimiento:";
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(240, 363);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 58;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(466, 363);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 57;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(17, 363);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 56;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // Apartado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 642);
            this.Controls.Add(this.calendar_fecha_fin);
            this.Controls.Add(this.calendar_fecha_inicio);
            this.Controls.Add(this.label_fecha_inicio);
            this.Controls.Add(this.label_fecha_fin);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.tabla_apartado);
            this.Controls.Add(this.combo_tarjetas);
            this.Controls.Add(this.label_producto);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.comboBox_pantallas);
            this.Name = "Apartado";
            this.Text = "Apartado";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_apartado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tabla_apartado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProdTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTemporada;
        private System.Windows.Forms.DataGridViewTextBoxColumn temporada;
        private System.Windows.Forms.ComboBox combo_tarjetas;
        private System.Windows.Forms.Label label_producto;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.MonthCalendar calendar_fecha_fin;
        private System.Windows.Forms.MonthCalendar calendar_fecha_inicio;
        private System.Windows.Forms.Label label_fecha_inicio;
        private System.Windows.Forms.Label label_fecha_fin;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_agregar;
    }
}