namespace Organobusca.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("avaliacao")]
    public partial class avaliacao
    {
        public int id { get; set; }

        public int? Cliente_id { get; set; }

        public int? Feirante_id { get; set; }

        public string comentario { get; set; }

        public int? pontuacao { get; set; }

        public virtual cliente cliente { get; set; }

        public virtual feirante feirante { get; set; }
    }
}
