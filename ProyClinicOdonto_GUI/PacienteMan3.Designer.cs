namespace ProyClinicOdonto_GUI
{
    partial class PacienteMan3
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
            grpDatos = new GroupBox();
            lblGenero = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            label3 = new Label();
            cboDistrito = new ComboBox();
            mskTelefono = new MaskedTextBox();
            txtAlergias = new TextBox();
            txtEmail = new TextBox();
            lblDni = new Label();
            lblNumSerie = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblGenero);
            grpDatos.Controls.Add(lblApellido);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(txtAlergias);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(lblDni);
            grpDatos.Controls.Add(lblNumSerie);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonHighlight;
            grpDatos.Location = new Point(13, 14);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(654, 552);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos: Paciente:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // lblGenero
            // 
            lblGenero.BorderStyle = BorderStyle.Fixed3D;
            lblGenero.Location = new Point(266, 190);
            lblGenero.Margin = new Padding(4, 0, 4, 0);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(56, 26);
            lblGenero.TabIndex = 55;
            lblGenero.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            lblApellido.BorderStyle = BorderStyle.Fixed3D;
            lblApellido.Location = new Point(266, 148);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(299, 26);
            lblApellido.TabIndex = 54;
            lblApellido.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.BorderStyle = BorderStyle.Fixed3D;
            lblNombre.Location = new Point(266, 109);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(299, 26);
            lblNombre.TabIndex = 53;
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 291);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 52;
            label3.Text = "Distrito:";
            label3.UseWaitCursor = true;
            // 
            // cboDistrito
            // 
            cboDistrito.BackColor = SystemColors.ScrollBar;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(266, 287);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(253, 27);
            cboDistrito.TabIndex = 39;
            cboDistrito.UseWaitCursor = true;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(266, 333);
            mskTelefono.Mask = "999999999";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(98, 28);
            mskTelefono.TabIndex = 5;
            // 
            // txtAlergias
            // 
            txtAlergias.Cursor = Cursors.IBeam;
            txtAlergias.Location = new Point(266, 378);
            txtAlergias.Margin = new Padding(4);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(299, 28);
            txtAlergias.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Location = new Point(266, 245);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 28);
            txtEmail.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.BorderStyle = BorderStyle.Fixed3D;
            lblDni.Location = new Point(266, 58);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(114, 26);
            lblDni.TabIndex = 0;
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNumSerie
            // 
            lblNumSerie.AutoSize = true;
            lblNumSerie.Location = new Point(69, 63);
            lblNumSerie.Name = "lblNumSerie";
            lblNumSerie.Size = new Size(44, 19);
            lblNumSerie.TabIndex = 0;
            lblNumSerie.Text = "DNI:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(517, 475);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(351, 475);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 382);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(81, 19);
            label9.TabIndex = 18;
            label9.Text = "Alergias:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 197);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(180, 19);
            label6.TabIndex = 12;
            label6.Text = "Genero de Paciente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 249);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 10;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 337);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 19);
            label4.TabIndex = 8;
            label4.Text = "Telefono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 155);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 19);
            label2.TabIndex = 4;
            label2.Text = "Apellido de Paciente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(185, 19);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Paciente:";
            // 
            // PacienteMan3
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(696, 579);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Paciente";
            Load += PacienteMan3_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private TextBox txtUsuUltReg;
        private Label lblNumSerie;
        private MaskedTextBox txtIdConsultFin;
        private MaskedTextBox mskValor;
        private TextBox txtDesc;
        private DateTimePicker dtpFechaAdqui;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        internal Label lblDni;
        private TextBox txtAlergias;
        private TextBox txtEmail;
        private MaskedTextBox mskTelefono;
        private ComboBox cboDistrito;
        private Label label3;
        internal Label lblGenero;
        internal Label lblApellido;
        internal Label lblNombre;
    }
}