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
    
    public partial class BILL_INFO
    {
        public int ID { get; set; }
        public int ID_BILL { get; set; }
        public int ID_DRINK { get; set; }
        public int COUNT { get; set; }
    
        public virtual BILL BILL { get; set; }
        public virtual DRINK DRINK { get; set; }
    }
}
