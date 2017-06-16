using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class JogoDAO : InterfaceDAO<Jogo>
    {
        public List<Jogo> SelectBD(string pesquisa)
        {
            List<Jogo> ListJogo = new List<Jogo>();
            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT j.id,ec.nome as Casa,j.golsEquipeCasa,ef.nome as Fora,j.golsEquipeFora,s.nome as Estadio,c.nome as Campeonato,u.nome_usuario as organizador";
                cmd.CommandText += " FROM Jogo j JOIN Equipe ec ON ec.id=j.id_EquipeCasa JOIN Equipe ef ON ef.id=j.id_EquipeFora";
                cmd.CommandText += " JOIN Estadio s ON s.id=j.estadio JOIN Campeonato c ON c.id=j.campeonato JOIN Organizadores o ON o.id=j.responsavel JOIN Usuario u ON u.id=o.id";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE ec.nome like \'" + pesquisa + "\' or ef.nome like \'" + pesquisa + "\' or s.nome like \'" + pesquisa + "\' or c.nome like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Jogo a = new Jogo(Convert.ToInt16(dr["id"]), new EquipeDAO().SelectBD((String)dr["Casa"])[0], Convert.ToInt16(dr["golsEquipeCasa"]), new EquipeDAO().SelectBD((String)dr["Fora"])[0], Convert.ToInt16(dr["golsEquipeFora"]),new EstadioDAO().SelectBD((String)dr["estadio"])[0], new CampeonatoDAO().SelectBD((String)dr["campeonato"])[0],new OrganizadorDAO().SelectBD((String)dr["organizador"])[0]);
                    ListJogo.Add(a);
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
            return ListJogo;
        }


        public void InsertBD(Jogo values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Jogo(id,id_EquipeCasa,golsEquipeCasa,id_EquipeFora,golsEquipeFora,estadio,campeonato,responsavel) values(?id,?id_EquipeCasa,?golsEquipeCasa,?id_EquipeFora,?golsEquipeFora,?estadio,?campeonato,?responsavel);";
            Com.Parameters.AddWithValue("?id", Banco_de_Dados.AutoIncrementaId("Jogo","id"));
            Com.Parameters.AddWithValue("?id_EquipeCasa", values.EquipeCasa.Id);
            Com.Parameters.AddWithValue("?golsEquipeCasa", values.GolsEquipeCasa);
            Com.Parameters.AddWithValue("?id_EquipeFora", values.EquipeFora.Id);
            Com.Parameters.AddWithValue("?golsEquipeFora", values.GolsEquipeFora);
            Com.Parameters.AddWithValue("?estadio", values.Local.Id);
            Com.Parameters.AddWithValue("?campeonato", values.Campeonato.Id);
            Com.Parameters.AddWithValue("?responsavel", values.Responsavel.Id);
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

        

        public void UpdateBD(string alvo, Jogo novo_dado)
        {
            throw new NotImplementedException();
        }


        public void DeleteBD(string pesquisa)
        {
            throw new NotImplementedException();
        }
    }
}
