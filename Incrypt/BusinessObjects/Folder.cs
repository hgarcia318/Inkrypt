using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{


    [Table("Folder", Schema = "public")]
    public class Folder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FolderID { get; set; }
        public long FolderParent { get; set; }
        public long FolderACL { get; set; }
    }
}
