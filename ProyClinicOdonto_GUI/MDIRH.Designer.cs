using MaterialSkin;
using MaterialSkin.Controls;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIRH : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Panel sideMenuPanel;
        private IconButton btnMantenimientoOdontologos;
        private IconButton btnCerrarSesion;
        private IconButton btnHorarios;
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
            btnCerrarSesion = new IconButton();
            btnMantenimientoOdontologos = new IconButton();
            btnHorarios = new IconButton();
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
            statusStrip1.Location = new Point(3, 771);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1188, 34);
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
            sideMenuPanel.Controls.Add(btnCerrarSesion);
            sideMenuPanel.Controls.Add(btnMantenimientoOdontologos);
            sideMenuPanel.Controls.Add(btnHorarios);
            sideMenuPanel.Controls.Add(lblTitle);
            sideMenuPanel.Controls.Add(pictureBoxLogo);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(3, 72);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(250, 699);
            sideMenuPanel.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrarSesion.IconChar = IconChar.SignOutAlt;
            btnCerrarSesion.IconColor = Color.FromArgb(255, 87, 87);
            btnCerrarSesion.IconFont = IconFont.Auto;
            btnCerrarSesion.IconSize = 32;
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(0, 649);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 50);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += salirToolStripMenuItem_Click;
            // 
            // btnMantenimientoOdontologos
            // 
            btnMantenimientoOdontologos.Dock = DockStyle.Top;
            btnMantenimientoOdontologos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMantenimientoOdontologos.IconChar = IconChar.UsersCog;
            btnMantenimientoOdontologos.IconColor = Color.FromArgb(26, 188, 156);
            btnMantenimientoOdontologos.IconFont = IconFont.Auto;
            btnMantenimientoOdontologos.IconSize = 32;
            btnMantenimientoOdontologos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimientoOdontologos.Location = new Point(0, 316);
            btnMantenimientoOdontologos.Name = "btnMantenimientoOdontologos";
            btnMantenimientoOdontologos.Size = new Size(250, 50);
            btnMantenimientoOdontologos.TabIndex = 3;
            btnMantenimientoOdontologos.Text = "Mant. Odontólogos";
            btnMantenimientoOdontologos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMantenimientoOdontologos.UseVisualStyleBackColor = true;
            btnMantenimientoOdontologos.Click += mantenimientoEquiposToolStripMenuItem_Click;
            // 
            // btnHorarios
            // 
            btnHorarios.Dock = DockStyle.Top;
            btnHorarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnHorarios.IconChar = IconChar.UserShield;
            btnHorarios.IconColor = Color.FromArgb(26, 188, 156);
            btnHorarios.IconFont = IconFont.Auto;
            btnHorarios.IconSize = 32;
            btnHorarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnHorarios.Location = new Point(0, 266);
            btnHorarios.Name = "btnHorarios";
            btnHorarios.Size = new Size(250, 50);
            btnHorarios.TabIndex = 4;
            btnHorarios.Text = "Horarios Odontólogos";
            btnHorarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHorarios.UseVisualStyleBackColor = true;
            btnHorarios.Click += btnHorarios_Click;
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
            // MDIRH
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.recursos;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1194, 808);
            Controls.Add(sideMenuPanel);
            Controls.Add(statusStrip1);
            ForeColor = Color.FromArgb(6, 147, 227);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            FormStyle = FormStyles.ActionBar_48;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MDIRH";
            Padding = new Padding(3, 72, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Recursos Humanos";
            WindowState = FormWindowState.Maximized;
            Load += MDIRH_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            sideMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
