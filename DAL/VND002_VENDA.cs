//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class VND002_VENDA
    {
     

        public int IdeVenda { get; set; }
        public int IdeVendedor { get; set; }
        public int IdeModeloVersao { get; set; }
        public decimal VlrPrecoVenda { get; set; }
        public bool StaValeCombustivel { get; set; }
    
        public virtual VEI004_MODELO_VERSAO VEI004_MODELO_VERSAO { get; set; }
        public virtual VND001_VENDEDOR VND001_VENDEDOR { get; set; }
    }
}
