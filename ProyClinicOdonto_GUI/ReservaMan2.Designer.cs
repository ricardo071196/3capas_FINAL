namespace ProyClinicOdonto_GUI
{
    partial class ReservaMan2
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
            cboConsultorio = new ComboBox();
            label2 = new Label();
            cboOdontologos = new ComboBox();
            txtHORA = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtDetalle = new TextBox();
            mskPACIENTE = new MaskedTextBox();
            chkActivo = new CheckBox();
            label3 = new Label();
            dtpFechaReser = new DateTimePicker();
            btnCancelar = new Button();
            btnGrabar = new Button();
            label9 = new Label();
            label1 = new Label();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(cboConsultorio);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(cboOdontologos);
            grpDatos.Controls.Add(txtHORA);
            grpDatos.Controls.Add(label5);
            grpDatos.Controls.Add(label4);
            grpDatos.Controls.Add(txtDetalle);
            grpDatos.Controls.Add(mskPACIENTE);
            grpDatos.Controls.Add(chkActivo);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(dtpFechaReser);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Controls.Add(label9);
            grpDatos.Controls.Add(label1);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonHighlight;
            grpDatos.Location = new Point(23, 19);
            grpDatos.Margin = new Padding(4, 3, 4, 3);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(4, 3, 4, 3);
            grpDatos.Size = new Size(705, 396);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de Cita:";
            // 
            // cboConsultorio
            // 
            cboConsultorio.BackColor = SystemColors.ScrollBar;
            cboConsultorio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConsultorio.FormattingEnabled = true;
            cboConsultorio.Location = new Point(180, 220);
            cboConsultorio.Margin = new Padding(3, 2, 3, 2);
            cboConsultorio.Name = "cboConsultorio";
            cboConsultorio.Size = new Size(222, 25);
            cboConsultorio.TabIndex = 45;
            cboConsultorio.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 226);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 17);
            label2.TabIndex = 44;
            label2.Text = "Consultorio:";
            // 
            // cboOdontologos
            // 
            cboOdontologos.BackColor = SystemColors.ScrollBar;
            cboOdontologos.DropDownStyle = ComboBoxStyle.DropDownList;
            cboOdontologos.FormattingEnabled = true;
            cboOdontologos.Location = new Point(180, 169);
            cboOdontologos.Margin = new Padding(3, 2, 3, 2);
            cboOdontologos.Name = "cboOdontologos";
            cboOdontologos.Size = new Size(272, 25);
            cboOdontologos.TabIndex = 43;
            cboOdontologos.UseWaitCursor = true;
            // 
            // txtHORA
            // 
            txtHORA.Cursor = Cursors.IBeam;
            txtHORA.Location = new Point(180, 118);
            txtHORA.Margin = new Padding(4, 3, 4, 3);
            txtHORA.Name = "txtHORA";
            txtHORA.Size = new Size(93, 24);
            txtHORA.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 175);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 17);
            label5.TabIndex = 39;
            label5.Text = "Odontologo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 270);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 17);
            label4.TabIndex = 38;
            label4.Text = "Detalle:";
            // 
            // txtDetalle
            // 
            txtDetalle.Cursor = Cursors.IBeam;
            txtDetalle.Location = new Point(180, 263);
            txtDetalle.Margin = new Padding(4, 3, 4, 3);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(369, 24);
            txtDetalle.TabIndex = 37;
            // 
            // mskPACIENTE
            // 
            mskPACIENTE.Location = new Point(180, 32);
            mskPACIENTE.Margin = new Padding(3, 2, 3, 2);
            mskPACIENTE.Mask = "99999999";
            mskPACIENTE.Name = "mskPACIENTE";
            mskPACIENTE.Size = new Size(93, 24);
            mskPACIENTE.TabIndex = 36;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(180, 300);
            chkActivo.Margin = new Padding(3, 2, 3, 2);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(70, 21);
            chkActivo.TabIndex = 4;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 125);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 17);
            label3.TabIndex = 22;
            label3.Text = "Hora cita:";
            // 
            // dtpFechaReser
            // 
            dtpFechaReser.Location = new Point(180, 70);
            dtpFechaReser.Margin = new Padding(3, 2, 3, 2);
            dtpFechaReser.Name = "dtpFechaReser";
            dtpFechaReser.Size = new Size(324, 24);
            dtpFechaReser.TabIndex = 6;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.OrangeRed;
            btnCancelar.Location = new Point(562, 322);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 50);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(429, 322);
            btnGrabar.Margin = new Padding(3, 2, 3, 2);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(120, 50);
            btnGrabar.TabIndex = 7;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(46, 76);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(84, 17);
            label9.TabIndex = 16;
            label9.Text = "Fecha cita:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 17);
            label1.TabIndex = 0;
            label1.Text = "DNI:";
            // 
            // ReservaMan2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(755, 427);
            Controls.Add(grpDatos);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ReservaMan2";
            Text = "Nueva Cita";
            Load += ReservaMan2_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private CheckBox chkActivo;
        private Label label3;
        private DateTimePicker dtpFechaReser;
        private Button btnCancelar;
        private Button btnGrabar;
        private Label label9;
        private Label label1;
        private MaskedTextBox mskPACIENTE;
        private Label label5;
        private Label label4;
        private TextBox txtDetalle;
        private TextBox txtHORA;
        private ComboBox cboOdontologos;
        private ComboBox cboConsultorio;
        private Label label2;
    }
}