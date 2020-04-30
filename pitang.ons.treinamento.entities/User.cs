using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace pitang.ons.treinamento.entities
{

    [Table("user")]
    public class User : AuditEntity
    {
        public string Email { get; set; }


        public string Password { get; set; }

        public virtual IList<Contact> Contacts { get; set; }

        public User()
        {
            Contacts = new List<Contact>();
        }

    }
}
