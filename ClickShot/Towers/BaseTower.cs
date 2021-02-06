using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace ClickShot.Towers
{
	public class BaseTower : DrawableGameComponent
	{
		private Texture2D _towerTexture;
		private readonly string _name;
		private readonly Game _game;
		public int Lvl;
		protected BaseTower(Game game, string name) : base(game)
		{
			_game = game;
			_name = name;
			Lvl = 0;
		}

		protected override void LoadContent()
		{
			_towerTexture = _game.Content.Load<Texture2D>($"{_name}_0");
			base.LoadContent();
		}

		public void Upgrade()
		{
			if (Lvl < 4)
				this.Lvl += 1;
			else if (Lvl == 4)
				return;
		}
	}
}