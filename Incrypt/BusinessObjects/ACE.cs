using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{

    [Table("ACE", Schema = "public")]
    public class ACE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AceID { get; set; }
        public long AclID { get; set; }
        public long AceUID { get; set; }
        public long AceGID { get; set; }
        public Boolean AceRead { get; set; }
        public Boolean AceWrite { get; set; }
        public Boolean AceDelete { get; set; }
    }
}
