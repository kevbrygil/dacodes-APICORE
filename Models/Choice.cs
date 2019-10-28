using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class Choice: IHasCreation, IHasLastModified
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey("QuestionFK")]
        public Lesson Questions{ get; set; }
        public bool Is_correct{get; set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}