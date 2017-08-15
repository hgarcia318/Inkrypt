using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{

    [Table("Group", Schema = "public")]
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long GroupID { get; set; }
        [Required]
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public String GroupName { get; set; }
        [Required]
        [MaxLength(25)]
        public String GroupDescription { get; set; }

    }
}
