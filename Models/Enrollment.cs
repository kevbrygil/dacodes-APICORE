using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace dacodes_APICORE.Models
{
    public class Enrollment: IHasCreation, IHasLastModified
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid UserFK { get; set; }
        [ForeignKey("UserFK")]
        public User User{get;set;}
        public Guid CourseFK { get; set; }
        [ForeignKey("CourseFK")]
        public Course Course{get;set;}
        public Guid Lesson_scoreFK { get; set; }
        [ForeignKey("Lesson_scoreFK")]
        public Lesson_score Lesson_Score{get; set;}
        public DateTime Date_of_enrollment{get; set;}
        public DateTime Date_of_completation{get; set;}
        public float Total_score {get; set;}
        public string Status{get; set;}
        [DefaultValue(true)]
        public bool Active{get; set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}