using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placar_Brasil.Classes
{
    class Jogo
    {
        private int id;
        private Equipe equipeCasa;
        private int golsEquipeCasa;
        private Equipe equipeFora;
        private int golsEquipeFora;
        private Estadio local;
        private Campeonato campeonato;
        private Organizadores responsavel;

        public Jogo(int id, Equipe equipeCasa, int golsEquipeCasa, Equipe equipeFora, int golsEquipeFora, Estadio local, Campeonato campeonato, Organizadores responsavel)
        {
            this.id = id;
            this.equipeCasa = equipeCasa;
            this.golsEquipeCasa = golsEquipeCasa;
            this.equipeFora = equipeFora;
            this.golsEquipeFora = golsEquipeFora;
            this.local = local;
            this.campeonato = campeonato;
            this.responsavel = responsavel;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        internal Equipe EquipeCasa
        {
            get
            {
                return equipeCasa;
            }

            set
            {
                equipeCasa = value;
            }
        }

        public int GolsEquipeCasa
        {
            get
            {
                return golsEquipeCasa;
            }

            set
            {
                golsEquipeCasa = value;
            }
        }

        internal Equipe EquipeFora
        {
            get
            {
                return equipeFora;
            }

            set
            {
                equipeFora = value;
            }
        }

        public int GolsEquipeFora
        {
            get
            {
                return golsEquipeFora;
            }

            set
            {
                golsEquipeFora = value;
            }
        }

        internal Estadio Local
        {
            get
            {
                return local;
            }

            set
            {
                local = value;
            }
        }

        internal Campeonato Campeonato
        {
            get
            {
                return campeonato;
            }

            set
            {
                campeonato = value;
            }
        }

        internal Organizadores Responsavel
        {
            get
            {
                return responsavel;
            }

            set
            {
                responsavel = value;
            }
        }
    }
}
