using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Numerics;

namespace dacodes_APICORE.Models
{
    public class Token: IHasCreation
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [ForeignKey("UserFK")]
        public User User{ get; set; }
        public string Access_token { get; set; }
        public string Refresh_token { get; set; }
        public BigInteger Access_token_expires_at{ get; set;}
        public BigInteger Issued_at{ get; set;}
        public BigInteger Refresh_token_expires_in{ get; set;}
        public DateTime Created_at {get; set;}
    }
}