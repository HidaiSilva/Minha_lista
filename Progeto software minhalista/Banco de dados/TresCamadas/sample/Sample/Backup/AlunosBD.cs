using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Macoratti
{
	/// <summary>
	/// descricao para a camada de acesso a dados
	/// </summary>
	public class alunosDB
	{
		string Con;

        //obtem a strind e conexão do arquivo App.config
        public alunosDB()
		{
			Con = ConfigurationSettings.AppSettings["ConexaoBD"];
		}

        //inclui um novo aluno na tabela
		public void IncluirAluno(Alunos alunos)
		{
			MySqlConnection CN = new MySqlConnection(Con);
			MySqlCommand Com = CN.CreateCommand();

			Com.CommandText = "INSERT INTO Alunos(nome,endereco,idade) Values(?nome,?endereco,?idade)";
            
            Com.Parameters.AddWithValue("?nome", alunos.Nome);
            Com.Parameters.AddWithValue("?endereco", alunos.Endereco);
            Com.Parameters.AddWithValue("?idade", alunos.Idade);

			try
			{
				CN.Open();
				int regitrosAfetados = Com.ExecuteNonQuery();
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

        //Obtem todos os alunos da tabela
        public DataTable getAlunos()
        {
            MySqlConnection CN = new MySqlConnection(Con);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;

            cmd.CommandText = "SELECT * from Alunos";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText,CN);
                da = new MySqlDataAdapter(cmd);
                //
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos); 
                return dtAlunos;
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
	}
}
