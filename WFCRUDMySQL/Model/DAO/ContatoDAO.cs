using MySql.Data.MySqlClient;
using System.Reflection;
using WFCRUDMySQL.Model.DB;

namespace WFCRUDMySQL.Model.DAO
{
    public class ContatoDAO
    {
        Conexao conexao = new Conexao();

        public void InserirContato(Contato contato)
        {
            var conn = conexao.ConectarBancoDeDados();

            try
            {
                conn.Open();

                string Sql = "INSERT INTO contatos (nome, email, telefone) VALUES (@nome, @email, @telefone)";

                MySqlCommand SqlCommand = new();
                SqlCommand.Connection = conn;
                SqlCommand.CommandText = Sql;
                SqlCommand.Parameters.AddWithValue("@nome", contato.Nome);
                SqlCommand.Parameters.AddWithValue("@email", contato.Email);
                SqlCommand.Parameters.AddWithValue("@telefone", contato.Telefone);

                SqlCommand.Prepare();

                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void AtualizarContato(Contato contato)
        {
            var conn = conexao.ConectarBancoDeDados();

            try
            {
                conn.Open();

                string Sql = "UPDATE contatos SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id";

                MySqlCommand SqlCommand = new();
                SqlCommand.Connection = conn;
                SqlCommand.CommandText = Sql;
                SqlCommand.Parameters.AddWithValue("@id", Convert.ToString(contato.Id));
                SqlCommand.Parameters.AddWithValue("@nome", contato.Nome);
                SqlCommand.Parameters.AddWithValue("@email", contato.Email);
                SqlCommand.Parameters.AddWithValue("@telefone", contato.Telefone);

                SqlCommand.Prepare();

                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void ExcluirContato(Contato contato)
        {
            var conn = conexao.ConectarBancoDeDados();

            try
            {
                conn.Open();

                string Sql = "DELETE FROM contatos WHERE id = @id";

                MySqlCommand SqlCommand = new();
                SqlCommand.Connection = conn;
                SqlCommand.CommandText = Sql;
                SqlCommand.Parameters.AddWithValue("@id", Convert.ToString(contato.Id));

                SqlCommand.Prepare();

                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Contato> Buscar(string parametro)
        {
            var conn = conexao.ConectarBancoDeDados();

            try
            {
                conn.Open();

                List<Contato> contatos = new();
                string Sql = "SELECT * FROM contatos WHERE nome LIKE '%"+ parametro +"%' OR email LIKE '%"+ parametro +"%' ORDER BY id";

                MySqlCommand SqlCommand = new MySqlCommand();
                SqlCommand.Connection = conn;
                SqlCommand.CommandText = Sql;

                SqlCommand.Prepare();

                MySqlDataReader dados = SqlCommand.ExecuteReader();

                contatos.Clear();
                contatos = DataReaderMapToList<Contato>(dados);

                return contatos;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<Contato> Listar()
        {
            var conn = conexao.ConectarBancoDeDados();

            try
            {
                conn.Open();

                List<Contato> contatos = new();
                string Sql = "SELECT * FROM contatos ORDER BY id";

                MySqlCommand SqlCommand = new MySqlCommand();
                SqlCommand.Connection = conn;
                SqlCommand.CommandText = Sql;

                SqlCommand.Prepare();

                MySqlDataReader dados = SqlCommand.ExecuteReader();

                contatos.Clear();
                contatos = DataReaderMapToList<Contato>(dados);

                return contatos;
            }
            catch (Exception ex)
            {
                List<Contato> contatos = new();
                throw new Exception(ex.Message);

                return contatos;
            }
            finally
            {
                conn.Close();
            }
        }

        public static List<T> DataReaderMapToList<T>(MySqlDataReader dr)
        {
            List<T> list = new List<T>();
            T obj = default;
            while (dr.Read())
            {
                obj = Activator.CreateInstance<T>();
                foreach (PropertyInfo prop in obj.GetType().GetProperties())
                {
                    if (!Equals(dr[prop.Name], DBNull.Value))
                    {
                        prop.SetValue(obj, dr[prop.Name], null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
