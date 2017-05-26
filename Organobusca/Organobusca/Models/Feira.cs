namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feira")]
    public partial class Feira
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feira()
        {
            diadasemana = new HashSet<diadasemana>();
            feirante = new HashSet<feirante>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string bairro { get; set; }

        [StringLength(45)]
        public string cidade { get; set; }

        [StringLength(100)]
        public string rua { get; set; }

        [StringLength(15)]
        public string cep { get; set; }

        [StringLength(5)]
        public string numero { get; set; }

        public float? logintude { get; set; }

        public float? latitudade { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<diadasemana> diadasemana { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<feirante> feirante { get; set; }
    }
}
