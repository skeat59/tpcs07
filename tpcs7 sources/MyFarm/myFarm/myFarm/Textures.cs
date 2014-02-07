using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace myFarm
{
    static class Textures
    {
        public static Texture2D pony_texture;
        public static Texture2D chick_texture;
        public static Texture2D dirt_texture;
        public static Texture2D farm_texture;
        public static Texture2D grass_texture;
        public static Texture2D hen_texture;

        public static void load(ContentManager cm)
        {
            pony_texture = cm.Load<Texture2D>(@"Sprites\pony");
            chick_texture = cm.Load<Texture2D>(@"Sprites\pony");
            dirt_texture = cm.Load<Texture2D>(@"Sprites\dirt");
            farm_texture = cm.Load<Texture2D>(@"Sprites\farm");
            grass_texture = cm.Load<Texture2D>(@"Sprites\grass");
            hen_texture = cm.Load<Texture2D>(@"Sprites\hen");
        }
    }
}
