namespace ProyClinicOdonto_GUI
{
    partial class VistaGuiaRemision
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
            button2 = new Button();
            lblRegistros = new Label();
            label2 = new Label();
            dtgGuia = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgGuia).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Crimson;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(851, 507);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(139, 54);
            button2.TabIndex = 19;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.Fixed3D;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ControlText;
            lblRegistros.Location = new Point(851, 436);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(139, 54);
            lblRegistros.TabIndex = 16;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(704, 436);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 18;
            label2.Text = "Registros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtgGuia
            // 
            dtgGuia.AllowUserToAddRows = false;
            dtgGuia.AllowUserToDeleteRows = false;
            dtgGuia.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgGuia.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgGuia.BackgroundColor = SystemColors.ActiveCaption;
            dtgGuia.BorderStyle = BorderStyle.Fixed3D;
            dtgGuia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgGuia.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgGuia.GridColor = SystemColors.ActiveCaptionText;
            dtgGuia.Location = new Point(30, 60);
            dtgGuia.Margin = new Padding(4, 3, 4, 3);
            dtgGuia.Name = "dtgGuia";
            dtgGuia.ReadOnly = true;
            dtgGuia.RowHeadersVisible = false;
            dtgGuia.RowHeadersWidth = 51;
            dtgGuia.RowTemplate.Height = 29;
            dtgGuia.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgGuia.Size = new Size(960, 345);
            dtgGuia.TabIndex = 17;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(236, 16);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(356, 28);
            txtFiltro.TabIndex = 14;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(30, 20);
            label1.Name = "label1";
            label1.Size = new Size(346, 24);
            label1.TabIndex = 15;
            label1.Text = "Ingrese descripcion:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(704, 507);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 20;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click_1;
            // 
            // VistaGuiaRemision
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1020, 577);
            ControlBox = false;
            Controls.Add(btnInsertar);
            Controls.Add(button2);
            Controls.Add(lblRegistros);
            Controls.Add(label2);
            Controls.Add(dtgGuia);
            Controls.Add(txtFiltro);
            Controls.Add(label1);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VistaGuiaRemision";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VistaGuiaRemision";
            WindowState = FormWindowState.Maximized;
            Load += VistaGuiaRemision_Load;
            ((System.ComponentModel.ISupportInitialize)dtgGuia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgGuia;
        private TextBox txtFiltro;
        private Label label1;
        private Button btnInsertar;
        private Label label3;
    }
}