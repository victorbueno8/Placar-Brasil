using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Placar_Brasil
{
    class Banco_de_Dados
    {
        private static MySqlConnection mConn;
        private static MySqlDataAdapter mAdapter;


        private static string pathServer = "localhost";
        private static string database = "futebol";
        private static string user = "root";
        private static string password = "victor";



        public static string GetURL()
        {
            return "SERVER=" + pathServer + "; DATABASE=" +
                database + "; UID = " + user + "; PASSWORD = " + password + ";";
        }

        public static void TestarBD()
        {
            try
            {
                conectar();
            }
            catch
            {
                MessageBox.Show("Erro ao conectar ao banco de dados!");
                return;
            }
            finally
            {
                desconectar();
            }
        }

        public static bool conectar()
        {
            try
            {
                Console.WriteLine(GetURL());
                mConn = new MySqlConnection(GetURL());
                mConn.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public static bool desconectar()
        {
            try
            {
                mConn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
        public static int AutoIncrementaId(string tabela,string nome_id)
        {
            int aux = 0;
            try
            {
                conectar();
                MySqlCommand cmd = MConn.CreateCommand();
                cmd.CommandText = "SELECT MAX(" + nome_id + ") as ultimoid FROM " + tabela + ";";
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, MConn);
                while (dr.Read())
                {
                    try
                    {
                        Console.WriteLine(Convert.ToInt16(dr["ultimoid"]));
                        aux = Convert.ToInt16(dr["ultimoid"]);
                    }
                    catch
                    {
                        aux = 0;
                    }
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erro\n" + ex);
            }
            finally
            {
                desconectar();
            }

            return aux + 1;
        }

        public static void enviarParaBanco(string comando)
        {
            if(conectar() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(comando, mConn);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                desconectar();
            }
        }

        public static DataTable GetDataTable(string command)
        {
            //Cria um dataSet para retornar os resultados;
            DataTable mData = new DataTable();
            //Conecta ao banco;
            if(conectar() == true)
            {
                //cria um adapter utilizando a instrução SQL para aceder à tabela
                mAdapter = new MySqlDataAdapter(command, mConn);
                //preenche o dataset através do adapter
                mAdapter.Fill(mData);
                //retorna Dataset preenchido
                desconectar();
            }
            
            return mData;
        }


        


        public static MySqlConnection MConn
        {
            get { return mConn; }
            set { mConn = value; }
        }

        public static MySqlDataAdapter MAdapter
        {
            get { return mAdapter; }
            set { mAdapter = value; }
        }




        

        public object GetSimpleString(string comando)
        {
            DataSet data = new DataSet();
            data = GetDataSet(comando);
            foreach (DataTable table in data.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        // read item
                        return item;
                    }
                }
            }
            return null;
        }
        public static DataSet GetDataSet(string command)
        {
            //Cria um dataSet para retornar os resultados;
            DataSet mData = new DataSet();
            //Conecta ao banco;
            if(conectar())
            {
                //cria um adapter utilizando a instrução SQL para aceder à tabela
                mAdapter = new MySqlDataAdapter(command, mConn);
                //preenche o dataset através do adapter
                mAdapter.Fill(mData);
                //retorna Dataset preenchido
                desconectar();
            }
            
            return mData;
        }
        
    }
}
