//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SekolahDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public Nullable<int> StandardId { get; set; }
        public string Gender { get; set; }
    
        public virtual Standard Standard { get; set; }
    }
}
