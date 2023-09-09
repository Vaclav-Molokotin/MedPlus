using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    class LibLPU
    {
        public static List<Spr_SendingOrganisation> GetAllLPU()
        {
            return LibDB.GetContext().Spr_SendingOrganisation.ToList();
        }
    }
}
