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
    public partial class HorarioMan1 : Form
    {
        HorarioBL objHorarioBL = new HorarioBL();
        HorarioBE objHorarioBE = new HorarioBE();
        public HorarioMan1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                //Cargamos la entidad de negocio
                objHorarioBE.Idodontologo = txtID.Text;
                objHorarioBE.Lunes = txtLunes.Text;
                objHorarioBE.Martes = txtMartes.Text;
                objHorarioBE.Miércoles = txtMiercoles.Text;
                objHorarioBE.Jueves = txtJueves.Text;
                objHorarioBE.Viernes = txtViernes.Text;
                objHorarioBE.Sábado = txtSabado.Text;

                if (objHorarioBL.InsertarHorario(objHorarioBE) == true)
                {
                    MessageBox.Show("Se registro el turno exitosamente!!");
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
    }
}
