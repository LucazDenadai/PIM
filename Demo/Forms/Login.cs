using Demo.Bll;
using Demo.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : Form
    {
        UsuarioEntity usuario = new UsuarioEntity();
        UsuarioBll bll = new UsuarioBll();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuario.Login = tLogin.Text;
            usuario.Senha = tSenha.Text;


            var result = bll.Login(usuario);
            if (result == "Ok")
            {
                Cliente cliente = new Cliente();
                cliente.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            tSenha.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
