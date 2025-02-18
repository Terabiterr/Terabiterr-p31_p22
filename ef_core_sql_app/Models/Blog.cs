using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ef_core_sql_app.Models
{
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BlogId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //Navigation collection
        public virtual ICollection<Post> Posts { get; set; }
    }
}
