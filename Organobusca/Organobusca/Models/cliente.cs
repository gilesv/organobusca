namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("cliente")]
    public partial class cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public cliente()
        {
            avaliacao = new HashSet<avaliacao>();
            preferencia = new HashSet<preferencia>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string nome { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(50)]
        public string senha { get; set; }

        public string url_foto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<avaliacao> avaliacao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<preferencia> preferencia { get; set; }
    }
}
