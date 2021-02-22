using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace viergewinnt.Model
{
    public class GameBoard
    {
        public  GameToken[,] Board { get; set; }


        public GameBoard()
        {
            Board = new GameToken[10, 7];
            
            for(int i = 0; i <= 9; i++)
            {
                for(int j = 0; j <= 6; j++)
                {
                    Board[i, j] = new GameToken(TokenColor.Blank);
                }
            }
        }
    }
}
