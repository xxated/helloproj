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
    
    public partial class Comment
    {
        public int comment_id { get; set; }
        public int picture_id { get; set; }
        public int profile_id { get; set; }
        public System.DateTime timestamp { get; set; }
        public string comment1 { get; set; }
        public bool read { get; set; }
    
        public virtual Picture Picture { get; set; }
        public virtual Profile Profile { get; set; }
    }
}
