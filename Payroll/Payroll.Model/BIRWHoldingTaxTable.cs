//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Payroll.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class BIRWHoldingTaxTable
    {
        public System.Guid Id { get; set; }
        public int PayScheme { get; set; }
        public System.Guid BIRTaxExemptionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Rate { get; set; }
        public decimal Base { get; set; }
    
        public virtual BIRTaxExemption BIRTaxExemption { get; set; }
    }
}
