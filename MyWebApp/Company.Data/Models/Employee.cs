//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Intro { get; set; }
    
        public virtual Social Social { get; set; }
    }
}
