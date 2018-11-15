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
    using System.ComponentModel.DataAnnotations;

    public partial class TALENTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TALENTO()
        {
            this.EMPRESA = new HashSet<EMPRESA>();
        }
    
        public int ID_TALENTO { get; set; }
        public int ID_RUBRO { get; set; }
        [StringLength(50)]
        public string EMAIL { get; set; }
        [StringLength(50)]
        public string PASSWORD { get; set; }
        [StringLength(50)]
        public string NOMBRE { get; set; }
        [StringLength(50)]
        public string APELLIDO { get; set; }
        [StringLength(100)]
        public string CURRICULUM { get; set; }
    
        public virtual RUBRO RUBRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMPRESA> EMPRESA { get; set; }
    }
}
