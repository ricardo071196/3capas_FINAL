using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIRECEP : MaterialSkin.Controls.MaterialForm
    {

        TimeSpan horaInicio = new TimeSpan();
        Computer miComputadora = new Computer();
        String strMensajeRed;

        public MDIRECEP()
        {
            InitializeComponent();
        }

        private void mantenimientoPacientes_Click(object sender, EventArgs e)
        {
            PacienteMan1 objPacienteMan1 = new PacienteMan1();
            objPacienteMan1.MdiParent = this;
            objPacienteMan1.Show();

        }

        private void mantenimientoCitas_Click(object sender, EventArgs e)
        {
            ReservaMan1 reservaMan1 = new ReservaMan1();
            reservaMan1.MdiParent = this;
            reservaMan1.Show();
        }

        private void MDIRECEP_Load(object sender, EventArgs e)
        {

            if (clsCredenciales.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredenciales.Login_Usuario;
            }
            if (clsCredencialesAUX.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesAUX.Login_Usuario;
            }
            if (clsCredencialesRH.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesRH.Login_Usuario;
            }

            horaInicio = DateTime.Now.TimeOfDay;
            if (miComputadora.Network.IsAvailable == true)
            {
                strMensajeRed = "Equipo con conexion disponible";
            }
            else
            {
                strMensajeRed = "Equipo sin conexion disponible";
            }

            lblEquipo.Text = "Equipo : " + miComputadora.Name + "." + strMensajeRed;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige 'Sí', cerrar la sesión (cerrar la aplicación)
                this.Close();
            }
            // Si el usuario elige 'No', no hacer nada (quedarse en la aplicación)
        }

        private void MDIprincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir de la aplicación", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Aplicación Clinica - Hora Actual : " + DateTime.Now;
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaInicio).ToString().Substring(0, 8);
        }

        private void verEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaEquipo objVistaEquipo1 = new VistaEquipo();
            objVistaEquipo1.MdiParent = this;
            objVistaEquipo1.Show();
        }

        private void verOdontologosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VistaOdontologo objVistaOdontologo1 = new VistaOdontologo();
            objVistaOdontologo1.MdiParent = this;
            objVistaOdontologo1.Show();
        }
    }
}
