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
    
    public partial class PROFESSOR
    {
        public int PROFID { get; set; }
        public string PROFNOME { get; set; }
        public Nullable<int> TURID { get; set; }
    
        public virtual Turno Turno { get; set; }
    }
}