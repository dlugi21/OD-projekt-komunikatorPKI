//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Komunikator_z_PKI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Historia
    {
        public int id_rozmowy { get; set; }
        public int id_dzwoniacego { get; set; }
        public int id_odbierajacego { get; set; }
        public System.DateTime czas_rozpoczecia { get; set; }
        public System.DateTime czas_zakonczenia { get; set; }
    
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        public virtual Uzytkownicy Uzytkownicy1 { get; set; }
    }
}
