using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{

    [Table("ACL", Schema = "public")]
    public class ACL
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ACLID { get; set; }
    }
}
