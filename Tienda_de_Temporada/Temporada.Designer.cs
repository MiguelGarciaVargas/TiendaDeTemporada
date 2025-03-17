namespace Tienda_de_Temporada
{
    partial class Temporada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox_pantallas = new System.Windows.Forms.ComboBox();
            this.button_actualizar = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.tabla_temporada = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_agregar = new System.Windows.Forms.Button();
            this.label_temporada = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_fecha_fin = new System.Windows.Forms.Label();
            this.label_fecha_inicio = new System.Windows.Forms.Label();
            this.calendar_fecha_inicio = new System.Windows.Forms.MonthCalendar();
            this.calendar_fecha_fin = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_temporada)).BeginInit();
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
            this.comboBox_pantallas.TabIndex = 44;
            this.comboBox_pantallas.Text = "Temporada";
            // 
            // button_actualizar
            // 
            this.button_actualizar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_actualizar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_actualizar.ForeColor = System.Drawing.Color.White;
            this.button_actualizar.Location = new System.Drawing.Point(253, 359);
            this.button_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_actualizar.Name = "button_actualizar";
            this.button_actualizar.Size = new System.Drawing.Size(181, 47);
            this.button_actualizar.TabIndex = 43;
            this.button_actualizar.Text = "Actualizar";
            this.button_actualizar.UseVisualStyleBackColor = false;
            this.button_actualizar.Click += new System.EventHandler(this.button_actualizar_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_eliminar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_eliminar.ForeColor = System.Drawing.Color.White;
            this.button_eliminar.Location = new System.Drawing.Point(479, 359);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(181, 47);
            this.button_eliminar.TabIndex = 42;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = false;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // tabla_temporada
            // 
            this.tabla_temporada.AllowUserToAddRows = false;
            this.tabla_temporada.AllowUserToDeleteRows = false;
            this.tabla_temporada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_temporada.BackgroundColor = System.Drawing.Color.White;
            this.tabla_temporada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_temporada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.fecha_inicio,
            this.fecha_fin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_temporada.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_temporada.Location = new System.Drawing.Point(30, 420);
            this.tabla_temporada.Name = "tabla_temporada";
            this.tabla_temporada.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_temporada.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabla_temporada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.tabla_temporada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_temporada.Size = new System.Drawing.Size(836, 210);
            this.tabla_temporada.TabIndex = 41;
            this.tabla_temporada.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_temporada_CellContentClick);
            // 
            // id
            // 
            this.id.FillWeight = 20F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // fecha_inicio
            // 
            this.fecha_inicio.FillWeight = 50F;
            this.fecha_inicio.HeaderText = "Fecha de inicio";
            this.fecha_inicio.Name = "fecha_inicio";
            this.fecha_inicio.ReadOnly = true;
            // 
            // fecha_fin
            // 
            this.fecha_fin.FillWeight = 50F;
            this.fecha_fin.HeaderText = "Fecha de fin";
            this.fecha_fin.Name = "fecha_fin";
            this.fecha_fin.ReadOnly = true;
            // 
            // button_agregar
            // 
            this.button_agregar.BackColor = System.Drawing.Color.SteelBlue;
            this.button_agregar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.ForeColor = System.Drawing.Color.White;
            this.button_agregar.Location = new System.Drawing.Point(30, 359);
            this.button_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(181, 47);
            this.button_agregar.TabIndex = 40;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = false;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // label_temporada
            // 
            this.label_temporada.AutoSize = true;
            this.label_temporada.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temporada.ForeColor = System.Drawing.Color.Navy;
            this.label_temporada.Location = new System.Drawing.Point(308, 56);
            this.label_temporada.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_temporada.Name = "label_temporada";
            this.label_temporada.Size = new System.Drawing.Size(194, 38);
            this.label_temporada.TabIndex = 39;
            this.label_temporada.Text = "Temporada";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda_de_Temporada.Properties.Resources.img_productos;
            this.pictureBox1.Location = new System.Drawing.Point(708, 93);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.Color.Lavender;
            this.textBox_nombre.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(150, 108);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(518, 33);
            this.textBox_nombre.TabIndex = 34;
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
            this.label_nombre.TabIndex = 32;
            this.label_nombre.Text = "Nombre:";
            // 
            // label_fecha_fin
            // 
            this.label_fecha_fin.AutoSize = true;
            this.label_fecha_fin.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_fin.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_fecha_fin.Location = new System.Drawing.Point(370, 154);
            this.label_fecha_fin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_fecha_fin.Name = "label_fecha_fin";
            this.label_fecha_fin.Size = new System.Drawing.Size(128, 23);
            this.label_fecha_fin.TabIndex = 45;
            this.label_fecha_fin.Text = "Fecha de fin:";
            // 
            // label_fecha_inicio
            // 
            this.label_fecha_inicio.AutoSize = true;
            this.label_fecha_inicio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fecha_inicio.ForeColor = System.Drawing.Color.SteelBlue;
            this.label_fecha_inicio.Location = new System.Drawing.Point(28, 154);
            this.label_fecha_inicio.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_fecha_inicio.Name = "label_fecha_inicio";
            this.label_fecha_inicio.Size = new System.Drawing.Size(157, 23);
            this.label_fecha_inicio.TabIndex = 46;
            this.label_fecha_inicio.Text = "Fecha de inicio:";
            // 
            // calendar_fecha_inicio
            // 
            this.calendar_fecha_inicio.Location = new System.Drawing.Point(32, 186);
            this.calendar_fecha_inicio.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.calendar_fecha_inicio.Name = "calendar_fecha_inicio";
            this.calendar_fecha_inicio.TabIndex = 47;
            this.calendar_fecha_inicio.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_fecha_inicio_DateChanged);
            // 
            // calendar_fecha_fin
            // 
            this.calendar_fecha_fin.Location = new System.Drawing.Point(374, 186);
            this.calendar_fecha_fin.MinDate = new System.DateTime(2025, 2, 25, 0, 0, 0, 0);
            this.calendar_fecha_fin.Name = "calendar_fecha_fin";
            this.calendar_fecha_fin.TabIndex = 48;
            this.calendar_fecha_fin.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_fecha_fin_DateChanged);
            // 
            // Temporada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(895, 645);
            this.Controls.Add(this.calendar_fecha_fin);
            this.Controls.Add(this.calendar_fecha_inicio);
            this.Controls.Add(this.label_fecha_inicio);
            this.Controls.Add(this.label_fecha_fin);
            this.Controls.Add(this.comboBox_pantallas);
            this.Controls.Add(this.button_actualizar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.tabla_temporada);
            this.Controls.Add(this.button_agregar);
            this.Controls.Add(this.label_temporada);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.label_nombre);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Temporada";
            this.Text = "Temporada";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_temporada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_pantallas;
        private System.Windows.Forms.Button button_actualizar;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.DataGridView tabla_temporada;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.Label label_temporada;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_fecha_fin;
        private System.Windows.Forms.Label label_fecha_inicio;
        private System.Windows.Forms.MonthCalendar calendar_fecha_inicio;
        private System.Windows.Forms.MonthCalendar calendar_fecha_fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_fin;
    }
}