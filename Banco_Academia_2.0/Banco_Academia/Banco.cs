using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Banco_Academia
{
    class Banco
    {

        private static SQLiteConnection conexao;

        #region Funções genéricas:
        public static DataTable dql(string sql) //data quarry lenguage
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) { ConexaoBanco().Close(); MessageBox.Show("Erro\n" + ex.Message); dt = null; return dt; }
        }

        public static void dml(string sql, string msgOK = null, string msgErro = null)//data manipulation lenguage
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();

                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }

            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; if (msgErro != null) { MessageBox.Show(msgErro + "\n" + ex.Message); } }
        }
        #endregion




        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = "+Globais.CaminhoBanco+Globais.nomeBanco);
            conexao.Open();
            return conexao;
        }

        public static DataTable ObterTodosUsers()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM TB_User";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; }
        }



        //Funções sobre usuario

        public static void novoUsuario(DadosDoUsuario u)
        {
            if (Confere(u) == false)
            {
                MessageBox.Show("NOME DE USUÁRIO EM UTILIZAÇÃO");
                return;
            }
            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = @"Insert Into TB_User (UserName,UserNick,UserSenha,UserStatus,UserNivel) 
                                    Values (@nome,@username,@senha,@satus,@nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.nome_De_usuário);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@satus", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário on ♥");

            }
            catch
            {
                MessageBox.Show("Erro de gravação");
                ConexaoBanco().Close();

            }
        }


        //Funções gerais
        public static bool Confere(DadosDoUsuario u)
        {
            bool res = true;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "Select UserName From TB_User where UserName='" + u.nome_De_usuário + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                res = false;
            }
            else
            {
                res = true;
            }
            return res;
        }

        //Gunções gestão usuarios
        public static DataTable IdNome_User()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT IdUser, UserName From TB_User";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; }
        }


        public static DataTable DadosPeloId(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * From TB_User where IdUser = '"+ id +"'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) { ConexaoBanco().Close(); MessageBox.Show(ex.Message); throw ex; }
        }

        public static void AtualizarUsuario(DadosDoUsuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "update tb_User set UserName='"+u.nome+"', UserNick='"+u.nome_De_usuário+"', UserSenha='"+u.senha+"', UserStatus='"+u.status+"', UserNivel='"+u.nivel+"' where IdUser= "+u.Id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; }
        }
        public static void deletaUser(DadosDoUsuario u)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex) { ConexaoBanco().Close(); throw ex; }
        }



    }
}
