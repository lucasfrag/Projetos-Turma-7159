using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}