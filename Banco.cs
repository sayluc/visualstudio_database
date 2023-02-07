﻿using System;
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
    internal class Banco
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarBanco()
        {
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoDatabase);

            conex.Open();
            return conex;
            
        }
        //Fim do método ConectarBanco

        public static DataTable RelacaoUser()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    return dt;
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        } 
        // Método genérico para consultar o BancoDeDados

        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
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

        // Data Manipulation Language (INSERT - UPDADE - DELETE)
        public static void Dml(string sql, string msgOk = null, string msgErro = null) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                // O Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOk != null) 
                { 
                    MessageBox.Show(msgOk); 
                }
            }
            catch (Exception ex)
            {
                if (msgErro != null) { MessageBox.Show(msgErro + " " + ex.Message); }
                throw ex;
            }
        }

        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuario já existe no sistema");
                return;
            }

            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_usuario (nome_usuario,username_usuario,senha_usuario,status_usuario,nivel_usuario) VALUES (@nome,@username,@senha,@status,@nivel)";
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
                MessageBox.Show("Erro ao inserir novo usuario .: " + ex.Message);
            }
        }

        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuario WHERE username_usuario='" + user.username_usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
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
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_curso (nome_curso,area_curso,status_curso) VALUES (@nome,@area,@status)";
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
            }
        }

        public static bool ProfessorTelefoneExiste(Professor professor)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT telefone_professor FROM tb_professor WHERE telefone_professor='" + professor.telefone_professor + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
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

        public static void NovoProfessor(Professor professor)
        {
            if (ProfessorTelefoneExiste(professor) == true)
            {
                MessageBox.Show("Número de telefone já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_professor (nome_professor,sobrenome_professor,area_professor,setor_professor,telefone_professor,turno_professor) VALUES (@nome,@sobrenome,@area,@setor,@telefone,@turno)";
                cmd.Parameters.AddWithValue("@nome", professor.nome_professor);
                cmd.Parameters.AddWithValue("@sobrenome", professor.sobrenome_professor);
                cmd.Parameters.AddWithValue("@area", professor.area_professor);
                cmd.Parameters.AddWithValue("@setor", professor.setor_professor);
                cmd.Parameters.AddWithValue("@telefone", professor.telefone_professor);
                cmd.Parameters.AddWithValue("@turno", professor.turno_professor);
                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo professor adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo professor .: " + ex.Message);
            }
        }

        public static bool AlunoTelefoneExiste(Aluno aluno)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT telefone_aluno FROM tb_aluno WHERE telefone_aluno='" + aluno.telefone_aluno + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
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

        public static void NovoAluno(Aluno aluno)
        {
            if (AlunoTelefoneExiste(aluno) == true)
            {
                MessageBox.Show("Número de telefone já existe no sistema");
                return;
            }
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "INSERT INTO tb_aluno (nome_aluno,sobrenome_aluno,curso_aluno,telefone_aluno,periodo_aluno) VALUES (@nome,@sobrenome,@curso,@telefone,@periodo)";
                cmd.Parameters.AddWithValue("@nome", aluno.nome_aluno);
                cmd.Parameters.AddWithValue("@sobrenome", aluno.sobrenome_aluno);
                cmd.Parameters.AddWithValue("@curso", aluno.curso_aluno);
                cmd.Parameters.AddWithValue("@telefone", aluno.telefone_aluno);
                cmd.Parameters.AddWithValue("@periodo", aluno.periodo_aluno);
                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo aluno adicionado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir novo aluno .: " + ex.Message);
            }
        }

        public static DataTable ObterUserID()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {

                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_usuario AS ID, nome_usuario AS Nome FROM tb_usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPorId(string id)
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_usuario WHERE id_usuario=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable AtualizarUsuario(Usuario user)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_usuario SET nome_usuario='" + user.nome_usuario + "',username_usuario='" + user.username_usuario + "',senha_usuario='" + user.senha_usuario + "',status_usuario='" + user.status_usuario + "',nivel_usuario=" + user.nivel_usuario + " WHERE id_usuario=" + user.id_usuario;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RemoverUsuario(string id)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_usuario WHERE id_usuario=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterClassID()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_curso AS ID, nome_curso AS Nome FROM tb_curso";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPorIdClass(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_curso WHERE id_curso=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable AtualizarCurso(Curso curso)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_curso SET nome_curso='" + curso.nome_curso + "',area_curso='" + curso.area_curso + "',status_curso='" + curso.status_curso + "' WHERE id_curso=" + curso.id_curso;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoverCurso(string id)
        {
            SQLiteDataAdapter da = null;
            //DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_curso WHERE id_curso=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterTeacherID()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_professor AS ID, nome_professor AS Nome FROM tb_professor";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPorIdTeacher(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_professor WHERE id_professor=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable AtualizarProfessor(Professor professor)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_professor SET nome_professor='" + professor.nome_professor + "',sobrenome_professor='" + professor.sobrenome_professor + "',area_professor='" + professor.area_professor + "',setor_professor='" + professor.setor_professor + "',telefone_professor='" + professor.telefone_professor + "',turno_professor='" + professor.turno_professor + "' WHERE id_professor=" + professor.id_professor;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoverProfessor(string id)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_professor WHERE id_professor=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterStudentID()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_aluno AS ID, nome_aluno AS Nome FROM tb_aluno";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPorIdStudent(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_aluno WHERE id_aluno=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable AtualizarEstudante(Aluno aluno)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "UPDATE tb_aluno SET nome_aluno='" + aluno.nome_aluno + "',sobrenome_aluno='" + aluno.sobrenome_aluno + "',curso_aluno='" + aluno.curso_aluno + "',telefone_aluno='" + aluno.telefone_aluno + "',periodo_aluno='" + aluno.periodo_aluno + "' WHERE id_aluno=" + aluno.id_aluno;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void RemoverEstudante(string id)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_aluno WHERE id_aluno=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterSalaID()
        {

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_turma";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable ObterDadosPorIdSala(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT * FROM tb_turma WHERE id_turma=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void RemoverSala(string id)
        {
            SQLiteDataAdapter da = null;
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "DELETE FROM tb_turma WHERE id_turma=" + id;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                cmd.ExecuteNonQuery();
                vcon.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }// Fim das funções genéricas
    }
}