//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Talenter.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPRESA()
        {
            this.TALENTO = new HashSet<TALENTO>();
        }
    
        public int ID_EMPRESA { get; set; }
        public int ID_RUBRO { get; set; }
        public string NOMBRE { get; set; }
        public string ABOUT { get; set; }
    
        public virtual RUBRO RUBRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TALENTO> TALENTO { get; set; }
    }
}
