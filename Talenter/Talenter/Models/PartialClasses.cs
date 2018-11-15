using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using static Talenter.Models.Metadata;

namespace Talenter.Models
{
    public class PartialClasses
    {
        [MetadataType(typeof(TalentoMetadata))]
        public partial class TALENTO
        {

        }

        [MetadataType(typeof(RubroMetadata))]
        public partial class RUBRO
        {

        }

        [MetadataType(typeof(EmpresaMetadata))]
        public partial class EMPRESA
        {

        }
    }
}