using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibHospitalizationType
    {
        public static List<Spr_HospitalizationType> GetHospitaliztionTypes()
        {
            return LibDB.GetContext().Spr_HospitalizationType.ToList();
        }
    }
}
