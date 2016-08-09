using GameBase.Game;

namespace SimpleGame
{
    public class SimpleGameHeader : IGameHeader
    {
        public string Name { get; set; } = "Simple Game";
        public string Description { get; set; }
        public int MaxPlayer { get; set; } = 2;
    }
}