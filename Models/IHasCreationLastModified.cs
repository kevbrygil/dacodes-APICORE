using System;

namespace dacodes_APICORE.Models
{
    internal interface IHasCreationLastModified
    {
        public DateTime Created_at { get; set; }
        public DateTime? Updated_at { get; set; }
    }
}