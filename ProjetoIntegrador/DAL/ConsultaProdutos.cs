using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoIntegrador.DTO;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjetoIntegrador.DAL
{
    internal class ConsultaProdutos
    {
        public static DataTable ListarTodosOsProdutosDataTable()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria' " +
            $"FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = tb_produtos.id_categoria";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                

                return dataTable;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }

        public static void DeletarProduto(int ID)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"DELETE FROM tb_produtos WHERE id = {ID};";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static void AdicionarTarefa(ProdutoDTO produto)
        {
            Conexao minhaConexao = new Conexao();

            string query = $"INSERT INTO tb_produtos(nome, valor, url_imagem, id_categoria) VALUES " +
                $"'{produto.Nome}', " +
                $"'{produto.Descricao}' " +
                $"'{produto.urlImage}' " +
                $"{produto.Valor} " +
                $"{produto.idCategoria};";

            MySqlCommand mySqlCommand = new MySqlCommand(query, minhaConexao.Start());

            try
            {
                mySqlCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }
            finally
            {
                minhaConexao.Close();
            }
        }

        public static List<ProdutoDTO> ListarTodosOsProdutosDTO()
        {
            // Instância da nossa classe de conexao
            Conexao minhaConexao = new Conexao();

            // String que recebera a consulta realizada pelo usuario
            string query = $"SELECT tb_produtos.*, tb_categoria.nome AS 'nome_categoria' " +
            $"FROM tb_produtos INNER JOIN tb_categoria ON tb_categoria.id_categoria = tb_produtos.id_categoria";

            // Adaptador de rede do MySQL para realizar a conexão ao banco de dados
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, minhaConexao.Start());

            // Tente
            try
            {
                // Criar uma variavel do tipo tabela de dados (que é a isntância de uma classe)
                DataTable dataTable = new DataTable();
                // Preencher a tabela com o retorno da consulta do adaptador
                dataAdapter.Fill(dataTable);
                // Zerando a lista para receber os valores
                List<ProdutoDTO> listaDeProdutos = new List<ProdutoDTO>();
                // Preenchendo a lista com os valores recebidos do banco de dados
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    listaDeProdutos.Add(
                       new ProdutoDTO (
                           (int)dataTable.Rows[i]["id_produtos"],
                           (string)dataTable.Rows[i]["nome"],
                           (decimal)dataTable.Rows[i]["valor"],
                           (string)dataTable.Rows[i]["nome_categoria"],
                           (int)dataTable.Rows[i]["id_categoria"],
                           (string)dataTable.Rows[i]["url_imagem"],
                           (string)dataTable.Rows[i]["descricao"]

                           )
                    );
                }

                return listaDeProdutos;
            }
            // Em caso de erro
            catch (Exception error)
            {
                //captura o erro e mostra a mensagem
                throw new Exception(error.Message);
            }
            // Apos sucesso/erro 
            finally
            {
                // Chame a função de fechar a conexao do objeto minhaConexao
                minhaConexao.Close();
            }
        }
    }
}