using MySql.Data.MySqlClient;
using Sistema_Alunos.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Alunos.DAO
{
    class AlunoDAO
    {
        String Con;
        Aluno alu = new Aluno();

        public AlunoDAO()
        {
            Con = "Persist Security Info=False;server=localhost;database=cadastro;uid=root;pwd=root";
        }

        public void IncluirAluno(Aluno aluno)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "INSERT INTO alunos(nome,endereco,idade) values(?nome, ?endereco, ?idade)";

            Com.Parameters.AddWithValue("?nome", aluno.Nome1);
            Com.Parameters.AddWithValue("?endereco", aluno.Endereco1);
            Com.Parameters.AddWithValue("?idade", aluno.Idade1);

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
        public void Alterar(Aluno aluno)
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand Com = CN.CreateCommand();

            Com.CommandText = "UPDATE alunos SET nome='" + aluno.Nome1 + "'" + "," + " endereco='"
                + aluno.Endereco1 + "'" + "," + " idade=" + aluno.Idade1 + "WHERE" + "id=" 
                + aluno.Alunoid1;

            try
            {
                CN.Open();
                int registroAfetados = Com.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getAluno()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT * FROM alunos";
            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;
            }
            catch(MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
