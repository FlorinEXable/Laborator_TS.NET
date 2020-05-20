using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Web.Models
{
        public partial class PhotoDTO
        {
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
            [DataMember]
            public int Id { get; set; }
            [DataMember]
            public string Cale { get; set; }
            [DataMember]
            public Nullable<System.DateTime> DataCreare { get; set; }
            [DataMember]
            public string Eveniment { get; set; }
            [DataMember]
            public string Persoane { get; set; }
            [DataMember]
            public string Loc { get; set; }
            [DataMember]
            public string Peisaj { get; set; }
            [DataMember]
            public string Sters { get; set; }
        }

}
