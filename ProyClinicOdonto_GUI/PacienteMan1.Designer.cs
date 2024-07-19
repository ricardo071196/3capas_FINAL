namespace ProyClinicOdonto_GUI
{
    partial class PacienteMan1
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            txtFiltro = new TextBox();
            label1 = new Label();
            dtgPaciente = new DataGridView();
            btnSalir = new Button();
            btnActualizar = new Button();
            btnInsertar = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPaciente).BeginInit();
            SuspendLayout();
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(368, 25);
            txtFiltro.Margin = new Padding(5, 4, 5, 4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(413, 28);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged_1;
            // 
            // label1
            // 
            label1.Location = new Point(17, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(324, 24);
            label1.TabIndex = 2;
            label1.Text = "Ingrese el Nombre de Paciente:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgPaciente
            // 
            dtgPaciente.AllowUserToAddRows = false;
            dtgPaciente.AllowUserToDeleteRows = false;
            dtgPaciente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgPaciente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgPaciente.BackgroundColor = SystemColors.ActiveCaption;
            dtgPaciente.BorderStyle = BorderStyle.Fixed3D;
            dtgPaciente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPaciente.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgPaciente.Location = new Point(14, 73);
            dtgPaciente.Margin = new Padding(5, 4, 5, 4);
            dtgPaciente.Name = "dtgPaciente";
            dtgPaciente.ReadOnly = true;
            dtgPaciente.RowHeadersVisible = false;
            dtgPaciente.RowHeadersWidth = 51;
            dtgPaciente.RowTemplate.Height = 29;
            dtgPaciente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgPaciente.Size = new Size(989, 465);
            dtgPaciente.TabIndex = 4;
            dtgPaciente.CellContentClick += dtgPaciente_CellContentClick_1;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.Crimson;
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(864, 650);
            btnSalir.Margin = new Padding(5, 4, 5, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(139, 54);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(702, 650);
            btnActualizar.Margin = new Padding(5, 4, 5, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 54);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(523, 650);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 2;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.Fixed3D;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.Location = new Point(864, 586);
            lblRegistros.Margin = new Padding(5, 0, 5, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(139, 54);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(702, 586);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 8;
            label2.Text = "Registros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PacienteMan1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1028, 727);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgPaciente);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PacienteMan1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mantenimiento de Paciente";
            WindowState = FormWindowState.Maximized;
            Load += PacienteMan1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgPaciente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFiltro;
        private Label label1;
        private DataGridView dtgPaciente;
        private Button btnSalir;
        private Button btnActualizar;
        private Button btnInsertar;
        private Label lblRegistros;
        private Label label2;
    }
}