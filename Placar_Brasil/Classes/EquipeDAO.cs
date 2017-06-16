using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class EquipeDAO : InterfaceDAO<Equipe>
    {
        public List<Equipe> SelectBD(string pesquisa)
        {
            List<Equipe> ListEquipe = new List<Equipe>();

            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT * from Equipe";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE nome like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Equipe a = new Equipe(Convert.ToInt16(dr["id"]), (String)dr["nome"]);
                    ListEquipe.Add(a);
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
            return ListEquipe;
        }


        public void InsertBD(Equipe values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Equipe(id,nome) values(?id,?nome);";
            Com.Parameters.AddWithValue("?id", values.Id);
            Com.Parameters.AddWithValue("?nome", values.Nome);

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
        

        public void UpdateBD(string alvo, Equipe novo_dado)
        {
            try
            {
                String sql = "UPDATE equipe SET nome = \'" + novo_dado.Nome + "\' WHERE nome like \'" + alvo + "\';";
                Console.WriteLine(sql);
                Banco_de_Dados.conectar();
                MySqlCommand cmd = new MySqlCommand(sql, Banco_de_Dados.MConn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado!");

            }
            catch
            {
                MessageBox.Show("Campeonato não encontrado!");
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
            Com.CommandText = "DELETE FROM Equipe WHERE nome like \'" + pesquisa + "\';";
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
