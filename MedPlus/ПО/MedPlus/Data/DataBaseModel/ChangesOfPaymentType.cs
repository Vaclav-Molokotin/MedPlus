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
    
    public partial class ChangesOfPaymentType
    {
        public int ID { get; set; }
        public int OldPaymentTypeID { get; set; }
        public int NewPaymentTypeID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DateTime { get; set; }
        public int CardID { get; set; }
    
        public virtual MedCard MedCard { get; set; }
        public virtual Spr_PaymentType Spr_PaymentType { get; set; }
        public virtual Spr_PaymentType Spr_PaymentType1 { get; set; }
        public virtual User User { get; set; }
    }
}
