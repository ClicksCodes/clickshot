using System;
using Microsoft.Xna.Framework.Input;

namespace ClickShot.Game_Logic
{

    public class ClickHandlerArgs : EventArgs
    {

    }
    
    public class ClickHandler
    {
        public event EventHandler Clicked;

        protected virtual void OnClicked(EventArgs e)
        {
            EventHandler handler = Clicked;
            handler?.Invoke(this, e);
        }
        
        private MouseState _m = Mouse.GetState();
        
        
        
    }
}