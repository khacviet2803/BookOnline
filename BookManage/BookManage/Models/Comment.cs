//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookManage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int CommentId { get; set; }
        public Nullable<int> BookId { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string IsActive { get; set; }
    
        public virtual Book Book { get; set; }
    }
}
