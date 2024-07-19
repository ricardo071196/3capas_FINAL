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
    public partial class AdministradorMan3 : Form
    {
        private ManAdminBL objManAdminBL = new ManAdminBL();
        private ManAdminBE objManAdminBE;

        public AdministradorMan3()
        {
            InitializeComponent();
        }

        public string User { get; set; }

        private void grpDatos_Enter(object sender, EventArgs e)
        {
            // Este método parece no hacer nada, puedes eliminarlo si no es necesario
        }

        private void AdministradorMan3_Load(object sender, EventArgs e)
        {
            try
            {
                // Verifica que User no sea nulo ni vacío
                if (string.IsNullOrEmpty(this.User))
                {
                    throw new Exception("El usuario no está especificado.");
                }

                // Carga los datos del usuario a actualizar
                objManAdminBE = objManAdminBL.ConsultarUsuarioDatos(this.User);

                // Verifica que objManAdminBE no sea nulo
                if (objManAdminBE == null)
                {
                    throw new Exception("No se encontraron datos para el usuario especificado.");
                }

                // Asigna los valores a los controles
                lblLogin.Text = objManAdminBE.Login_Usuario ?? "Usuario no encontrado";
                txtPass_Usuario.Text = objManAdminBE.Pass_Usuario ?? string.Empty;

                // Llena el ComboBox de estado
                cboEstado.Items.Clear();
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");

                // Selecciona el estado actual del usuario en el ComboBox
                if (!string.IsNullOrEmpty(objManAdminBE.Estado))
                {
                    cboEstado.SelectedItem = objManAdminBE.Estado;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica que se hayan ingresado los datos obligatorios
                if (string.IsNullOrEmpty(txtPass_Usuario.Text))
                {
                    throw new Exception("Debe ingresar una contraseña.");
                }

                if (cboEstado.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un estado.");
                }

                // Obtiene los valores ingresados por el usuario
                string passUsuario = txtPass_Usuario.Text;
                string estado = cboEstado.SelectedItem.ToString();

                // Actualiza los datos del usuario
                objManAdminBE.Pass_Usuario = passUsuario;
                objManAdminBE.Estado = estado;

                // Llama al método de la capa de negocio para actualizar el usuario en la base de datos
                if (objManAdminBL.ActualizarUsuarioDatos(objManAdminBE))
                {
                    MessageBox.Show("Usuario actualizado correctamente.");
                    this.Close();
                }
                else
                {
                    throw new Exception("No se pudo actualizar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }
}
}
