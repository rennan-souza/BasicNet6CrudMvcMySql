using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Net6CrudMvcMySql.Models
{
    [Table("TB_USER")]
    public class Usuario
    {
        [Display(Name = "Código")]
        [Column("ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("NOME")]
        public string Nome { get; set; }
    }
}
