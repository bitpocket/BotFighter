using System;

namespace Server
{
    public interface IPlayer
    {
        Guid Guid {get; set;}
        string PlayerName { get; set; }
        PlayerServerRole PlayerServerRole { get; set; }
    }
}