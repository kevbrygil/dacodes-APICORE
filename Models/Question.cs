using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class Question: IHasCreation, IHasLastModified
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Description{get; set;}
        public string Code{get; set;}
        public int Score{get; set;}
        public Guid LessonFK { get; set; }
        [ForeignKey("LessonFK")]
        public Lesson Lessons{ get; set; }
        public string Type_question{get; set;}    
        public Guid Created_by{get; set;}
        [DefaultValue(true)]
        public bool Active{get; set;}
        public string[] Answers{ get; set;}
        public List<Choice> Choices{get;set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}