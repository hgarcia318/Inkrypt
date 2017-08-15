using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{


    [Table("Credentials", Schema = "public")]
    public class Credentials
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
        [Required]
        public long ClientID { get; set; }
        [Required]
        [MaxLength(30)]
        public String UserName { get; set; }
        [Required]
        [MaxLength(30)]
        public String Password { get; set; }
        public String Domain { get; set; }
        public String Application { get; set; }
        public String Website { get; set; }
        public long ACL { get; set; }
        public long FolderID { get; set; }
    }
}
