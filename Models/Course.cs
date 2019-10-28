using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class Course: IHasCreation, IHasLastModified
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name{get; set;}
        public string Description{get; set;}
        public string Code{get; set;}
        public Guid[] Mandatory_courses{get; set;}
        public string[] Mandatory_courses_code{get; set;}
        public int Credits{get; set;}
        public Guid Created_by{get; set;}
        public Guid Updated_by{get; set;}
        public float Approval_score{get; set;}
        [DefaultValue(true)]
        public bool Active{get; set;}
        public List<Lesson> Lessons{get;set;}
        public List<User> Users{get;set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}