using EntityFriendlyBack.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFriendlyBack.Model
{
    [Table("product")]
    public class ToDoList : BaseEntity
    {
        [Column("description")]
        [Required]
        [StringLength(150)]
        public string Description { get; set; }

        [Column("data")]
        [Required]
        public DateTime Data { get; set; }
    }
}
