//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coffee_Managerment
{
    using System;
    using System.Collections.Generic;
    
    public partial class DRINK
    {
        public DRINK()
        {
            this.BILL_INFO = new HashSet<BILL_INFO>();
        }
    
        public int ID { get; set; }
        public string NAME { get; set; }
        public int ID_CATEGORY { get; set; }
        public Nullable<double> PRICE { get; set; }
    
        public virtual ICollection<BILL_INFO> BILL_INFO { get; set; }
    }
}
