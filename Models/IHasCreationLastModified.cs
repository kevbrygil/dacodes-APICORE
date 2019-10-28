using System;

namespace dacodes_APICORE.Models
{
    internal interface IHasCreation
    {
        public DateTime Created_at { get; set; }
    }
    internal interface IHasLastModified
    {
        public DateTime? Updated_at { get; set; }
    }
}