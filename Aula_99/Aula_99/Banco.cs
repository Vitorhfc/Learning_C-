using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;

namespace Aula_99
{
    internal class Banco
    {
        

        private static SQLiteConnection conexao = null;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = C:\\Users\\vitor\\Documents\\Learning_C-\\banco.db");
            conexao.Open();
            return conexao;
        }

        private static  DataTable ObterTodosUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable data = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_User";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(data);
                    ConexaoBanco().Close();
                    return data;
                }
            }
            catch(Exception ex) { ConexaoBanco().Close(); throw ex; }
        }

        public static DataTable Consulta(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable data = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Tb_User";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(data);
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; }
        }
    }
}
