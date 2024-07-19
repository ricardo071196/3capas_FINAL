namespace ProyClinicOdonto_GUI
{
    partial class VistaHorario
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
            button1 = new Button();
            lblRegistros = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dtgOdontologo = new DataGridView();
            btnInsertar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgOdontologo).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.Crimson;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(796, 447);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 54);
            button1.TabIndex = 30;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblRegistros
            // 
            lblRegistros.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRegistros.BorderStyle = BorderStyle.Fixed3D;
            lblRegistros.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegistros.ForeColor = SystemColors.ControlText;
            lblRegistros.Location = new Point(796, 362);
            lblRegistros.Margin = new Padding(4, 0, 4, 0);
            lblRegistros.Name = "lblRegistros";
            lblRegistros.Size = new Size(139, 54);
            lblRegistros.TabIndex = 26;
            lblRegistros.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(649, 362);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 54);
            label1.TabIndex = 29;
            label1.Text = "Registros:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(325, 12);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(347, 28);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Location = new Point(29, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(342, 24);
            label2.TabIndex = 28;
            label2.Text = "Ingrese el nombre odontologo:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtgOdontologo
            // 
            dtgOdontologo.AllowUserToAddRows = false;
            dtgOdontologo.AllowUserToDeleteRows = false;
            dtgOdontologo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dtgOdontologo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgOdontologo.BackgroundColor = SystemColors.ActiveCaption;
            dtgOdontologo.BorderStyle = BorderStyle.Fixed3D;
            dtgOdontologo.ColumnHeadersHeight = 29;
            dtgOdontologo.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dtgOdontologo.Location = new Point(29, 57);
            dtgOdontologo.Margin = new Padding(4, 3, 4, 3);
            dtgOdontologo.Name = "dtgOdontologo";
            dtgOdontologo.ReadOnly = true;
            dtgOdontologo.RowHeadersVisible = false;
            dtgOdontologo.RowHeadersWidth = 51;
            dtgOdontologo.RowTemplate.Height = 29;
            dtgOdontologo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgOdontologo.Size = new Size(906, 288);
            dtgOdontologo.TabIndex = 27;
            // 
            // btnInsertar
            // 
            btnInsertar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsertar.BackColor = Color.ForestGreen;
            btnInsertar.ForeColor = SystemColors.ButtonHighlight;
            btnInsertar.Location = new Point(636, 446);
            btnInsertar.Margin = new Padding(5, 4, 5, 4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(139, 54);
            btnInsertar.TabIndex = 31;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // VistaHorario
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Azure;
            ClientSize = new Size(969, 513);
            Controls.Add(btnInsertar);
            Controls.Add(button1);
            Controls.Add(lblRegistros);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(dtgOdontologo);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            MinimizeBox = false;
            Name = "VistaHorario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Horarios";
            WindowState = FormWindowState.Maximized;
            Load += VistaHorario_Load;
            ((System.ComponentModel.ISupportInitialize)dtgOdontologo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblRegistros;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dtgOdontologo;
        private Button btnInsertar;
    }
}