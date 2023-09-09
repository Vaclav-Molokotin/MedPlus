using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibSocialStatus
    {
        public static List<Spr_SocialStatus> GetSocialStatuses()
        {
            return LibDB.GetContext().Spr_SocialStatus.ToList();
        }
    }
}
