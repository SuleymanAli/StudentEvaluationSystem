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
    
    public partial class Task
    {
        public int id { get; set; }
        public int task_type_id { get; set; }
        public System.DateTime task_start_date { get; set; }
        public System.DateTime task_end_date { get; set; }
        public int task_point { get; set; }
        public string task_source { get; set; }
        public string task_note { get; set; }
        public int task_group_id { get; set; }
        public int task_student_id { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Student Student { get; set; }
        public virtual Task_Types Task_Types { get; set; }
    }
}
