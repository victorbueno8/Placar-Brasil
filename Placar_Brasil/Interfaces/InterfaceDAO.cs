using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Placar_Brasil.Classes
{
    public interface InterfaceDAO<T> where T : class
    { 
        List<T> SelectBD(string pesquisa);
        void InsertBD(T values);
        void UpdateBD(string alvo, T novo_dado);
        void DeleteBD(string pesquisa);
    }
}
