//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KhMedium.Entities;

namespace KhMedium.Models
{
    using System;
    using System.Collections.Generic;
    
    public class Tag
    {
        public Tag()
        {
            this.ArticleTags = new List<ArticleTag>();
        }
    
        public string Id { get; set; }
        public string Name { get; set; }
        public System.DateTime CreatedAt { get; set; }
    
        public virtual ICollection<ArticleTag> ArticleTags { get; set; }
    }
}