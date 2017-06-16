using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class OrganizadorDAO : InterfaceDAO<Organizadores>
    {
        public List<Organizadores> SelectBD(string pesquisa)
        {
            List<Organizadores> ListOrganizadores = new List<Organizadores>();
            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT u.*,t.cod_autentificacao,t.organizacao,t.funcao from Usuario u JOIN Organizadores t ON t.id=u.id";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE u.nome_usuario like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Organizadores a = new Organizadores(Convert.ToInt16(dr["id"]), (String)dr["nome_usuario"], (String)dr["senha"], (String)dr["nome_completo"], (String)dr["cod_autentificacao"], (String)dr["organizacao"], (String)dr["funcao"]);
                    ListOrganizadores.Add(a);
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
            return ListOrganizadores;
        }


        public void InsertBD(Organizadores values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Usuario(id,nome_usuario,senha,nome_completo) values(?id,?nome,?senha,?nome_completo);";
            Com.CommandText += " INSERT INTO Organizadores(id,cod_autentificacao,organizacao,funcao) values(?id,?cod_autentificacao,?organizacao,?funcao);";
            Com.Parameters.AddWithValue("?nome", values.Nome_usuario);
            Com.Parameters.AddWithValue("?senha", values.Senha);
            Com.Parameters.AddWithValue("?nome_completo", values.Nome_completo);
            Com.Parameters.AddWithValue("?id", Banco_de_Dados.AutoIncrementaId("usuario", "id"));
            Com.Parameters.AddWithValue("?cod_autentificacao", values.Cod_autentificação);
            Com.Parameters.AddWithValue("?organizacao", values.Organização);
            Com.Parameters.AddWithValue("?funcao", values.Função);
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

        

        public void UpdateBD(string alvo, Organizadores novo_dado)
        {
            try
            {
                String sql = "UPDATE Usuario u JOIN Organizadores o ON u.id=o.id SET  u.nome_usuario = \'" + novo_dado.Nome_usuario + "\', u.senha   = \'" + novo_dado.Senha + "\', u.nome_completo = \'" + novo_dado.Nome_completo + "\', o.cod_autentificacao = \'" + novo_dado.Cod_autentificação +
                     "\', o.organizacao = \'" + novo_dado.Organização + "\', o.funcao = \'" + novo_dado.Função + "\' WHERE u.nome_usuario like \'" + alvo + "\';";
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
            Console.WriteLine(Com.CommandText);
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
