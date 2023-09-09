using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public class LibDeliveryType
    {
        public static List<Spr_DeliveryType> GetDeliveryTypes()
        {
            return LibDB.GetContext().Spr_DeliveryType.ToList();
        }
    }
}
