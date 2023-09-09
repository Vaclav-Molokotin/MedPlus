using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    class LibSignOfResidence
    {
        public static List<Spr_SignOfResidence> GetSignsOfResidences()
        {
            return LibDB.GetContext().Spr_SignOfResidence.ToList();
        }
    }
}
