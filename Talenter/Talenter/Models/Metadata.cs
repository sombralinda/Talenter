using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Talenter.Models
{
    public class Metadata
    {
        public class EmpresaMetadata
        {
            [StringLength(50)]
            public string NOMBRE { get; set; }
        }

        public class RubroMetadata
        {
            [StringLength(30)]
            public string DESCRIPCION { get; set; }
        }

        public class TalentoMetadata
        {
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
        }
    }
}