using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{


    [Table("User", Schema="public")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long UserID { get; set; }
        [Required]
        [MaxLength(20)]
        [Index(IsUnique = true)]
        public String Username { get; set; }
        [Required]
        [MaxLength(20)]
        public String Password { get; set; }
        [Required]
        [MaxLength(30)]
        public String Email { get; set; }
        [Required]
        [MaxLength(20)]
        public String FirstName { get; set; }
        [Required]
        [MaxLength(20)]
        public String LastName { get; set; }
        [Required]
        [MaxLength(20)]
        public String SecurityProfile { get; set; }
        [Required]
        [MaxLength(20)]
        public String Group { get; set; }
    }
}
