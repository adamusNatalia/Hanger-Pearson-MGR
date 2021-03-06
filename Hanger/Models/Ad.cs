﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hanger.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Ad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ad()
        {
            this.Photos = new HashSet<Photos>();
            this.Tags = new HashSet<Tags>();
            this.Favourite = new HashSet<Favourite>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        [Required(ErrorMessage = "Prosze wprowadŸ cenê", AllowEmptyStrings = false)]
        [RegularExpression(@"^[-+]?[0-9]*\,?[0-9]+([eE][-+]?[0-9]+)?$", ErrorMessage = "Prosze wprowadY poprawn1 wartooa")]
        [DisplayName("Cena")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Proszê wprowadŸ tytu³", AllowEmptyStrings = false)]
        [DisplayName("Tytu³ og³oszenia")]
        public string Title { get; set; }
        [DisplayName("Opis og³oszenia")]
        public string Description { get; set; }
        public Nullable<System.DateTime> Date_start { get; set; }
        [Required(ErrorMessage = "Prosze wybierz rozmiar", AllowEmptyStrings = false)]
        [DisplayName("Rozmiar")]
        public int SizeId { get; set; }
        [Required(ErrorMessage = "Prosze wybierz kolor", AllowEmptyStrings = false)]
        [DisplayName("Kolor")]
        public int ColorId { get; set; }
        [Required(ErrorMessage = "Prosze wybierz kategoriê", AllowEmptyStrings = false)]
        [DisplayName("Kategoria")]
        public int SubcategoryId { get; set; }
        [Required(ErrorMessage = "Prosze wybierz w jakim stanie jest produkt", AllowEmptyStrings = false)]
        [DisplayName("Stan")]
        public int ConditionId { get; set; }
        [DisplayName("Mo¿liwoœæ wymiany")]
        public Nullable<bool> Swap { get; set; }
        [DisplayName("Marka")]
        public Nullable<int> BrandId { get; set; }
        public Nullable<bool> Is_sold { get; set; }
        public Nullable<System.DateTime> Date_end { get; set; }
        public Nullable<int> Counter { get; set; }
    
        public virtual Condition Condition { get; set; }
        public virtual Size Size { get; set; }
        public virtual Color Color { get; set; }
        public virtual User User { get; set; }
        public virtual Subcategory Subcategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Photos> Photos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tags> Tags { get; set; }
        public virtual Brand Brand { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Favourite> Favourite { get; set; }
    }
}
