using MaterialSkin;
using MaterialSkin.Controls;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIAdmin : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Panel sideMenuPanel;
        private IconButton btnMantenimientoUsuarios;
        private IconButton btnSalir;
        private Label lblTitle;
        private PictureBox pictureBoxLogo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblEquipo;
        private ToolStripStatusLabel lblTiempo;
        private ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Timer timer1;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            statusStrip1 = new StatusStrip();
            lblEquipo = new ToolStripStatusLabel();
            lblTiempo = new ToolStripStatusLabel();
            lblUsuario = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBoxLogo = new PictureBox();
            sideMenuPanel = new Panel();
            btnSalir = new IconButton();
            btnMantenimientoUsuarios = new IconButton();
            lblTitle = new Label();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            sideMenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLight;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblEquipo, lblTiempo, lblUsuario });
            statusStrip1.Location = new Point(3, 626);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1153, 34);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblEquipo
            // 
            lblEquipo.BackColor = SystemColors.ActiveCaptionText;
            lblEquipo.ForeColor = SystemColors.ButtonHighlight;
            lblEquipo.Name = "lblEquipo";
            lblEquipo.Size = new Size(59, 28);
            lblEquipo.Text = "Equipo:";
            // 
            // lblTiempo
            // 
            lblTiempo.BackColor = SystemColors.ControlDark;
            lblTiempo.ForeColor = SystemColors.ControlLightLight;
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(63, 28);
            lblTiempo.Text = "Tiempo:";
            // 
            // lblUsuario
            // 
            lblUsuario.BackColor = SystemColors.ActiveCaption;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.ForeColor = Color.Navy;
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(110, 28);
            lblUsuario.Text = "Usuario: ...";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Dock = DockStyle.Top;
            pictureBoxLogo.Image = Properties.Resources.logo;
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(250, 206);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.SkyBlue;
            sideMenuPanel.Controls.Add(btnSalir);
            sideMenuPanel.Controls.Add(btnMantenimientoUsuarios);
            sideMenuPanel.Controls.Add(lblTitle);
            sideMenuPanel.Controls.Add(pictureBoxLogo);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(3, 72);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(250, 554);
            sideMenuPanel.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.Dock = DockStyle.Bottom;
            btnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.IconChar = IconChar.SignOutAlt;
            btnSalir.IconColor = Color.FromArgb(255, 87, 87);
            btnSalir.IconFont = IconFont.Auto;
            btnSalir.IconSize = 32;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 504);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(250, 50);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += saToolStripMenuItem_Click;
            // 
            // btnMantenimientoUsuarios
            // 
            btnMantenimientoUsuarios.Dock = DockStyle.Top;
            btnMantenimientoUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMantenimientoUsuarios.IconChar = IconChar.UsersCog;
            btnMantenimientoUsuarios.IconColor = Color.FromArgb(26, 188, 156);
            btnMantenimientoUsuarios.IconFont = IconFont.Auto;
            btnMantenimientoUsuarios.IconSize = 32;
            btnMantenimientoUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimientoUsuarios.Location = new Point(0, 266);
            btnMantenimientoUsuarios.Name = "btnMantenimientoUsuarios";
            btnMantenimientoUsuarios.Size = new Size(250, 50);
            btnMantenimientoUsuarios.TabIndex = 1;
            btnMantenimientoUsuarios.Text = "Mantenimiento Usuarios";
            btnMantenimientoUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMantenimientoUsuarios.UseVisualStyleBackColor = true;
            btnMantenimientoUsuarios.Click += mantenimientoEquiposToolStripMenuItem_Click;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(0, 206);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ODONPROSMILE";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MDIAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.admin;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1159, 663);
            Controls.Add(sideMenuPanel);
            Controls.Add(statusStrip1);
            ForeColor = Color.FromArgb(6, 147, 227);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            FormStyle = FormStyles.ActionBar_48;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MDIAdmin";
            Padding = new Padding(3, 72, 3, 3);
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Administración de Usuarios";
            WindowState = FormWindowState.Maximized;
            Load += MDIAdmin_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            sideMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}