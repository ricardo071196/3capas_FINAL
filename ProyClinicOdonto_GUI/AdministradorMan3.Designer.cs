namespace ProyClinicOdonto_GUI
{
    partial class AdministradorMan3
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
            lblLogin = new Label();
            cboEstado = new ComboBox();
            label3 = new Label();
            txtPass_Usuario = new TextBox();
            label6 = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnGrabar = new Button();
            grpDatos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(lblLogin);
            grpDatos.Controls.Add(cboEstado);
            grpDatos.Controls.Add(label3);
            grpDatos.Controls.Add(txtPass_Usuario);
            grpDatos.Controls.Add(label6);
            grpDatos.Controls.Add(label2);
            grpDatos.Controls.Add(btnCancelar);
            grpDatos.Controls.Add(btnGrabar);
            grpDatos.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            grpDatos.ForeColor = SystemColors.ButtonHighlight;
            grpDatos.Location = new Point(22, 17);
            grpDatos.Margin = new Padding(5);
            grpDatos.Name = "grpDatos";
            grpDatos.Padding = new Padding(5);
            grpDatos.Size = new Size(666, 489);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos de Usuario:";
            grpDatos.Enter += grpDatos_Enter;
            // 
            // lblLogin
            // 
            lblLogin.BorderStyle = BorderStyle.Fixed3D;
            lblLogin.ForeColor = SystemColors.ButtonHighlight;
            lblLogin.Location = new Point(219, 113);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(372, 32);
            lblLogin.TabIndex = 46;
            lblLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(219, 221);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 27);
            cboEstado.TabIndex = 45;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 221);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 19);
            label3.TabIndex = 44;
            label3.Text = "Estado:";
            // 
            // txtPass_Usuario
            // 
            txtPass_Usuario.Location = new Point(219, 167);
            txtPass_Usuario.Margin = new Padding(5, 4, 5, 4);
            txtPass_Usuario.Name = "txtPass_Usuario";
            txtPass_Usuario.Size = new Size(308, 28);
            txtPass_Usuario.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 120);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(145, 19);
            label6.TabIndex = 42;
            label6.Text = "Nombre Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 171);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(119, 19);
            label2.TabIndex = 40;
            label2.Text = "Pass_Usuario:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Location = new Point(507, 400);
            btnCancelar.Margin = new Padding(5, 4, 5, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(137, 67);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.RoyalBlue;
            btnGrabar.Location = new Point(350, 400);
            btnGrabar.Margin = new Padding(5, 4, 5, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(137, 67);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // AdministradorMan3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(703, 521);
            Controls.Add(grpDatos);
            ForeColor = SystemColors.ControlText;
            Name = "AdministradorMan3";
            Text = "Editar Contraseña";
            Load += AdministradorMan3_Load;
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpDatos;
        private Button btnCancelar;
        private Button btnGrabar;
        private ComboBox cboEstado;
        private Label label3;
        private TextBox txtPass_Usuario;
        private Label label6;
        private Label label2;
        internal Label lblLogin;
    }
}