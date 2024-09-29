using ToDoList.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListaAfazeres.Model
{
    [Table("Tarefa")]
    public class Tarefa : BaseEntity
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
