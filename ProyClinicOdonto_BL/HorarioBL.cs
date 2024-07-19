using ProyClinicOdonto_ADO;
using ProyClinicOdonto_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyClinicOdonto_BL
{
    public class HorarioBL
    {
        HorarioADO objHorarioADO = new HorarioADO();

        public DataTable HorarioLista()
        {
            return objHorarioADO.HorarioLista();
        }

        public Boolean InsertarHorario(HorarioBE objHorarioBE)
        {
            return objHorarioADO.InsertarHorario(objHorarioBE);
        }
    }
}
