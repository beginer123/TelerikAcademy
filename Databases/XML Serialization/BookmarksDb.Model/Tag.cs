//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookmarksDb.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tag
    {
        public Tag()
        {
            this.Bookmarks = new HashSet<Bookmark>();
        }
    
        public int TagId { get; set; }
        public string TagWord { get; set; }
    
        public virtual ICollection<Bookmark> Bookmarks { get; set; }
    }
}
