using MeowColonThree.Data;
using MeowColonThree.Models;

// alright so things are probably going to be uh.
// borked. like royally fucking borked.
//

namespace MeowColonThree.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel Adicionar(UsuarioModel Usuario)
        {
            Usuario.DataCadastro = DateTime.Now;
            _bancoContext.Usuarios.Add(Usuario);
            _bancoContext.SaveChanges();
            return Usuario;
            // i have a little pet theory for what the hell is going on right now.
            // in the bit of code that the site uses, it utilizes Usuario and usuario
            // capitalized and not capitalized.
            // but I, the humble coder, am just using Usuario.
            // this might be whats making things a little weird.
            // but i'm too lazy to try n fix it :3
            // all we can do is hope this doesn't bite us in the ass.
        }

        public bool Apagar(int id)
        {
            // alright figure out what the fuck is going on with the bit of code bellow this comment
            UsuarioModel UsuarioDB = ListarPorId(id);
            if (UsuarioDB == null) throw new Exception("OH NO IT FUCKING BROKE A G A I N");
            _bancoContext.Usuarios.Remove(UsuarioDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public UsuarioModel Atualizar(UsuarioModel Usuario)
        {
            UsuarioModel usuarioDB = ListarPorId(Usuario.Id);
            if (usuarioDB == null) throw new Exception("hate let me tell you how much i've come to hate you since i began to liv"); // go figure
            usuarioDB.Name = Usuario.Name;
            usuarioDB.Email = Usuario.Email;
            usuarioDB.Login = Usuario.Login;
            usuarioDB.Perfil = Usuario.Perfil;
            usuarioDB.DataAtualizacao = DateTime.Now;


            _bancoContext.Usuarios.Update(usuarioDB);
            _bancoContext.SaveChanges();

            return usuarioDB;
        }

        public List<UsuarioModel> BuscarTodos()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuarioModel ListarPorId(int id)
        {
            // ignore this one this is fine we don't need to do shit about it :D
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }
    }
}
