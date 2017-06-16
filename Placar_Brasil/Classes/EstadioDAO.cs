using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class EstadioDAO : InterfaceDAO<Estadio>
    {
        public List<Estadio> SelectBD(string pesquisa)
        {
            List<Estadio> ListEstadio = new List<Estadio>();

            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT * from Estadio";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE nome like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Estadio a = new Estadio(Convert.ToInt16(dr["id"]), (String)dr["nome"], (String)dr["cidade"], (String)dr["estado"]);
                    ListEstadio.Add(a);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no select!\n" + ex);
            }
            finally
            {
                Banco_de_Dados.desconectar();
            }
            return ListEstadio;
        }


        public void InsertBD(Estadio values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Estadio(id,nome,cidade,estado) values(?id,?nome,?cidade,?estado)";
            Com.Parameters.AddWithValue("?id", values.Id);
            Com.Parameters.AddWithValue("?nome", values.Nome);
            Com.Parameters.AddWithValue("?cidade", values.Cidade);
            Com.Parameters.AddWithValue("?estado", values.Estado);

            try
            {
                int regitrosAfetados = Com.ExecuteNonQuery();
                MessageBox.Show("Cadastro registrado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro no Cadastro!\n" + ex);
            }
            finally
            {
                Banco_de_Dados.desconectar();
            }
        }


        public void UpdateBD(string alvo, Estadio novo_dado)
        {
            try
            {
                String sql = "UPDATE estadio SET nome = \'" + novo_dado.Nome + "\', cidade = \'" + novo_dado.Cidade + "\', estado = \'" + novo_dado.Estado +
                    "\' WHERE nome = \'" + alvo + "\'";
                //Console.WriteLine(sql);
                Banco_de_Dados.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, Banco_de_Dados.MConn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado!");

            }
            catch 
            {
                MessageBox.Show("Estadio não encontrado!");
            }
            finally
            {
                Banco_de_Dados.desconectar();
            }
        }


        public void DeleteBD(string pesquisa)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "DELETE FROM Estadio WHERE nome like \'" + pesquisa + "\';";
            try
            {
                int registrosAfetados = Com.ExecuteNonQuery();
                MessageBox.Show("Cadastro deletado com sucesso!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro na remoção de dados! " + ex);
            }
            finally
            {
                Banco_de_Dados.desconectar();
            }
        }
    }
}
