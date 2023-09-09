using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibDeliveryPeriod
    {
        public static List<Spr_DeliveryPeriod> GetDeliveryPeriods()
        {
            return LibDB.GetContext().Spr_DeliveryPeriod.ToList();
        }
    }
}
