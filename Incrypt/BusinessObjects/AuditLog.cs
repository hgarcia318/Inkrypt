using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Incrypt.BusinessObjects
{
    [Table("AuditLog", Schema = "public")]
    public class AuditLog
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // Primary Key
        public long ID { get; set; }
        // Foreign key, User table       
        [Required]       
        public long UserID { get; set; }
        // Date and time action was performed
        public DateTime Date { get; set; }
        // Action performed, Added, Modified, Deleted etc.
        [Required]
        [MaxLength(20)]        
        public String Action { get; set; }
        [Required]
        [MaxLength(250)]
        public String AdditionalInformation { get; set; }
        public String Before { get; set; }
        public String After { get; set; }
    }
}
