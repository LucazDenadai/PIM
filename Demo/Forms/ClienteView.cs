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

namespace Demo.Forms
{
    public partial class ClienteView : Form
    {
        ClienteEntity cliente = new ClienteEntity();
        ClienteBll bll = new ClienteBll();

        public ClienteView()
        {
            cliente.Endereco = new EnderecoEntity();
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cliente.Id == default)
                MessageBox.Show("Primeiro busque um cliente");

            cliente.Documento = textBox1.Text;
            cliente.Nome = textBox2.Text;
            cliente.Email = textBox3.Text;
            cliente.Telefone = textBox4.Text;
            cliente.TelefoneAdicional = textBox11.Text;
            cliente.Endereco.Cep = textBox5.Text;
            cliente.Endereco.Logradouro = textBox6.Text;
            cliente.Endereco.Numero = textBox7.Text;
            cliente.Endereco.Complemento = textBox8.Text;
            cliente.Endereco.Cidade = textBox9.Text;
            cliente.Endereco.Estado = textBox10.Text;

            var result = bll.Update(cliente);

            if (result)
                MessageBox.Show("Atualizado com sucesso");
            else
                MessageBox.Show("Erro ao atualizar");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cliente.Id == default)
                MessageBox.Show("Primeiro busque um cliente");

            var result = bll.Delete(cliente.Id);

            if (result)
                MessageBox.Show("Removido com sucesso");
            else
                MessageBox.Show("Erro ao remover");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Documento = textBox1.Text;
            cliente.Nome = textBox2.Text;

            if (cliente.Documento == default || cliente.Nome == default)
            {
                MessageBox.Show("Por favor preencha o nome ou CNPJ/CPF");
                return;
            }

            var result = bll.Search(textBox1.Text, textBox2.Text);

            if (result == null)
            {
                MessageBox.Show("Erro ao fazer a consulta");
                return;
            }
            cliente = result;

            cliente.Endereco = bll.SearchEndereco(cliente.Endereco.Id);

            textBox1.Text = cliente.Documento;
            textBox2.Text = cliente.Nome;
            textBox3.Text = cliente.Email;
            textBox4.Text = cliente.Telefone;
            textBox11.Text = cliente.TelefoneAdicional;
            textBox5.Text = cliente.Endereco.Cep;
            textBox6.Text = cliente.Endereco.Logradouro;
            textBox7.Text = cliente.Endereco.Numero;
            textBox8.Text = cliente.Endereco.Complemento;
            textBox9.Text = cliente.Endereco.Cidade;
            textBox10.Text = cliente.Endereco.Estado;


            button2.Enabled = true;
            button3.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
        }

        private void ClienteView_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            Hide();
        }
    }
}
