using Microsoft.VisualBasic.Devices;
using ProyVentas_GUI;

namespace ProyClinicOdonto_GUI
{
    public partial class MDIAdmin : MaterialSkin.Controls.MaterialForm
    {
        TimeSpan horaInicio = new TimeSpan();
        Computer miComputadora = new Computer();
        String strMensajeRed;

        public MDIAdmin()
        {
            InitializeComponent();
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = "Aplicación Clinica - Hora Actual : " + DateTime.Now;
            lblTiempo.Text = "Tiempo: " + DateTime.Now.TimeOfDay.Subtract(horaInicio).ToString().Substring(0, 8);
        }

        private void MDIAdmin_Load(object sender, EventArgs e)
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
            if (clsCredencialesADMIN.Login_Usuario != null)
            {
                lblUsuario.Text = "Usuario: " + clsCredencialesADMIN.Login_Usuario;
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

        private void mantenimientoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdministradorMan1 objAdmin1 = new AdministradorMan1();
            objAdmin1.MdiParent = this;
            objAdmin1.Show();
        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo de confirmación
            DialogResult result = MessageBox.Show("¿Seguro que desea cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Comprobar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Si el usuario elige 'Sí', cerrar la sesión (cerrar la aplicación)
                this.Close();
            }
            frmLogin objLogin = new frmLogin();
            objLogin.Show();
        }
    }
}
