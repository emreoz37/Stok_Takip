//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Software_Testing_LastProject.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Demirbaslar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Demirbaslar()
        {
            this.Demirbas_Oda = new HashSet<Demirbas_Oda>();
        }
    
        public int DemirbasNo { get; set; }
        public Nullable<int> UrunId { get; set; }
        public string DemirbasKodu { get; set; }
        public string DemirbasAdi { get; set; }
        public Nullable<int> DemirbasAdedi { get; set; }
        public string DemirbasAciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Demirbas_Oda> Demirbas_Oda { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
