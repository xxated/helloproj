//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SocialNetwork.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Address
    {
        public int address_id { get; set; }
        public int profile_id { get; set; }
        public string description { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string province { get; set; }
        public string postal_code { get; set; }
        public int country_id { get; set; }
    
        public virtual Country Country { get; set; }
        public virtual Profile Profile { get; set; }
    }
}