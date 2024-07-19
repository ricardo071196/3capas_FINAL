namespace ProyClinicOdonto_GUI
{
    partial class VistaEquipo
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
            dtgEquipo = new DataGridView();
            txtFiltro = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(570, 451);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(139, 54);
            button2.TabIndex = 13;
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
            lblRegistros.Location = new Point(864, 451);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(139, 54);
            lblRegistros.TabIndex = 8;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(717, 451);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 54);
            label2.TabIndex = 12;
            label2.Text = "Registros:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            dtgEquipo.Location = new Point(52, 63);
            dtgEquipo.Margin = new Padding(4, 3, 4, 3);
            dtgEquipo.Name = "dtgEquipo";
            dtgEquipo.ReadOnly = true;
            dtgEquipo.RowHeadersVisible = false;
            dtgEquipo.RowHeadersWidth = 51;
            dtgEquipo.RowTemplate.Height = 29;
            dtgEquipo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgEquipo.Size = new Size(951, 379);
            dtgEquipo.TabIndex = 10;
            // 
            // txtFiltro
            // 
            txtFiltro.Cursor = Cursors.IBeam;
            txtFiltro.Location = new Point(317, 25);
            txtFiltro.Margin = new Padding(4, 3, 4, 3);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(356, 24);
            txtFiltro.TabIndex = 6;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // label1
            // 
            label1.Location = new Point(50, 24);
            label1.Name = "label1";
            label1.Size = new Size(242, 24);
            label1.TabIndex = 7;
            label1.Text = "Ingrese el Nombre de Equipo:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VistaEquipo
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(1028, 514);
            Controls.Add(button2);
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
            Name = "VistaEquipo";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Equipos";
            WindowState = FormWindowState.Maximized;
            Load += VistaEquipo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEquipo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Label lblRegistros;
        private Label label2;
        private DataGridView dtgEquipo;
        private TextBox txtFiltro;
        private Label label1;
    }
}