using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ClickShot
{
	public class Game1 : Game
	{

        private readonly Color _backgroundColor = Color.FromNonPremultiplied(113, 174, 242, 255);
		Texture2D ballTexture;
		Vector2 ballPosition;
		float ballSpeed;
		private GraphicsDeviceManager _graphics;
		private SpriteBatch _spriteBatch;
		private Boolean mouseDown;

		public Game1()
		{
			Window.AllowUserResizing = true;
			_graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			IsMouseVisible = true;
		}

		protected override void Initialize()
		{
			// ReSharper disable twice PossibleLossOfFraction
			ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2, _graphics.PreferredBackBufferHeight / 2);
			ballSpeed = 100f;

			base.Initialize();
		}

		protected override void Update(GameTime gameTime)
		{
			if (Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

            var k = Keyboard.GetState();
			var m = Mouse.GetState();
			if (mouseDown != (m.LeftButton == ButtonState.Pressed)) {
				mouseDown = m.LeftButton == ButtonState.Pressed;
				Console.WriteLine("Your mouse is now " + (mouseDown ? "down" : "not down"));
			}
            ballPosition.X = m.X;
            ballPosition.Y = m.Y;
            Console.WriteLine(m);
            
			if (true) {
				
			}


			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(_backgroundColor);
			_spriteBatch.Begin();
            _spriteBatch.Name = "Ball1";
			_spriteBatch.Draw(
                ballTexture, 
                ballPosition, 
                null,
                Color.White, 
                0f, 
                new Vector2(ballTexture.Width / 2, ballTexture.Height / 2), 
                Vector2.One, 
                SpriteEffects.None, 
                0f
            );
			_spriteBatch.End();
			base.Draw(gameTime);
		}
	}
}
