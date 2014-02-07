using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace myFarm
{
    public enum drawable_type
    {
        farm,
        dirt,
        grass,
        pony,
        hen,
        chick,
        none
    }

    public abstract class Drawable
    {
        public Texture2D image;
        
        protected Vector2 origin = new Vector2(100, 100);
        protected Vector2 offset = new Vector2(30, 30);

        protected Drawable(drawable_type drawable_t)
        {
            switch (drawable_t)
            {
                case drawable_type.pony :
                    image = Textures.pony_texture;
                    break;
                default :
                    image = null;
                    break;
            }
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(image, new Vector2(0, 0), Color.White);
        }

        public void Draw(SpriteBatch sb, Vector2 pos)
        {
            sb.Draw(image, origin + (pos * offset), Color.White);
        }
    }
}
