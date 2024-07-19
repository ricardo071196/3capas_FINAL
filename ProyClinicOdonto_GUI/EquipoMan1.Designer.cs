namespace ProyClinicOdonto_GUI
{
    partial class EquipoMan1
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
            label1 = new Label();
            txtFiltro = new TextBox();
            dtgEquipo = new DataGridView();
            label2 = new Label();
            lblRegistros = new Label();
            btnActualizar = new Button();
            button2 = new Button();
            btnInsertar = new Button();
            lblRegistros2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 37);
            label1.Name = "label1";
            label1.Size = new Size(279, 24);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el Nombre de Equipo:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(324, 33);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(406, 28);
            txtFiltro.TabIndex = 0;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // dtgEquipo
            // 
            dtgEquipo.AllowUserToAddRows = false;
            dtgEquipo.AllowUserToDeleteRows = false;
            dtgEquipo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgEquipo.BackgroundColor = SystemColors.ActiveCaption;
            dtgEquipo.BorderStyle = BorderStyle.Fixed3D;
            dtgEquipo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEquipo.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgEquipo.GridColor = SystemColors.ActiveCaptionText;
            dtgEquipo.Location = new Point(38, 81);
            dtgEquipo.Margin = new Padding(4);
            dtgEquipo.Name = "dtgEquipo";
            dtgEquipo.ReadOnly = true;
            dtgEquipo.RowHeadersVisible = false;
            dtgEquipo.RowHeadersWidth = 51;
            dtgEquipo.RowTemplate.Height = 29;
            dtgEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEquipo.Size = new Size(1156, 407);
            dtgEquipo.TabIndex = 2;
            dtgEquipo.Tag = "";
            dtgEquipo.CellContentClick += dtgEquipo_CellContentClick_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(887, 626);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 3;
            label2.Text = "Registros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.FixedSingle;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ActiveCaptionText;
            lblRegistros.Location = new Point(2380, 560);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(85, 33);
            lblRegistros.TabIndex = 1;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnActualizar.BackColor = SystemColors.HotTrack;
            btnActualizar.ForeColor = SystemColors.ButtonHighlight;
            btnActualizar.Location = new Point(887, 698);
            btnActualizar.Margin = new Padding(4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(139, 54);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click_1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Crimson;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1055, 698);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(139, 54);
            button2.TabIndex = 5;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(710, 698);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 10;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_2;
            // 
            // lblRegistros2
            // 
            lblRegistros2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros2.BorderStyle = BorderStyle.Fixed3D;
            lblRegistros2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros2.ForeColor = SystemColors.ControlText;
            lblRegistros2.Location = new Point(1055, 626);
            lblRegistros2.Margin = new Padding(5, 0, 5, 0);
            lblRegistros2.Name = "lblRegistros2";
            lblRegistros2.Size = new Size(139, 54);
            lblRegistros2.TabIndex = 11;
            lblRegistros2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EquipoMan1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1230, 788);
            ControlBox = false;
            Controls.Add(lblRegistros2);
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(btnActualizar);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgEquipo);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EquipoMan1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mantenimiento de Equipo";
            WindowState = FormWindowState.Maximized;
            Load += EquipoMan1_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFiltro;
        private DataGridView dtgEquipo;
        private Label label2;
        private Label lblRegistros;
        private Button btnActualizar;
        private Button button2;
        private Button btnInsertar;
        private Label lblRegistros2;
    }
}