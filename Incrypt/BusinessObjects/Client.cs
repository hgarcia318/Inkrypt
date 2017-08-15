using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{

    [Table("Client", Schema = "public")]
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ClientID { get; set; }
        [Required]
        [MaxLength(20)]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public String LastName { get; set; }
        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public String Email { get; set; }
    }
}
