using MedPlus.Data.DataBaseModel;
using MedPlus.Libs.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedPlus.Libs
{
    class LibDocumentType
    {
        public static List<Spr_DocumentType> GetDocumentTypes()
        {
            return LibDB.GetContext().Spr_DocumentType.ToList();
        }
    }
}
