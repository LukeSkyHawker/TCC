//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CentralParking.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Veiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Veiculo()
        {
            this.Locatario = new HashSet<Locatario>();
        }
    
        public int ID_Veiculo { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Tamanho_Veiculo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Locatario> Locatario { get; set; }
    }
}
