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
            DiaDaSemana = new HashSet<DiaDaSemana>();
            Feirante = new HashSet<Feirante>();
        }

        public int id { get; set; }

        [Display(Name = "Nome")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 e no m�ximo 100 caracteres!")]
        [Required(ErrorMessage ="necess�rio preencher o campo!")]
        public string nome { get; set; }

        //[Display(Name = "Bairro")]
        //[StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 e no m�ximo 100 caracteres!")]
        //[Required(ErrorMessage = "necess�rio preencher o campo!")]
        public string bairro { get; set; }

        [Display(Name = "Cidade")]
        [StringLength(45, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 e no m�ximo 45 caracteres!")]
        [Required(ErrorMessage = "necess�rio preencher o campo!")]
        public string cidade { get; set; }

        [Display(Name ="Rua")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 e no m�ximo 100 caracteres!")]
        [Required(ErrorMessage = "necess�rio preencher o campo!")]
        public string rua { get; set; }

        [Display(Name = "CEP")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 e no m�ximo 15 caracteres!")]
        [Required(ErrorMessage = "necess�rio preencher o campo!")]
        public string cep { get; set; }

        [Display(Name ="N�mero")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Requerido no m�nimo 5 caracteres!")]
        [Required(ErrorMessage = "necess�rio preencher o campo!")]
        public string numero { get; set; }

        public float? longitude { get; set; }

        public float? latitude { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiaDaSemana> DiaDaSemana { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feirante> Feirante { get; set; }
    }
}
