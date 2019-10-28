using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace dacodes_APICORE.Models
{
    public class Token: IHasCreation
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid UserFK { get; set; }
        [ForeignKey("UserFK")]
        public User User{ get; set; }
        public string Access_token { get; set; }
        public string Refresh_token { get; set; }
        public long Access_token_expires_at{ get; set;}
        public long Issued_at{ get; set;}
        public long Refresh_token_expires_in{ get; set;}
        public DateTime Created_at {get; set;}
    }
}