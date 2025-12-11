using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MeowColonThree.Enuns;

namespace MeowColonThree.Models
{
    [Table("Usuarios")]
    public class UsuarioSemSenhaModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public PerfilEnums? Perfil { get; set; }
    }
}