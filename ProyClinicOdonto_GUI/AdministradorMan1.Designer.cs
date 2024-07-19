namespace ProyClinicOdonto_GUI
{
    partial class AdministradorMan1
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
            lblRegistros2 = new Label();
            btnInsertar = new Button();
            button2 = new Button();
            label2 = new Label();
            dtgUsuarioAdmin = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgUsuarioAdmin).BeginInit();
            SuspendLayout();
            // 
            // lblRegistros2
            // 
            lblRegistros2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros2.BorderStyle = BorderStyle.Fixed3D;
            lblRegistros2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros2.ForeColor = SystemColors.ControlText;
            lblRegistros2.Location = new Point(915, 454);
            lblRegistros2.Margin = new Padding(4, 0, 4, 0);
            lblRegistros2.Name = "lblRegistros2";
            lblRegistros2.Size = new Size(139, 54);
            lblRegistros2.TabIndex = 19;
            lblRegistros2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.Green;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(738, 521);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Crimson;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(915, 521);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(139, 54);
            button2.TabIndex = 17;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(768, 454);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 16;
            label2.Text = "Registros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgUsuarioAdmin
            // 
            dtgUsuarioAdmin.AllowUserToAddRows = false;
            dtgUsuarioAdmin.AllowUserToDeleteRows = false;
            dtgUsuarioAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgUsuarioAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgUsuarioAdmin.BackgroundColor = SystemColors.ActiveCaption;
            dtgUsuarioAdmin.BorderStyle = BorderStyle.Fixed3D;
            dtgUsuarioAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgUsuarioAdmin.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgUsuarioAdmin.Location = new Point(35, 57);
            dtgUsuarioAdmin.Margin = new Padding(4, 3, 4, 3);
            dtgUsuarioAdmin.Name = "dtgUsuarioAdmin";
            dtgUsuarioAdmin.ReadOnly = true;
            dtgUsuarioAdmin.RowHeadersVisible = false;
            dtgUsuarioAdmin.RowHeadersWidth = 51;
            dtgUsuarioAdmin.RowTemplate.Height = 29;
            dtgUsuarioAdmin.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgUsuarioAdmin.Size = new Size(1019, 357);
            dtgUsuarioAdmin.TabIndex = 14;
            dtgUsuarioAdmin.CellContentClick += dtgUsuarioAdmin_CellContentClick;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(314, 12);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(356, 28);
            txtFiltro.TabIndex = 12;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(35, 20);
            label1.Name = "label1";
            label1.Size = new Size(301, 24);
            label1.TabIndex = 13;
            label1.Text = "Ingrese el Nombre de Usuario:";
            // 
            // AdministradorMan1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1080, 598);
            ControlBox = false;
            Controls.Add(lblRegistros2);
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(dtgUsuarioAdmin);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdministradorMan1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Mantenimiento Usuario";
            WindowState = FormWindowState.Maximized;
            Load += AdministradorMan1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgUsuarioAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegistros2;
        private Button btnInsertar;
        private Button button2;
        private Label label2;
        private DataGridView dtgUsuarioAdmin;
        private TextBox txtFiltro;
        private Label label1;
    }
}