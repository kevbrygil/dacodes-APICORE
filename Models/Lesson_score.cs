using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace dacodes_APICORE.Models
{
    public class Lesson_score: IHasCreation, IHasLastModified
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid EnrollmentFK { get; set; }
        [ForeignKey("EnrollmentFK")]
        public Enrollment Enrollment{get;set;}
        public Guid LessonFK { get; set; }
        [ForeignKey("LessonFK")]
        public Lesson Lesson{get; set;}
        public float Lesson_result {get; set;}
        public int Successful_answers{get; set;}
        public int Unsuccessful_answers{get; set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}