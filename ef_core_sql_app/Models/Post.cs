using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ef_core_sql_app.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PostId { get; set; }
        [Required]
        [StringLength(255)]
        public string Title { get; set; }
        [Required]
        [StringLength(1024)]
        public string Content { get; set; }
        public int BlogId { get; set; }
        //Navigation property
        public virtual Blog Blog { get; set; }
    }
}