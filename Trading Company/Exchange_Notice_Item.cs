//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trading_Company
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exchange_Notice_Item
    {
        public int EN_ID { get; set; }
        public int It_Code { get; set; }
        public int Amount { get; set; }
    
        public virtual Exchange_Notice Exchange_Notice { get; set; }
        public virtual Item Item { get; set; }
    }
}