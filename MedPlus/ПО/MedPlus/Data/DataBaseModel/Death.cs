//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedPlus.Data.DataBaseModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Death
    {
        public int CardID { get; set; }
        public Nullable<System.TimeSpan> TimeDeath { get; set; }
        public Nullable<bool> SignOfAutopsy { get; set; }
        public Nullable<int> AutopsyTypeID { get; set; }
        public Nullable<int> DiagnosisAutopsy { get; set; }
    
        public virtual Spr_AutopsyType Spr_AutopsyType { get; set; }
        public virtual MedCard MedCard { get; set; }
    }
}
