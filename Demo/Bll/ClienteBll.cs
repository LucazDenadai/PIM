using Demo.Dal;
using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Bll
{
    public class ClienteBll
    {
        private ClienteDal _dal;

        public ClienteBll()
        {
            _dal = new ClienteDal();
        }

        public string Insert(ClienteEntity cliente, int idEndereco)
        {
            if (cliente.Documento == default)
                return "CNPJ inválido";

            string comando = "";

            if (idEndereco != 0)
            {
                comando = $"INSERT INTO tbCliente(nome, email, telefone_1, telefone_2, data_cadastro, data_nascimento, CPF_CNPJ, id_Endereco) OUTPUT INSERTED.[IDCLIENTE] " +
                $"VALUES('{cliente.Nome}', '{cliente.Email}', '{cliente.Telefone}', '{cliente.TelefoneAdicional}', '{DateTime.Now.Date}', '{cliente.dataNascimento}', '{cliente.Documento}', '{idEndereco}');";
            }
            else
            {
                comando = $"INSERT INTO tbCliente(nome, email, telefone_1, telefone_2, data_cadastro, data_nascimento, CPF_CNPJ) OUTPUT INSERTED.[IDCLIENTE] " +
                $"VALUES('{cliente.Nome}', '{cliente.Email}', '{cliente.Telefone}', '{cliente.TelefoneAdicional}', '{DateTime.Now.Date}', '{cliente.dataNascimento}', '{cliente.Documento}');";
            }

            var result = _dal.Insert(comando);

            if (result)
                return "Salvo com sucesso";
            else
                return "Erro ao salvar";
        }

        public int InsertEndereco(EnderecoEntity endereco)
        {
            string comando = $"INSERT INTO [TbEndereco]([CEP],[LOGRADOURO],[NUMERO],[COMPLEMENTO],[CIDADE],[ESTADO]) " +
                $"VALUES('{endereco.Cep}', '{endereco.Logradouro}', '{endereco.Numero}', '{endereco.Complemento}', '{endereco.Cidade}', '{endereco.Estado}');" +
                $"SELECT @@IDENTITY;";

            int result = _dal.InsertAndReturnId(comando);

            if (result != default)
                return result;
            else
                return 0;
        }

        public ClienteEntity Search(string documento, string nome)
        {
            if (documento == default || nome == default)
                return null;

            var comand = "SELECT * FROM tbCliente where ";

            if (documento != "" && nome != "")
                comand = comand + $"CPF_CNPJ = '{documento}' and  NOME = '{nome}'";
            else if (documento != "" && nome == "")
                comand = comand + $"CPF_CNPJ = '{documento}'";
            else
                comand = comand + $"NOME = '{nome}'";

            return _dal.Search(comand);

        }

        public EnderecoEntity SearchEndereco(int idEndereco)
        {
            if (idEndereco == default)
                return null;

            var comand = $"SELECT * FROM tbEndereco where idEndereco = '{idEndereco}'";

            EnderecoEntity result = _dal.SearchEndereco(comand);

            return result;
        }

        public bool Update(ClienteEntity cliente)
        {
            if (cliente == default)
                return false;

            var comand = "UPDATE tbCliente " +
                $"SET nome = '{cliente.Nome}', " +
                $"email = '{cliente.Email}', " +
                $"telefone_1 = '{cliente.Telefone}', " +
                $"telefone_2 = '{cliente.TelefoneAdicional}', " +
                $"data_cadastro = '{cliente.dataCadastro}', " +
                $"data_nascimento = '{cliente.dataNascimento}', " +
                $"CPF_CNPJ = '{cliente.Documento}' " +
                $"WHERE IDCLIENTE = '{cliente.Id}'; ";

            //Atualizar endereço
            comand = comand + $"UPDATE TbEndereco SET " +
                $"[CEP] = '{cliente.Endereco.Id}', " +
                $"[LOGRADOURO] = '{cliente.Endereco.Id}' , " +
                $"[NUMERO] = '{cliente.Endereco.Id}', " +
                $"[COMPLEMENTO] = '{cliente.Endereco.Id}', " +
                $"[CIDADE] = '{cliente.Endereco.Id}', " +
                $"[ESTADO] = '{cliente.Endereco.Id}' " +
                $"WHERE IDENDERECO = '{cliente.Endereco.Id}'";

            return _dal.Update(comand);
        }

        public bool Delete(int id)
        {
            if (id == default)
                return false;

            var comand = $"DELETE FROM TbCliente WHERE IDCLIENTE = '{id}'";

            return _dal.Delete(comand);
        }
    }
}
