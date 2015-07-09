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
    
    public partial class PostedCutOff
    {
        public System.Guid Id { get; set; }
        public System.Guid Employee_class_id { get; set; }
        public int PayPeriod { get; set; }
        public int WageScheme { get; set; }
        public int RegularDays { get; set; }
        public int DaysPeryear { get; set; }
        public int HoursPerday { get; set; }
        public System.DateTime Date_Computation { get; set; }
        public System.DateTime CutOffStart { get; set; }
        public System.DateTime CutOffEnd { get; set; }
        public System.DateTime PayDate { get; set; }
        public int PayMonth { get; set; }
        public bool DeductSSS { get; set; }
        public bool DeductHDMF { get; set; }
        public bool DeductPhilhealth { get; set; }
        public bool DeductLoan { get; set; }
        public bool DeductFixedDeduction { get; set; }
        public bool DeductOnetimeDeduction { get; set; }
        public bool AnnualizeTax { get; set; }
        public System.DateTime PostDate { get; set; }
        public System.Guid UserId { get; set; }
    
        public virtual EmployeeClass EmployeeClass { get; set; }
        public virtual User User { get; set; }
    }
}