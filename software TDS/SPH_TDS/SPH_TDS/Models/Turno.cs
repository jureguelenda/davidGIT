//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPH_TDS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turno
    {
        public Turno()
        {
            this.PROFESSOR = new HashSet<PROFESSOR>();
        }
    
        public int TURID { get; set; }
        public string TURDESCRICAO { get; set; }
    
        public virtual ICollection<PROFESSOR> PROFESSOR { get; set; }
    }
}
