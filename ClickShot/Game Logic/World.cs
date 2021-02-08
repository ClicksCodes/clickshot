using System.Collections.Generic;

namespace ClickShot.Game_Logic
{
    public class World
    {

        public object GameInfo { get; set; }
        
        private Dictionary<string, dynamic> _difficulties = new Dictionary<string, dynamic>()
        {
            {"Easy", new Dictionary<string, dynamic>()
            {
                {"LevelSize", (30,15)}
            }},
            {"Medium", new Dictionary<string, dynamic>()
            {
                {"LevelSize", (30,15)}
            }},
            {"Hard", new Dictionary<string, dynamic>()
            {
                {"LevelSize", (30,15)}
            }},
            {"Extreme", new Dictionary<string, dynamic>()
            {
                {"LevelSize", (30,15)}
            }}
        };

        public World(string diff)
        {
            GameInfo = _difficulties[diff];
        }

        
    }
}