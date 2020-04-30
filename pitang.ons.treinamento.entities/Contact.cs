using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pitang.ons.treinamento.entities
{
    [Table("contact")]
    public class Contact : AuditEntity
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        public string Nick { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        public long ContactUserId { get; set; }
        public virtual User ContactUser { get; set; }
       
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public long OwnerId { get; set; }
        public virtual User Owner { get; set; }
    }
}