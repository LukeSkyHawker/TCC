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
    
    public partial class Vagas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vagas()
        {
            this.Aluguel = new HashSet<Aluguel>();
        }
    
        public int ID_Vagas { get; set; }
        public decimal CPF { get; set; }
        public string Status { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public decimal Numero { get; set; }
        public decimal CEP { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aluguel> Aluguel { get; set; }
        public virtual Locador Locador { get; set; }
    }
}
