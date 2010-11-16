using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sengoku
{
    class gamePieces
    {
        public enum Rank { Alpha, Beta };

        private Rank rank;
        private players.playerClass playerClass;


        public gamePieces(Rank rank, players.playerClass playerClass)
        {
            this.rank = rank;
            this.playerClass = playerClass;
        }

    }
}
