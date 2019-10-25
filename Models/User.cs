using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace dacodes_APICORE.Models
{
    public class User: IHasCreationLastModified
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
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}