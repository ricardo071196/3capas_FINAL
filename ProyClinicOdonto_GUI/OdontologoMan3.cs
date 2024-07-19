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
    public partial class OdontologoMan3 : Form
    {
        OdontologoBL objOdontologoBL = new OdontologoBL();
        OdontologoBE objOdontologoBE = new OdontologoBE();
        EspecialidadBL objEspecialidadBL = new EspecialidadBL();
        DistritoBL objDistritoBL = new DistritoBL();
        public OdontologoMan3()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }






        private void optActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OdontologoMan3_Load_1(object sender, EventArgs e)
        {


            try
            {
                // Primero, asigna los datos al ComboBox cboDistrito
                DataTable dt = objDistritoBL.ListarDistrito();
                DataRow dr = dt.NewRow();
                dr["IdDist"] = 0;
                dr["Nombre"] = "--Seleccionar--";
                dt.Rows.InsertAt(dr, 0);
                cboDistrito.DataSource = dt;
                cboDistrito.DisplayMember = "Nombre";
                cboDistrito.ValueMember = "IdDist";

                // Luego, consulta y muestra los datos del odontólogo
                objOdontologoBE = objOdontologoBL.ConsultarOdontologos(this.Codigo);
                lbCodOdo.Text = Codigo;
                lblNombre.Text = objOdontologoBE.Nombres;
                lblApellido.Text = objOdontologoBE.Apellidos;
                lblGenero.Text = objOdontologoBE.Genero;
                lblCOP.Text = objOdontologoBE.COP;
                txtObservacion.Text = objOdontologoBE.Observacion;
                txtEmail.Text = objOdontologoBE.email;
                txtDireccion.Text = objOdontologoBE.direccion;
                mskTelefono.Text = objOdontologoBE.telefono;
                cboDistrito.SelectedValue = objOdontologoBE.IdDist;
                // Establece el estado del RadioButton basado en el valor del objeto OdontologoBE
                if (objOdontologoBE.Estado == true)
                {
                    optActivo.Checked = true;
                }
                else
                {
                    optInactivo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {

            try
            {


                Boolean activo;
                if (optActivo.Checked == true)
                {
                    activo = true;
                }
                else
                {
                    activo = false;
                }

                if (txtEmail.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa un correo electrónico:");
                }
                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("Ingresa una dirección:");
                }
                objOdontologoBE.email = txtEmail.Text;
                objOdontologoBE.direccion = txtDireccion.Text;
                objOdontologoBE.IdDist = cboDistrito.SelectedValue.ToString();
                objOdontologoBE.telefono = mskTelefono.Text;
                objOdontologoBE.Observacion = txtObservacion.Text;
                objOdontologoBE.Estado = activo;

                //objprofesorBE.FecIng = fechaIng;
                //objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                if (objOdontologoBL.ActualizarOdontologos(objOdontologoBE) == true)
                {
                    MessageBox.Show("Se actualizaron los datos del odontologo exitosamente!!");
                    this.Close();
                }
                else
                {
                    throw new Exception("No se insertaron los datos correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtUsuUltMod_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
