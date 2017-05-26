namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("preferencia")]
    public partial class preferencia
    {
        public int id { get; set; }

        public int? Produto_id { get; set; }

        public int? Cliente_id { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual produto produto { get; set; }
    }
}
