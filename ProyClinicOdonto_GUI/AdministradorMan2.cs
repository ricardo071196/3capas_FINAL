using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class AdministradorMan2 : Form
    {

        ManAdminBL objManAdminBL = new ManAdminBL();
        ManAdminBE objManAdminBE = new ManAdminBE();

        public AdministradorMan2()
        {
            InitializeComponent();
        }
        public String Login_Usuario { get; set; }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            try
            {


                DateTime Fec_Registro = dtpFechaReg.Value;
                //Codifique}
                //Validamos
                if (cboFuente.Text.Trim() == String.Empty)
                {
                    throw new Exception("El rol de usuario es obligatorio");
                }
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del usuario es obligatorio");
                }
                if (txtApellido.Text.Trim() == String.Empty)
                {
                    throw new Exception("El apellido del usuario es obligatorio");
                }
                if (txtLogin_Usuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre de usuario (login) es obligatorio");
                }
                if (txtPass_Usuario.Text.Trim() == String.Empty)
                {
                    throw new Exception("La contraseña del usuario es obligatoria");
                }
                if (cboEstado.Text.Trim() == String.Empty)
                {
                    throw new Exception("El estado del usuario es obligatorio");
                }






                //Cargamos la entidad de negocio
                objManAdminBE.Fuente = cboFuente.Text;
                objManAdminBE.Nombres = txtNombre.Text;
                objManAdminBE.Apellidos = txtApellido.Text;
                objManAdminBE.Login_Usuario = txtLogin_Usuario.Text;
                objManAdminBE.Pass_Usuario = txtPass_Usuario.Text;
                objManAdminBE.Estado = cboEstado.Text;
                objManAdminBE.Fec_Registro = Fec_Registro;
                objManAdminBE.Usu_Registro = Login_Usuario;


                if (objManAdminBL.InsertarUsuario(objManAdminBE) == true)
                {
                    MessageBox.Show("Se registro el usuario exitosamente!!");
                    this.Close();
                }
                else
                {

                    throw new Exception("Registro no se inserto, contacte con el area de TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void AdministradorMan2_Load(object sender, EventArgs e)
        {
            cboFuente.Items.Add("--Seleccionar--");
            cboFuente.Items.Add("Usuario");
            cboFuente.Items.Add("RH");
            cboFuente.Items.Add("Auxalmacen");
            cboFuente.SelectedIndex = 0;
            cboEstado.Items.Add("--Seleccionar--");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.SelectedIndex = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
