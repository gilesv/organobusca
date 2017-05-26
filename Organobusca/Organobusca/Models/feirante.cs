namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("feirante")]
    public partial class feirante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public feirante()
        {
            avaliacao = new HashSet<avaliacao>();
            estoque = new HashSet<estoque>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(100)]
        public string senha { get; set; }

        [StringLength(200)]
        public string site { get; set; }

        [StringLength(600)]
        public string url_foto { get; set; }

        public int? Feira_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<avaliacao> avaliacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<estoque> estoque { get; set; }

        public virtual Feira Feira { get; set; }
    }
}
