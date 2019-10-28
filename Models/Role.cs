using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace dacodes_APICORE.Models
{
    public class Role: IHasCreation, IHasLastModified
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DefaultValue(true)]
        public bool Active{get; set;}
        public List<User> Users{get;set;}
        public DateTime Created_at {get; set;}
        public DateTime? Updated_at {get; set;}
    }
}