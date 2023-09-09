using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    class LibSignOfDischarge
    {
        public static List<Spr_SignOfDischarge> GetSignsOfDischarge()
        {
            return LibDB.GetContext().Spr_SignOfDischarge.ToList();
        }
    }
}
