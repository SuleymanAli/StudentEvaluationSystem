//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentEvaluationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Tasks = new HashSet<Task>();
        }
    
        public int id { get; set; }
        public string student_name { get; set; }
        public string student_surname { get; set; }
        public string student_email { get; set; }
        public int student_phone { get; set; }
        public string student_github_account { get; set; }
        public string student_info { get; set; }
        public string student_photo { get; set; }
        public Nullable<double> student_cap_point { get; set; }
        public int student_group_id { get; set; }
        public int student_gender_id { get; set; }
        public string student_password { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Group Group { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Task> Tasks { get; set; }
    }
}
