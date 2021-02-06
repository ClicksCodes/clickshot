using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace ClickShot.Towers
{
    public class Wall : BaseTower
    {
        
        internal Wall(Game game) : base(game, "Wall")
        {
            Lvl = 0;
        }
    }
}