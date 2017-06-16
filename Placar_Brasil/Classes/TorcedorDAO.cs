using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class TorcedorDAO : InterfaceDAO<Torcedores>
    {
        public List<Torcedores> SelectBD(string pesquisa)
        {
            List<Torcedores> ListTorcedores = new List<Torcedores>();
            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT u.*,t.cpf,t.email,t.time from Usuario u JOIN Torcedor t ON t.id=u.id";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE u.nome_usuario like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Torcedores a = new Torcedores(Convert.ToInt16(dr["id"]), (String)dr["nome_usuario"], (String)dr["senha"], (String)dr["nome_completo"], (String)dr["cpf"], (String)dr["email"], (String)dr["time"]);
                    ListTorcedores.Add(a);
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
            return ListTorcedores;
        }


        public void InsertBD(Torcedores values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Usuario(id,nome_usuario,senha,nome_completo) values(?id,?nome,?senha,?nome_completo);";
            Com.CommandText += " INSERT INTO Torcedor(id,cpf,email,time) values(?id,?cpf,?email,?time);";
            Com.Parameters.AddWithValue("?nome", values.Nome_usuario);
            Com.Parameters.AddWithValue("?senha", values.Senha);
            Com.Parameters.AddWithValue("?nome_completo", values.Nome_completo);
            Com.Parameters.AddWithValue("?id", Banco_de_Dados.AutoIncrementaId("usuario","id"));
            Com.Parameters.AddWithValue("?cpf", values.Cpf);
            Com.Parameters.AddWithValue("?email", values.Email);
            Com.Parameters.AddWithValue("?time", values.Time);
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


        public void UpdateBD(string alvo, Torcedores novo_dado)
        {
            try
            {
                String sql = "UPDATE Usuario u JOIN Torcedor t ON u.id=t.id SET  u.nome_usuario = \'" + novo_dado.Nome_usuario + "\', u.senha   = \'" + novo_dado.Senha + "\', u.nome_completo = \'" + novo_dado.Nome_completo + "\', t.cpf = \'" + novo_dado.Cpf +
                     "\', t.email = \'" + novo_dado.Email + "\', t.time = \'" + novo_dado.Time + "\' WHERE u.nome_usuario like \'" + alvo + "\';";
                //Console.WriteLine(sql);
                Banco_de_Dados.conectar();
                Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, Banco_de_Dados.MConn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro atualizado!");

            }
            catch
            {
                MessageBox.Show("Erro no update!");
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
            Com.CommandText = "DELETE FROM Usuario WHERE nome_usuario like \'" + pesquisa + "\';";
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
