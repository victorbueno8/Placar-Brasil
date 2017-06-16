﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Placar_Brasil.Classes
{
    class CampeonatoDAO : InterfaceDAO<Campeonato>
    {
       
        public List<Campeonato> SelectBD(string pesquisa)
        {
            List<Campeonato> ListCampeonato = new List<Campeonato>();
            try
            {
                Banco_de_Dados.conectar();
                MySqlCommand cmd = Banco_de_Dados.MConn.CreateCommand();
                cmd.CommandText = "SELECT * from Campeonato";
                if (pesquisa != "")
                    cmd.CommandText += " WHERE nome like \'" + pesquisa + "\';";

                MySqlDataReader dr = cmd.ExecuteReader();
                cmd = new MySqlCommand(cmd.CommandText, Banco_de_Dados.MConn);
                while (dr.Read())
                {
                    Campeonato a = new Campeonato(Convert.ToInt16(dr["id"]), (String)dr["nome"], (String)dr["abrangencia"], (String)dr["descricao"]);
                    ListCampeonato.Add(a);
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
            return ListCampeonato;
        }

        public void InsertBD(Campeonato values)
        {
            Banco_de_Dados.conectar();
            MySqlCommand Com = Banco_de_Dados.MConn.CreateCommand();
            Com.CommandText = "INSERT INTO Campeonato(id,nome,abrangencia,descricao) values(?id,?nome,?abrangencia,?descricao);";
            Com.Parameters.AddWithValue("?id", values.Id);
            Com.Parameters.AddWithValue("?nome", values.Nome);
            Com.Parameters.AddWithValue("?abrangencia", values.Abrangencia);
            Com.Parameters.AddWithValue("?descricao", values.Descricao);

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

        public void UpdateBD(string alvo, Campeonato novo_dado)
        {
            try
            {
                String sql = "UPDATE campeonato SET nome = \'" + novo_dado.Nome + "\', abrangencia = \'" + novo_dado.Abrangencia + "\', descricao = \'" + novo_dado.Descricao + "\' WHERE nome = \'" + alvo + "\';";
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
            Com.CommandText = "DELETE FROM Campeonato WHERE nome like \'" + pesquisa + "\';";
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
