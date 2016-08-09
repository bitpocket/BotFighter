using System;

namespace Game
{
    public interface IPlayer
    {
        Guid Guid {get; set;}
        string PlayerName { get; set; }
        PlayerServerRole PlayerServerRole { get; set; }
    }
}