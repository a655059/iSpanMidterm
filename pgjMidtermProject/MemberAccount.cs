//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace pgjMidtermProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MemberAccount()
        {
            this.Comments = new HashSet<Comment>();
            this.Follows = new HashSet<Follow>();
            this.Follows1 = new HashSet<Follow>();
            this.Likes = new HashSet<Like>();
            this.Orders = new HashSet<Order>();
            this.Products = new HashSet<Product>();
            this.OfficialCoupons = new HashSet<OfficialCoupon>();
        }
    
        public int MemberID { get; set; }
        public string MemberAcc { get; set; }
        public string MemberPw { get; set; }
        public bool TWorNOT { get; set; }
        public int RegionID { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string BackUpEmail { get; set; }
        public string Address { get; set; }
        public string NickName { get; set; }
        public string Name { get; set; }
        public System.DateTime Birthday { get; set; }
        public string Bio { get; set; }
        public byte[] MemPic { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Follow> Follows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Follow> Follows1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Like> Likes { get; set; }
        public virtual RegionList RegionList { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OfficialCoupon> OfficialCoupons { get; set; }
    }
}
