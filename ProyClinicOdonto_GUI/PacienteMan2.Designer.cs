namespace ProyClinicOdonto_GUI
{
    partial class PacienteMan2
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnGrabar = new Button();
            btnCancelar = new Button();
            txtNomPaci = new TextBox();
            txtAlerg = new TextBox();
            txtApePaci = new TextBox();
            txtEmail = new TextBox();
            label12 = new Label();
            grpDatos = new GroupBox();
            mskDNI = new MaskedTextBox();
            cboDistrito = new ComboBox();
            gbGenero = new GroupBox();
            rbFemen = new RadioButton();
            rbMascu = new RadioButton();
            label10 = new Label();
            label3 = new Label();
            DNI = new Label();
            dtpReg = new DateTimePicker();
            mskTelefono = new MaskedTextBox();
            label8 = new Label();
            label6 = new Label();
            grpDatos.SuspendLayout();
            gbGenero.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 85);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre de Paciente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 127);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(156, 17);
            label2.TabIndex = 2;
            label2.Text = "Apellido de Paciente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 169);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 17);
            label4.TabIndex = 6;
            label4.Text = "Email:";
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(382, 484);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 10;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(517, 484);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // txtNomPaci
            // 
            txtNomPaci.Location = new Point(237, 81);
            txtNomPaci.Name = "txtNomPaci";
            txtNomPaci.Size = new Size(299, 24);
            txtNomPaci.TabIndex = 1;
            // 
            // txtAlerg
            // 
            txtAlerg.Location = new Point(237, 248);
            txtAlerg.Margin = new Padding(4);
            txtAlerg.Name = "txtAlerg";
            txtAlerg.Size = new Size(299, 24);
            txtAlerg.TabIndex = 6;
            // 
            // txtApePaci
            // 
            txtApePaci.Location = new Point(237, 123);
            txtApePaci.Name = "txtApePaci";
            txtApePaci.Size = new Size(299, 24);
            txtApePaci.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(237, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(299, 24);
            txtEmail.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 252);
            label12.Name = "label12";
            label12.Size = new Size(67, 17);
            label12.TabIndex = 27;
            label12.Text = "Alergias:";
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(mskDNI);
            grpDatos.Controls.Add(cboDistrito);
            grpDatos.Controls.Add(gbGenero);
            grpDatos.Controls.Add(label10);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(DNI);
            grpDatos.Controls.Add(dtpReg);
            grpDatos.Controls.Add(mskTelefono);
            grpDatos.Controls.Add(label8);
            grpDatos.Controls.Add(label12);
            grpDatos.Controls.Add(txtEmail);
            grpDatos.Controls.Add(txtApePaci);
            grpDatos.Controls.Add(txtAlerg);
            grpDatos.Controls.Add(txtNomPaci);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonFace;
            grpDatos.Location = new Point(13, 14);
            grpDatos.Margin = new Padding(4);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4);
            grpDatos.Size = new Size(654, 552);
            grpDatos.TabIndex = 0;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos Paciente:";
            // 
            // mskDNI
            // 
            mskDNI.Location = new Point(237, 39);
            mskDNI.Mask = "99999999";
            mskDNI.Name = "mskDNI";
            mskDNI.Size = new Size(106, 24);
            mskDNI.TabIndex = 0;
            // 
            // cboDistrito
            // 
            cboDistrito.BackColor = SystemColors.ScrollBar;
            cboDistrito.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDistrito.FormattingEnabled = true;
            cboDistrito.Location = new Point(237, 290);
            cboDistrito.Name = "cboDistrito";
            cboDistrito.Size = new Size(253, 25);
            cboDistrito.TabIndex = 8;
            cboDistrito.UseWaitCursor = true;
            // 
            // gbGenero
            // 
            gbGenero.Controls.Add(rbFemen);
            gbGenero.Controls.Add(rbMascu);
            gbGenero.Location = new Point(237, 379);
            gbGenero.Name = "gbGenero";
            gbGenero.Size = new Size(278, 47);
            gbGenero.TabIndex = 54;
            gbGenero.TabStop = false;
            gbGenero.UseWaitCursor = true;
            // 
            // rbFemen
            // 
            rbFemen.AutoSize = true;
            rbFemen.Location = new Point(142, 18);
            rbFemen.Name = "rbFemen";
            rbFemen.Size = new Size(94, 21);
            rbFemen.TabIndex = 1;
            rbFemen.TabStop = true;
            rbFemen.Text = "Femenino";
            rbFemen.UseVisualStyleBackColor = true;
            rbFemen.UseWaitCursor = true;
            // 
            // rbMascu
            // 
            rbMascu.AutoSize = true;
            rbMascu.Location = new Point(15, 18);
            rbMascu.Name = "rbMascu";
            rbMascu.Size = new Size(96, 21);
            rbMascu.TabIndex = 0;
            rbMascu.TabStop = true;
            rbMascu.Text = "Masculino";
            rbMascu.UseVisualStyleBackColor = true;
            rbMascu.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 394);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(149, 17);
            label10.TabIndex = 53;
            label10.Text = "Genero de Paciente:";
            label10.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 294);
            label3.Name = "label3";
            label3.Size = new Size(57, 17);
            label3.TabIndex = 51;
            label3.Text = "Distrito:";
            label3.UseWaitCursor = true;
            // 
            // DNI
            // 
            DNI.AutoSize = true;
            DNI.Location = new Point(39, 43);
            DNI.Margin = new Padding(4, 0, 4, 0);
            DNI.Name = "DNI";
            DNI.Size = new Size(36, 17);
            DNI.TabIndex = 43;
            DNI.Text = "DNI:";
            // 
            // dtpReg
            // 
            dtpReg.Location = new Point(237, 333);
            dtpReg.Name = "dtpReg";
            dtpReg.Size = new Size(367, 24);
            dtpReg.TabIndex = 9;
            dtpReg.UseWaitCursor = true;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(237, 207);
            mskTelefono.Mask = "999999999";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(88, 24);
            mskTelefono.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 337);
            label8.Name = "label8";
            label8.Size = new Size(154, 17);
            label8.TabIndex = 49;
            label8.Text = "Fecha de Inscripcion:";
            label8.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 211);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(70, 17);
            label6.TabIndex = 10;
            label6.Text = "Telefono:";
            // 
            // PacienteMan2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(696, 579);
            Controls.Add(grpDatos);
            Font = new Font("Century Gothic", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nuevo Paciente";
            Load += PacienteMan2_Load_1;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            gbGenero.ResumeLayout(false);
            gbGenero.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnGrabar;
        private Button btnCancelar;
        private TextBox txtNomPaci;
        private TextBox txtAlerg;
        private TextBox txtApePaci;
        private TextBox txtEmail;
        private Label label12;
        private GroupBox grpDatos;
        private Label DNI;
        private MaskedTextBox mskTelefono;
        private Label label6;
        private Label label3;
        private DateTimePicker dtpReg;
        private Label label8;
        private GroupBox gbGenero;
        private RadioButton rbFemen;
        private RadioButton rbMascu;
        private Label label10;
        private ComboBox cboDistrito;
        private MaskedTextBox mskDNI;
    }
}