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
    
    public partial class Aluguel
    {
        public int ID_Aluguel { get; set; }
        public Nullable<int> ID_Locatario { get; set; }
        public Nullable<int> ID_Vagas { get; set; }
        public Nullable<System.DateTime> Data_Início { get; set; }
        public Nullable<System.DateTime> Data_Fim { get; set; }
    
        public virtual Locatario Locatario { get; set; }
        public virtual Vagas Vagas { get; set; }
    }
}