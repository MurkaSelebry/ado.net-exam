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
    
    public partial class Туры
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Туры()
        {
            this.Сотрудники_привязаныне_к_странам__турам = new HashSet<Сотрудники_привязаныне_к_странам__турам>();
            this.Гостиницы_для_тура = new HashSet<Гостиницы_для_тура>();
            this.Достопримечательности = new HashSet<Достопримечательности>();
            this.Посещеннные_города = new HashSet<Посещеннные_города>();
            this.Посещеннные_страны = new HashSet<Посещеннные_страны>();
        }
    
        public int TourId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public System.DateTime DateOfStart { get; set; }
        public System.DateTime DateOfEnd { get; set; }
        public string TransportMethods { get; set; }
        public string PaidCustomers { get; set; }
        public int MaxCustomersNumber { get; set; }
        public string PotentialCustomers { get; set; }
        public int EmployerId { get; set; }
        public string FIOEmployer { get; set; }
    
        public virtual Работники_турагентства Работники_турагентства { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Сотрудники_привязаныне_к_странам__турам> Сотрудники_привязаныне_к_странам__турам { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Гостиницы_для_тура> Гостиницы_для_тура { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Достопримечательности> Достопримечательности { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Посещеннные_города> Посещеннные_города { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Посещеннные_страны> Посещеннные_страны { get; set; }
    }
}
