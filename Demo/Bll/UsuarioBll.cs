using Demo.Dal;
using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bll
{
    public class UsuarioBll
    {
        private UsuarioDal _dal;

        public UsuarioBll()
        {
            _dal = new UsuarioDal();
        }

        public string Login(UsuarioEntity usuario)
        {
            if (usuario.Login == default)
                return "Login precisa ser preenchido";

            if (usuario.Senha == default)
                return "Senha precisa ser preenchid";

            string commando = $"SELECT * FROM tbUsuarios WHERE USUARIO = '{usuario.Login}' AND SENHA = '{usuario.Senha}'";

            var result = _dal.Login(commando);

            if (!result)
                return "Usuário Inexistente";

            return "Ok";
        }
    }
}
