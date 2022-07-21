using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCRUDMySQL.Model.DB
{
    public class Conexao
    {

        public MySqlConnection ConectarBancoDeDados()
        {  
            string DataSource = "datasource=localhost;username=root;password=Senh@123;database=db_agenda";
            MySqlConnection Conexao = new MySqlConnection(DataSource);

            return Conexao;
        }
    }
}
