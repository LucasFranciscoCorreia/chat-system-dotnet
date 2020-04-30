using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace pitang.ons.treinamento.entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
