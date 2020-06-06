using Demo.Dal;
using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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
                comando = $"INSERT INTO tbCliente(nome, email, telefone_1, data_cadastro, data_nascimento, CPF_CNPJ, id_Endereco) OUTPUT INSERTED.[IDCLIENTE] " +
                $"VALUES('{cliente.Nome}', '{cliente.Email}', '{cliente.Telefone}', '{DateTime.Now.Date}', '{cliente.dataNascimento}', '{cliente.Documento}', '{idEndereco}');";
            }
            else
            {
                comando = $"INSERT INTO tbCliente(nome, email, telefone_1, data_cadastro, data_nascimento, CPF_CNPJ) OUTPUT INSERTED.[IDCLIENTE] " +
                $"VALUES('{cliente.Nome}', '{cliente.Email}', '{cliente.Telefone}', '{DateTime.Now.Date}', '{cliente.dataNascimento}', '{cliente.Documento}');";
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

        public ClienteEntity Seacrh(ClienteEntity cliente)
        {
            if (cliente == default)
                return null;

            var comand = "SELECT * FROM tbCliente where idCliente = " + cliente.id;

            ClienteEntity result = _dal.Search(comand);

            return result;
        }

        public EnderecoEntity SeacrhEndereco(int idEndereco)
        {
            if (idEndereco == default)
                return null;

            var comand = "SELECT * FROM tbEndereco where idEndereco = " + idEndereco;

            EnderecoEntity result = _dal.SearchEndereco(comand);

            return result;
        }

        public bool Update(ClienteEntity cliente)
        {
            if (cliente == default)
                return false;

            var comand = "UPDATE tbCliente" +
                "SET nome = " + cliente.Nome + ", " +
                "email = " + cliente.Email + ", " +
                "telefone_1 = " + cliente.Telefone + ", " +
                "data_cadastro = " + cliente.dataCadastro + ", " +
                "data_nascimento = " + cliente.dataNascimento + ", " +
                "CPF_CNPJ = " + cliente.Documento + ", " +
                "WHERE = " + cliente.id + ";";

            //Atualizar endereço
            comand = comand + "UPDATE TbEndereco SET " +
                "[CEP] = " + cliente.Endereco.Id + ", " +
                "[LOGRADOURO] = " + cliente.Endereco.Id + ", " +
                "[NUMERO] = "+ cliente.Endereco.Id + ", " +
                "[COMPLEMENTO] = " + cliente.Endereco.Id + ", " +
                "[CIDADE] = " + cliente.Endereco.Id + ", " +
                "[ESTADO] = " + cliente.Endereco.Id + ", " +
                "WHERE IdEnedereco = " + cliente.Endereco.Id;

            bool result = _dal.Update(comand);

            return result;
        }

        public bool Delete(ClienteEntity cliente)
        {
            if (cliente == default)
                return false;

            var comand = "DELETE TbCliente" +
                "WHERE = " + cliente.id + ";";

            //deleta endereço
            comand = comand + "DELETE TbEndereco" +
                "WHERE IdEnedereco = " + cliente.Endereco.Id;

            bool result = _dal.Delete(comand);

            return result;
        }
    }
}
