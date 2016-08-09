using System.Collections.Generic;

namespace Server
{
    public interface IMoveData
    {
        IEnumerable<object> MoveData { get; set; }
    }
}