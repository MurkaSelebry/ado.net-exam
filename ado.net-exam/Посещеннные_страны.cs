//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ado.net_exam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Посещеннные_страны
    {
        public int VistedCountryId { get; set; }
        public int CountryId { get; set; }
        public int TourId { get; set; }
        public System.DateTime DateOfVisit { get; set; }
    
        public virtual Страны Страны { get; set; }
        public virtual Туры Туры { get; set; }
    }
}
