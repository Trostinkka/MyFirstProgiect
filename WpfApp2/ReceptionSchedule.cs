//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceptionSchedule
    {
        public int id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string OMC_policy { get; set; }
        public string Phone { get; set; }
    
        public virtual EntranceEmployee EntranceEmployee { get; set; }
        public virtual Registration Registration { get; set; }
        public virtual Services Services { get; set; }
    }
}