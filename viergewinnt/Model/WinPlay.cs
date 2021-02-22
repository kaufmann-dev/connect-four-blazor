using System.Collections.Generic;

namespace viergewinnt.Model
{
    public class WinPlay
    {
        public List<string> WinMoves { get; set; }
        public EDirection WinDirection { get; set; }
        public TokenColor WinColor { get; set; }
    }
}
