//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailConfirm
{
    using System;
    using System.Collections.Generic;
    
    public partial class RejectedNote
    {
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string RejectedBy { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Seller_Id { get; set; }
    
        public virtual SellNote SellNote { get; set; }
    }
}
