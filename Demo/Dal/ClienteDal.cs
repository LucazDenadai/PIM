using Demo.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Dal
{
    public class ClienteDal
    {
        public bool Insert(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                con.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int InsertAndReturnId(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                int idEnd = 0;

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        idEnd = int.Parse(dr.GetValue(0).ToString());
                    }
                }
                con.CloseConnection();

                return idEnd;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ClienteEntity Search(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                if (dr.HasRows == false)
                    return null;

                ClienteEntity cliente = new ClienteEntity();
                cliente.Endereco = new EnderecoEntity();

                while (dr.Read())
                {
                    cliente.Id = Convert.ToInt32(dr["IDCLIENTE"]);
                    cliente.Documento = Convert.ToString(dr["CPF_CNPJ"]);
                    cliente.Nome = Convert.ToString(dr["NOME"]);
                    cliente.Email = Convert.ToString(dr["EMAIL"]);
                    cliente.Telefone = Convert.ToString(dr["TELEFONE_1"]);
                    cliente.TelefoneAdicional = Convert.ToString(dr["TELEFONE_2"]);
                    cliente.Endereco.Id = Convert.ToInt32(dr["ID_ENDERECO"]);
                }

                con.CloseConnection();

                return cliente;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public EnderecoEntity SearchEndereco(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                EnderecoEntity endereco = new EnderecoEntity();

                if (dr.HasRows == false)
                    return null;

                while (dr.Read())
                {
                    endereco.Id = Convert.ToInt32(dr["IDENDERECO"]);
                    endereco.Cep = Convert.ToString(dr["CEP"]);
                    endereco.Logradouro = Convert.ToString(dr["LOGRADOURO"]);
                    endereco.Numero = Convert.ToString(dr["NUMERO"]);
                    endereco.Cidade = Convert.ToString(dr["CIDADE"]);
                    endereco.Estado = Convert.ToString(dr["ESTADO"]);
                    endereco.Complemento = Convert.ToString(dr["COMPLEMENTO"]);
                }

                con.CloseConnection();

                return endereco;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Update(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                con.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Delete(string comand)
        {
            try
            {
                Connect con = new Connect();
                SqlConnection connection = con.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand(comand, connection);
                SqlDataReader dr = sqlCommand.ExecuteReader();

                con.CloseConnection();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
