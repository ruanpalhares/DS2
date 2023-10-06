using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Etec.Domain
{
    [Table("TB_Aluno")]
    public class Aluno
    {
        [Key]
        [Required(ErrorMessage ="Id é de preenchimento obrigatorio")]
        public int Id { get; set; }

        [MaxLength(100, ErrorMessage = "O nome deve ter no maximo 100 caracteres")]
        [Required(ErrorMessage ="Nome é de preenchimento obrigatorio")]
        public string Nome { get; set; }

        [MaxLength(20, ErrorMessage = "O apelido deve ter no maximo 20 caracteres")]
        public string Apelido { get; set; }

        [Required(ErrorMessage ="Data de nascimento é de preenchimento obrigatorio")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Curso é de preenchimento obrigatorio")]
        public EnumCurso Curso { get; set; }
    }
}
