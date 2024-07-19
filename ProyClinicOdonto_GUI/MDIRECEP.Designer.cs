using MaterialSkin;
using MaterialSkin.Controls;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIRECEP : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;
        private Panel sideMenuPanel;
        private IconButton btnMantenimientoPacientes;
        private IconButton btnVerEquipos;
        private IconButton btnVerOdontologos;
        private IconButton btnMantenimientoCitas;
        private IconButton btnCerrarSesion;
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
            btnMantenimientoCitas = new IconButton();
            btnVerOdontologos = new IconButton();
            btnVerEquipos = new IconButton();
            btnMantenimientoPacientes = new IconButton();
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
            statusStrip1.Location = new Point(3, 835);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1306, 34);
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
            sideMenuPanel.Controls.Add(btnMantenimientoCitas);
            sideMenuPanel.Controls.Add(btnVerOdontologos);
            sideMenuPanel.Controls.Add(btnVerEquipos);
            sideMenuPanel.Controls.Add(btnMantenimientoPacientes);
            sideMenuPanel.Controls.Add(lblTitle);
            sideMenuPanel.Controls.Add(pictureBoxLogo);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(3, 72);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(250, 763);
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
            btnCerrarSesion.Location = new Point(0, 713);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 50);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += salirToolStripMenuItem_Click;
            // 
            // btnMantenimientoCitas
            // 
            btnMantenimientoCitas.Dock = DockStyle.Top;
            btnMantenimientoCitas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMantenimientoCitas.IconChar = IconChar.CalendarCheck;
            btnMantenimientoCitas.IconColor = Color.FromArgb(26, 188, 156);
            btnMantenimientoCitas.IconFont = IconFont.Auto;
            btnMantenimientoCitas.IconSize = 32;
            btnMantenimientoCitas.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimientoCitas.Location = new Point(0, 416);
            btnMantenimientoCitas.Name = "btnMantenimientoCitas";
            btnMantenimientoCitas.Size = new Size(250, 50);
            btnMantenimientoCitas.TabIndex = 4;
            btnMantenimientoCitas.Text = "Mantenimiento Citas";
            btnMantenimientoCitas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMantenimientoCitas.UseVisualStyleBackColor = true;
            btnMantenimientoCitas.Click += mantenimientoCitas_Click;
            // 
            // btnVerOdontologos
            // 
            btnVerOdontologos.Dock = DockStyle.Top;
            btnVerOdontologos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerOdontologos.IconChar = IconChar.UserMd;
            btnVerOdontologos.IconColor = Color.FromArgb(26, 188, 156);
            btnVerOdontologos.IconFont = IconFont.Auto;
            btnVerOdontologos.IconSize = 32;
            btnVerOdontologos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerOdontologos.Location = new Point(0, 366);
            btnVerOdontologos.Name = "btnVerOdontologos";
            btnVerOdontologos.Size = new Size(250, 50);
            btnVerOdontologos.TabIndex = 3;
            btnVerOdontologos.Text = "Ver Odontólogos";
            btnVerOdontologos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerOdontologos.UseVisualStyleBackColor = true;
            btnVerOdontologos.Click += verOdontologosToolStripMenuItem_Click;
            // 
            // btnVerEquipos
            // 
            btnVerEquipos.Dock = DockStyle.Top;
            btnVerEquipos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerEquipos.IconChar = IconChar.Tools;
            btnVerEquipos.IconColor = Color.FromArgb(26, 188, 156);
            btnVerEquipos.IconFont = IconFont.Auto;
            btnVerEquipos.IconSize = 32;
            btnVerEquipos.ImageAlign = ContentAlignment.MiddleLeft;
            btnVerEquipos.Location = new Point(0, 316);
            btnVerEquipos.Name = "btnVerEquipos";
            btnVerEquipos.Size = new Size(250, 50);
            btnVerEquipos.TabIndex = 2;
            btnVerEquipos.Text = "Ver Equipos";
            btnVerEquipos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnVerEquipos.UseVisualStyleBackColor = true;
            btnVerEquipos.Click += verEquiposToolStripMenuItem_Click;
            // 
            // btnMantenimientoPacientes
            // 
            btnMantenimientoPacientes.Dock = DockStyle.Top;
            btnMantenimientoPacientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnMantenimientoPacientes.IconChar = IconChar.UsersCog;
            btnMantenimientoPacientes.IconColor = Color.FromArgb(26, 188, 156);
            btnMantenimientoPacientes.IconFont = IconFont.Auto;
            btnMantenimientoPacientes.IconSize = 32;
            btnMantenimientoPacientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimientoPacientes.Location = new Point(0, 266);
            btnMantenimientoPacientes.Name = "btnMantenimientoPacientes";
            btnMantenimientoPacientes.Size = new Size(250, 50);
            btnMantenimientoPacientes.TabIndex = 1;
            btnMantenimientoPacientes.Text = "Mant. Pacientes";
            btnMantenimientoPacientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMantenimientoPacientes.UseVisualStyleBackColor = true;
            btnMantenimientoPacientes.Click += mantenimientoPacientes_Click;
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
            // MDIRECEP
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.consultorio_medico_vacio_equipos_e_instrumentos_482257_27314;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1312, 872);
            Controls.Add(sideMenuPanel);
            Controls.Add(statusStrip1);
            ForeColor = Color.FromArgb(6, 147, 227);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            FormStyle = FormStyles.ActionBar_48;
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "MDIRECEP";
            Padding = new Padding(3, 72, 3, 3);
            Sizable = false;
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Recepción";
            WindowState = FormWindowState.Maximized;
            Load += MDIRECEP_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            sideMenuPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}