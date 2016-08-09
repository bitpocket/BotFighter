using System.Collections.Generic;

namespace Game
{
    public interface IMoveData
    {
        IEnumerable<object> MoveData { get; set; }
    }
}