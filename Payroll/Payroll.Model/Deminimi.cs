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
    
    public partial class Deminimi
    {
        public System.Guid Id { get; set; }
        public System.Guid EmployerId { get; set; }
        public string ext_id { get; set; }
        public string description { get; set; }
        public decimal TaxCeiling { get; set; }
        public bool IsActive { get; set; }
    
        public virtual Employer Employer { get; set; }
    }
}