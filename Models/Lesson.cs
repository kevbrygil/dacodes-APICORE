using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class Lesson: IHasCreation, IHasLastModified
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name{get; set;}
        public string Description{get; set;}
        public string Question_details{get; set;}
        public string Code{get; set;}
        public int Order{get; set;}
        public int Hours{get; set;}
        [DefaultValue(1)]
        public int Score{get; set;}
        public Guid CourseFK { get; set; }
        [ForeignKey("CourseFK")]
        public Course Course{ get; set; }
        public Guid Created_by{get; set;}
        public Guid Updated_by{get; set;}
        [DefaultValue(true)]
        public bool Active{get; set;}
        public int Aproval_score{get; set;}
        public List<Question> Questions{get;set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}