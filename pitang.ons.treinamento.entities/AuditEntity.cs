using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace pitang.ons.treinamento.entities
{
    public abstract class AuditEntity : BaseEntity
    {

        public AuditEntity()
        {
            CreatedDate = DateTime.Now;
        }

        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime LastUpdateDate { get; set; }
        [JsonIgnore]
        public bool IsDeleted { get; set; }
    }
}
