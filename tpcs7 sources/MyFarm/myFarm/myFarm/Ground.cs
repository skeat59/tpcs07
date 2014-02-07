using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;

namespace myFarm
{
     class Ground: Drawable
    {
        public bool occupied;
        public Animal containg;
        public drawable_type typFe;
        enum groundType
        {
            Grass,
            Dirt
        };
        public Ground(Vector2 pos, groundType ground_t, drawable_type draw_type)
            :base(draw_type)
        {
            occupied = false;
            draw_type = type;
        }
    }
}
