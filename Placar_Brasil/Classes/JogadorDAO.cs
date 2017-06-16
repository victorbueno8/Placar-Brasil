using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class JogadorDAO : InterfaceDAO<Jogador>
    {
        public List<Jogador> SelectBD(string pesquisa)
        {
            List<Jogador> ListJogador = new List<Jogador>();

            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();

                cmd.CommandText = "SELECT pe.*,j.*,e.id as equipeid,e.nome as equipenome from  ProfisionaisEquipe pe JOIN Jogador j ON j.id=pe.id JOIN Equipe e ON e.id=pe.id_Equipe";
                if(pesquisa != "")
                {
                    cmd.CommandText += " WHERE pe.nome like \'" + pesquisa + "\' or j.apelido like \'" + pesquisa + "\' or e.nome like \'" + pesquisa + "\';";
                }
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Jogador a = new Jogador(Convert.ToInt16(dr["id"]), (String)dr["doc_identidade"], (String)dr["nome"], (String)dr["cidade_origem"], new Equipe(Convert.ToInt16(dr["equipeid"]),(String)dr["equipenome"]), (String)dr["apelido"], (String)dr["posicao"]);
                    ListJogador.Add(a);
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
            return ListJogador;
        }

        public void InsertBD(Jogador values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO ProfisionaisEquipe(id,doc_identidade,nome,cidade_origem,id_Equipe) values(?id,?doc_identidade,?nome,?cidade_origem,?Equipe);";
            Com.CommandText += " INSERT INTO Jogador(id,posicao,apelido) values(?id,?posicao,?apelido);";
            Com.Parameters.AddWithValue("?id", values.Id);
            Com.Parameters.AddWithValue("?doc_identidade", values.Doc_identidade);
            Com.Parameters.AddWithValue("?nome", values.Nome);
            Com.Parameters.AddWithValue("?cidade_origem", values.Cidade_origem);
            Com.Parameters.AddWithValue("?posicao", values.Posicao);
            Com.Parameters.AddWithValue("?apelido", values.Apelido);
            Com.Parameters.AddWithValue("?Equipe", values.Equipe.Id);
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

        public void UpdateBD(string alvo, Jogador novo_dado)
        {
            try
            {
                String sql = "UPDATE ProfisionaisEquipe pe JOIN jogador j ON j.id=pe.id SET  doc_identidade = \'" + novo_dado.Doc_identidade + "\', pe.nome = \'" + novo_dado.Nome + "\', pe.cidade_origem = \'" + novo_dado.Cidade_origem + "\', j.posicao = \'" + novo_dado.Posicao + "\', j.apelido = \'" + novo_dado.Apelido +
                     "\', pe.id_Equipe = \'" + novo_dado.Equipe.Id + "\' WHERE pe.nome like \'" + alvo + "\';";
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
            Com.CommandText = "DELETE FROM ProfisionaisEquipe WHERE nome like \'" + pesquisa + "\';";
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
