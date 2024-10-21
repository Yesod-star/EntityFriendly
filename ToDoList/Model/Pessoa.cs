using ToDoList.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ListaAfazeres.Model
{
    [Table("Pessoa")]
    public class Pessoa : BaseEntity
    {
        [Column("nome")]
        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

    }
}
