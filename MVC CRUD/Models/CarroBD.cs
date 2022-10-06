using System;
using System.Collections.Generic;
using MySqlConnector;

namespace MVC_CRUD.Models
{
    public class CarroBD
    {
        // Dados de conexão
        private static string dadosConexao = "Database=veiculos; Data Source=localhost; User Id=root;";

        public static String TestarConexao() {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            
            conexao.Open();
            conexao.Close();    
            string mensagem = "Conectado com sucesso!";

            return mensagem;        
        }

        /* CRUD de Carro */
        public static void Inserir (Carro carro) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "INSERT INTO carro (marca, ano, cor, valor) VALUES (@marca, @ano, @cor, @valor);";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@marca", carro.marca);
            comando.Parameters.AddWithValue("@ano", carro.ano);
            comando.Parameters.AddWithValue("@cor", carro.cor);
            comando.Parameters.AddWithValue("@valor", carro.valor);
            comando.ExecuteNonQuery();
            conexao.Close();
        }


        public static List<Carro> Listar() {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM carro;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            List<Carro> lista = new List<Carro>();

            while (leitor.Read()) {
                Carro carro = new Carro();

                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    carro.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("marca")))
                    carro.marca = leitor.GetString("marca");
                if (!leitor.IsDBNull(leitor.GetOrdinal("cor")))
                    carro.cor = leitor.GetString("cor");
                if (!leitor.IsDBNull(leitor.GetOrdinal("ano")))
                    carro.ano = leitor.GetInt32("ano");
                if (!leitor.IsDBNull(leitor.GetOrdinal("valor")))
                    carro.valor = leitor.GetDouble("valor");

                lista.Add(carro);
            }

            conexao.Close();
            return lista;
        }

        public static void Atualizar (Carro carro) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "UPDATE carro SET marca=@marca, ano=@ano, cor=@cor, valor=@valor WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@marca", carro.marca);
            comando.Parameters.AddWithValue("@ano", carro.ano);
            comando.Parameters.AddWithValue("@cor", carro.cor);
            comando.Parameters.AddWithValue("@valor", carro.valor);
            comando.Parameters.AddWithValue("@id", carro.id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        

        public static void Remover (int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "DELETE FROM carro WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            conexao.Close();
        }        


        // Métodos auxiliares
        public static Carro BuscarPorId(int id) {
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            string query = "SELECT * FROM carro WHERE id=@id;";
            MySqlCommand comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader leitor = comando.ExecuteReader();
            
            Carro carro = new Carro();

            if (leitor.Read()) {
                if (!leitor.IsDBNull(leitor.GetOrdinal("id")))
                    carro.id = leitor.GetInt32("id");
                if (!leitor.IsDBNull(leitor.GetOrdinal("marca")))
                    carro.marca = leitor.GetString("marca");
                if (!leitor.IsDBNull(leitor.GetOrdinal("cor")))
                    carro.cor = leitor.GetString("cor");
                if (!leitor.IsDBNull(leitor.GetOrdinal("ano")))
                    carro.ano = leitor.GetInt32("ano");
                if (!leitor.IsDBNull(leitor.GetOrdinal("valor")))
                    carro.valor = leitor.GetDouble("valor");
            }

            conexao.Close();
            return carro;
        }



    }
}