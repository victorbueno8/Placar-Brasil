using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class TecnicoDAO : InterfaceDAO<Tecnico>
    {

        public List<Tecnico> SelectBD(string pesquisa)
        {
            List<Tecnico> ListTecnico = new List<Tecnico>();

            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT pe.*,t.*,e.id as equipeid,e.nome as equipenome from ProfisionaisEquipe pe JOIN Tecnico t ON t.id=pe.id JOIN Equipe e ON e.id=pe.id_Equipe";
                if (pesquisa != "")
                {
                    cmd.CommandText += " WHERE pe.nome like \'" + pesquisa + "\' or e.nome like \'" + pesquisa + "\';";
                }
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Tecnico a = new Tecnico(Convert.ToInt16(dr["id"]), (String)dr["doc_identidade"], (String)dr["nome"], (String)dr["cidade_origem"], new Equipe(Convert.ToInt16(dr["equipeid"]), (String)dr["equipenome"]), Convert.ToDouble(dr["anos_experiencia"]));
                    ListTecnico.Add(a);
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
            return ListTecnico;
        }


        public void InsertBD(Tecnico values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO ProfisionaisEquipe(id,doc_identidade,nome,cidade_origem,id_Equipe) values(?id,?doc_identidade,?nome,?cidade_origem,?Equipe);";
            Com.CommandText += " INSERT INTO Tecnico(id,anos_experiencia) Values(?id,?anos_experiencia)";
            Com.Parameters.AddWithValue("?id", values.Id);
            Com.Parameters.AddWithValue("?doc_identidade", values.Doc_identidade);
            Com.Parameters.AddWithValue("?nome", values.Nome);
            Com.Parameters.AddWithValue("?cidade_origem", values.Cidade_origem);
            Com.Parameters.AddWithValue("?anos_experiencia", values.Anos_experiencia);
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


        public void UpdateBD(string alvo, Tecnico novo_dado)
        {
            try
            {
                String sql = "UPDATE ProfisionaisEquipe pe JOIN tecnico t ON t.id=pe.id SET  pe.doc_identidade = \'" + novo_dado.Doc_identidade + "\', pe.nome = \'" + novo_dado.Nome + "\', pe.cidade_origem = \'" + novo_dado.Cidade_origem + "\', t.anos_experiencia = \'" + novo_dado.Anos_experiencia +
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
