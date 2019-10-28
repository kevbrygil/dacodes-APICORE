using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class User: IHasCreation, IHasLastModified
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Lastname {get; set;}
        [Required]
        public string Password {get; set;}
        public string Cellphone {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        public string Status {get; set;}
        [DefaultValue(true)]
        public bool Active{get; set;}
        public Guid RoleFK { get; set; }
        [ForeignKey("RoleFK")]
        public Role Role{ get; set; }
        public List<Token> Tokens{get;set;}
        public List<Enrollment> Enrollments{get;set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}