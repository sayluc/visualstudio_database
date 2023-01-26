using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Drawing;

namespace WindowsFormsApp2
{
    internal class Database
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarDatabase()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoDatabase);

            conex.Open();
            return conex;
        }

        // Fim do método ConectarDatabase
        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = ConectarDatabase().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método genérico para consulta no BD | DQL - Data Query Language
        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Dml(string sql, string msgOk = null, string msgErro = null)
        // Data Manipulation Language (INSERT - UPDADE - DELETE)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);

                // O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
                cmd.ExecuteNonQuery();
                vcon.Close();

                if (msgOk != null)
                {
                    MessageBox.Show(msgOk);
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null)
                {
                    MessageBox.Show(msgErro + " " + ex.Message);
                }
                throw ex;
            }
        }

        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuario já cadastrado");                
            }
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();              
                // Parâmetros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_usuarios (nome_usuario,username_usuario,senha_usuario,status_usuario,nivel_usuario) VALUES (@nome,@username,@senha,@status,@nivel)";                
                // cmd.CommandText = "INSERT INTO tb_usuarios VALUES (null,'maria','maria','1234','A','2')
                cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
                cmd.Parameters.AddWithValue("@username", user.username_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo usuário .: " + ex.Message);
                // throw ex;
            }
        }

        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarDatabase();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuarios WHERE username_usuario='"+user.username_usuario;
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            // o Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                resposta = true;
            }
            else 
            { 
                resposta = false;
            }

            vcon.Close();
            return resposta;
        }

        public static void NovoCurso(Curso curso)
        {                        
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarDatabase();
                var cmd = vcon.CreateCommand();
                // Parâmetros conforme a tabela do banco de dados
                cmd.CommandText = "INSERT INTO tb_curso (nome_curso,area_curso,status_curso) VALUES (@nome,@area,@status)";
                // cmd.CommandText = "INSERT INTO tb_usuarios VALUES (null,'Programacao','Informatica','Aberto')
                cmd.Parameters.AddWithValue("@nome", curso.nome_curso);
                cmd.Parameters.AddWithValue("@area", curso.area_curso);
                cmd.Parameters.AddWithValue("@status", curso.status_curso);

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo curso adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo curso .: " + ex.Message);
                // throw ex;
            }
        }// Fim das funções genéricas

    }
}
