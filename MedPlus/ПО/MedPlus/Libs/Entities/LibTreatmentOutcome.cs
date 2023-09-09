using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    class LibTreatmentOutcome
    {
        public static List<Spr_TreatmentOutcome> GetTreatmentOutcomes()
        {
            return LibDB.GetContext().Spr_TreatmentOutcome.ToList();
        }
    }
}
