using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    public static class LibCountry
    {
        public static List<Spr_Country> GetCountries()
        {
            return LibDB.GetContext().Spr_Country.ToList();
        }
    }
}
