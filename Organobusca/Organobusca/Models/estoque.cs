namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estoque")]
    public partial class estoque
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? Feirante_id { get; set; }

        public int? Produto_id { get; set; }

        public float? preco { get; set; }

        public virtual feirante feirante { get; set; }

        public virtual produto produto { get; set; }
    }
}
