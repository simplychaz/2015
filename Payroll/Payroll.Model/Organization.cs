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
    
    public partial class Organization
    {
        public Organization()
        {
            this.Employees = new HashSet<Employee>();
            this.Organizations1 = new HashSet<Organization>();
        }
    
        public System.Guid Id { get; set; }
        public string ext_id { get; set; }
        public System.Guid ParentId { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Organization> Organizations1 { get; set; }
        public virtual Organization Organization1 { get; set; }
    }
}
