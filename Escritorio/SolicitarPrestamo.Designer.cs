namespace Escritorio
{
    partial class SolicitarPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDatosSoli = new System.Windows.Forms.GroupBox();
            this.cbxCarrera = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxTipodeSolicitante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoControl2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxDetalles = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgSeleccionar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregardispositivo = new System.Windows.Forms.Button();
            this.cbxCantidad = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbxHora = new System.Windows.Forms.ComboBox();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.dtpfechasoli = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbxComentarios = new System.Windows.Forms.GroupBox();
            this.txtcomentarios = new System.Windows.Forms.TextBox();
            this.dtpfechasoli1 = new System.Windows.Forms.DateTimePicker();
            this.gbxDatosSoli.SuspendLayout();
            this.gbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbxComentarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitud de Prestamo de Dispositivo";
            // 
            // gbxDatosSoli
            // 
            this.gbxDatosSoli.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxDatosSoli.Controls.Add(this.cbxCarrera);
            this.gbxDatosSoli.Controls.Add(this.label8);
            this.gbxDatosSoli.Controls.Add(this.cbxTipodeSolicitante);
            this.gbxDatosSoli.Controls.Add(this.label4);
            this.gbxDatosSoli.Controls.Add(this.txtNoControl2);
            this.gbxDatosSoli.Controls.Add(this.txtNombre);
            this.gbxDatosSoli.Controls.Add(this.label3);
            this.gbxDatosSoli.Controls.Add(this.label2);
            this.gbxDatosSoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDatosSoli.Location = new System.Drawing.Point(28, 97);
            this.gbxDatosSoli.Name = "gbxDatosSoli";
            this.gbxDatosSoli.Size = new System.Drawing.Size(359, 165);
            this.gbxDatosSoli.TabIndex = 1;
            this.gbxDatosSoli.TabStop = false;
            this.gbxDatosSoli.Text = "Datos del Solicitante";
            // 
            // cbxCarrera
            // 
            this.cbxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCarrera.FormattingEnabled = true;
            this.cbxCarrera.Location = new System.Drawing.Point(201, 92);
            this.cbxCarrera.Name = "cbxCarrera";
            this.cbxCarrera.Size = new System.Drawing.Size(121, 21);
            this.cbxCarrera.TabIndex = 7;
            this.cbxCarrera.SelectedIndexChanged += new System.EventHandler(this.cbxCarrera_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Carrera";
            // 
            // cbxTipodeSolicitante
            // 
            this.cbxTipodeSolicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipodeSolicitante.FormattingEnabled = true;
            this.cbxTipodeSolicitante.Location = new System.Drawing.Point(13, 92);
            this.cbxTipodeSolicitante.Name = "cbxTipodeSolicitante";
            this.cbxTipodeSolicitante.Size = new System.Drawing.Size(121, 21);
            this.cbxTipodeSolicitante.TabIndex = 5;
            this.cbxTipodeSolicitante.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de Solicitante";
            // 
            // txtNoControl2
            // 
            this.txtNoControl2.Location = new System.Drawing.Point(197, 36);
            this.txtNoControl2.MaxLength = 8;
            this.txtNoControl2.Name = "txtNoControl2";
            this.txtNoControl2.Size = new System.Drawing.Size(109, 20);
            this.txtNoControl2.TabIndex = 3;
            this.txtNoControl2.TextChanged += new System.EventHandler(this.txtNoControl2_TextChanged);
            this.txtNoControl2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoControl2_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(10, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numero de Control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de Solicitante";
            // 
            // gbxDetalles
            // 
            this.gbxDetalles.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxDetalles.Controls.Add(this.dtpfechasoli1);
            this.gbxDetalles.Controls.Add(this.btnEliminar);
            this.gbxDetalles.Controls.Add(this.dvgSeleccionar);
            this.gbxDetalles.Controls.Add(this.btnAgregardispositivo);
            this.gbxDetalles.Controls.Add(this.cbxCantidad);
            this.gbxDetalles.Controls.Add(this.lblCantidad);
            this.gbxDetalles.Controls.Add(this.cbxHora);
            this.gbxDetalles.Controls.Add(this.cbxDispositivo);
            this.gbxDetalles.Controls.Add(this.dtpfechasoli);
            this.gbxDetalles.Controls.Add(this.label7);
            this.gbxDetalles.Controls.Add(this.label6);
            this.gbxDetalles.Controls.Add(this.label5);
            this.gbxDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDetalles.Location = new System.Drawing.Point(393, 97);
            this.gbxDetalles.Name = "gbxDetalles";
            this.gbxDetalles.Size = new System.Drawing.Size(398, 294);
            this.gbxDetalles.TabIndex = 2;
            this.gbxDetalles.TabStop = false;
            this.gbxDetalles.Text = "Detalles de Prestamo";
            this.gbxDetalles.Enter += new System.EventHandler(this.gbxDetalles_Enter);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(234, 248);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(73, 29);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eiminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgSeleccionar
            // 
            this.dvgSeleccionar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSeleccionar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dvgSeleccionar.Location = new System.Drawing.Point(13, 118);
            this.dvgSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dvgSeleccionar.Name = "dvgSeleccionar";
            this.dvgSeleccionar.RowHeadersWidth = 51;
            this.dvgSeleccionar.RowTemplate.Height = 24;
            this.dvgSeleccionar.Size = new System.Drawing.Size(294, 126);
            this.dvgSeleccionar.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Dispositivo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // btnAgregardispositivo
            // 
            this.btnAgregardispositivo.Location = new System.Drawing.Point(311, 248);
            this.btnAgregardispositivo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregardispositivo.Name = "btnAgregardispositivo";
            this.btnAgregardispositivo.Size = new System.Drawing.Size(71, 29);
            this.btnAgregardispositivo.TabIndex = 8;
            this.btnAgregardispositivo.Text = "Agregar";
            this.btnAgregardispositivo.UseVisualStyleBackColor = true;
            this.btnAgregardispositivo.Click += new System.EventHandler(this.btnAgregardispositivo_Click);
            // 
            // cbxCantidad
            // 
            this.cbxCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCantidad.FormattingEnabled = true;
            this.cbxCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbxCantidad.Location = new System.Drawing.Point(148, 34);
            this.cbxCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxCantidad.Name = "cbxCantidad";
            this.cbxCantidad.Size = new System.Drawing.Size(56, 21);
            this.cbxCantidad.TabIndex = 7;
            this.cbxCantidad.SelectedIndexChanged += new System.EventHandler(this.cbxCantidad_SelectedIndexChanged);
            this.cbxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCantidad_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(146, 19);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(57, 13);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad";
            // 
            // cbxHora
            // 
            this.cbxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxHora.FormattingEnabled = true;
            this.cbxHora.Location = new System.Drawing.Point(222, 35);
            this.cbxHora.Name = "cbxHora";
            this.cbxHora.Size = new System.Drawing.Size(121, 21);
            this.cbxHora.TabIndex = 5;
            this.cbxHora.SelectedIndexChanged += new System.EventHandler(this.cbxHora_SelectedIndexChanged);
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(7, 35);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(121, 21);
            this.cbxDispositivo.TabIndex = 4;
            this.cbxDispositivo.SelectedIndexChanged += new System.EventHandler(this.cbxDispositivo_SelectedIndexChanged);
            // 
            // dtpfechasoli
            // 
            this.dtpfechasoli.Location = new System.Drawing.Point(98, 128);
            this.dtpfechasoli.Name = "dtpfechasoli";
            this.dtpfechasoli.Size = new System.Drawing.Size(200, 20);
            this.dtpfechasoli.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(223, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hora de Uso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dispositivo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(716, 417);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(615, 417);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Escritorio.Properties.Resources._protected;
            this.pictureBox1.Location = new System.Drawing.Point(49, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // gbxComentarios
            // 
            this.gbxComentarios.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbxComentarios.Controls.Add(this.txtcomentarios);
            this.gbxComentarios.Location = new System.Drawing.Point(28, 279);
            this.gbxComentarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxComentarios.Name = "gbxComentarios";
            this.gbxComentarios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxComentarios.Size = new System.Drawing.Size(277, 149);
            this.gbxComentarios.TabIndex = 8;
            this.gbxComentarios.TabStop = false;
            this.gbxComentarios.Text = "Comentarios";
            // 
            // txtcomentarios
            // 
            this.txtcomentarios.Location = new System.Drawing.Point(4, 17);
            this.txtcomentarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcomentarios.Multiline = true;
            this.txtcomentarios.Name = "txtcomentarios";
            this.txtcomentarios.Size = new System.Drawing.Size(484, 123);
            this.txtcomentarios.TabIndex = 0;
            this.txtcomentarios.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dtpfechasoli1
            // 
            this.dtpfechasoli1.Location = new System.Drawing.Point(4, 93);
            this.dtpfechasoli1.Name = "dtpfechasoli1";
            this.dtpfechasoli1.Size = new System.Drawing.Size(200, 20);
            this.dtpfechasoli1.TabIndex = 11;
            // 
            // SolicitarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxComentarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxDetalles);
            this.Controls.Add(this.gbxDatosSoli);
            this.Controls.Add(this.label1);
            this.Name = "SolicitarPrestamo";
            this.Text = "SolicitarPrestamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SolicitarPrestamo_FormClosing);
            this.Load += new System.EventHandler(this.SolicitarPrestamo_Load);
            this.gbxDatosSoli.ResumeLayout(false);
            this.gbxDatosSoli.PerformLayout();
            this.gbxDetalles.ResumeLayout(false);
            this.gbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbxComentarios.ResumeLayout(false);
            this.gbxComentarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxDatosSoli;
        private System.Windows.Forms.GroupBox gbxDetalles;
        private System.Windows.Forms.ComboBox cbxTipodeSolicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoControl2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxHora;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.DateTimePicker dtpfechasoli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCarrera;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbxComentarios;
        private System.Windows.Forms.TextBox txtcomentarios;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.ComboBox cbxCantidad;
        private System.Windows.Forms.Button btnAgregardispositivo;
        private System.Windows.Forms.DataGridView dvgSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker dtpfechasoli1;
    }
}