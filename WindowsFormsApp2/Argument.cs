//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Argument
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Argument()
        {
            this.ArguePics = new HashSet<ArguePic>();
        }
    
        public int OrderID { get; set; }
        public int ArgumentID { get; set; }
        public bool ChangeorReturn { get; set; }
        public string Reason { get; set; }
        public int ArgumentTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArguePic> ArguePics { get; set; }
        public virtual ArgumentType ArgumentType { get; set; }
        public virtual Order Order { get; set; }
    }
}
