using System.ComponentModel.DataAnnotations;

namespace MeowColonThree.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "me when i forgor to put a name in")]
        public string Name { get; set; }
        [Required(ErrorMessage = "baps you, don't leave this blank!!! btw there's bits of code that are meant to force these to be an email but i didn't do it your welcome")]
        public string Email { get; set; }
        [Required(ErrorMessage = "i'm so hungry please feed me words!!! also before you ask it isn't out of laziness i just don't wanna make these be a phone number or a email")]
        public string Celular { get; set; }
    }
}
