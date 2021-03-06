//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace Dal
{
    using System;
    using System.Collections.Generic;
    
    public partial class OgretimUyesi
    {
        public OgretimUyesi()
        {
            this.Asistan = new HashSet<Asistan>();
            this.LiteraturBilgisi = new HashSet<LiteraturBilgisi>();
            this.MezunSonrasiDersBilgileri = new HashSet<MezunSonrasiDersBilgileri>();
            this.SeminerBilgisi = new HashSet<SeminerBilgisi>();
            this.SinavBilgisi = new HashSet<SinavBilgisi>();
        }
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string OgrtmTCkNo { get; set; }
        public string OgrtmAd { get; set; }
        public string OgrtmSoyad { get; set; }
        public string Unvanı { get; set; }
        public int Anadali { get; set; }
        public string Eposta { get; set; }
        public string Cinsiyeti { get; set; }
        public bool Pasif { get; set; }
    
        public virtual ICollection<Asistan> Asistan { get; set; }
        public virtual ICollection<LiteraturBilgisi> LiteraturBilgisi { get; set; }
        public virtual ICollection<MezunSonrasiDersBilgileri> MezunSonrasiDersBilgileri { get; set; }
        public virtual ICollection<SeminerBilgisi> SeminerBilgisi { get; set; }
        public virtual ICollection<SinavBilgisi> SinavBilgisi { get; set; }
    }
}
