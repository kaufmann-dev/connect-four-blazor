using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace viergewinnt.Model
{
    public class GameToken
    {
        public TokenColor Color;

        public GameToken()
        {
            Color = TokenColor.Blank;
        }

        public GameToken(TokenColor color)
        {
            Color = color;
        }
    }
}
