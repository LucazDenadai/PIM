using Demo.Bll;
using Demo.Entity;
using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Cliente : Form
    {
        ClienteEntity cliente = new ClienteEntity();

        public Cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cliente.Documento = documento.Text;
            cliente.Nome = nome.Text;
            cliente.Email = email.Text;
            cliente.Telefone = tel.Text;
            cliente.Endereco = new EnderecoEntity();
            cliente.Endereco.Cep = cep.Text;
            cliente.Endereco.Logradouro = log.Text;
            cliente.Endereco.Numero = num.Text;
            cliente.Endereco.Complemento = complemento.Text;
            cliente.Endereco.Cidade = cidade.Text;
            cliente.Endereco.Estado = estado.Text;

            ClienteBll bll = new ClienteBll();
            int idEndereco = bll.InsertEndereco(cliente.Endereco);
            var result = bll.Insert(cliente, idEndereco);

            MessageBox.Show(result);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
        }

        private void tel_TextChanged(object sender, EventArgs e)
        {
        }

        private void cep_TextChanged(object sender, EventArgs e)
        {
        }

        private void log_TextChanged(object sender, EventArgs e)
        {
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
        }

        private void complemento_TextChanged(object sender, EventArgs e)
        {
        }

        private void cidade_TextChanged(object sender, EventArgs e)
        {
        }

        private void estado_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
