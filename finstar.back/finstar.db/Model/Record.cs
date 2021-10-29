using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finstar.db {
    public class Record {
        [Key]
        [Required]
        public int id { get; set; }

        public int code { get; set; }

        [Column(TypeName = "nvarchar(1024)")]
        public string value { get; set; }
    }
}
