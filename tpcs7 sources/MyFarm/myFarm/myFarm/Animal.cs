
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFarm
{
    abstract class Animal:Drawable
    {
        protected int nb_legs;
        public int pos_x;
        public int pos_y;
        public drawable_type drawable_t;
        public Animal(int nb_legs, int pos_x, int pos_y, drawable_type drawable_t)
            :base(drawable_t)
        {
            this.nb_legs = nb_legs;
            this.pos_x = pos_x;
            this.pos_y = pos_y;
        }

        class Pony: Animal
        {
            private static Random rand = new Random();
            private int awesome_lvl;
            public Pony(int pos_x, int pos_y)
                   : base(4, pos_x, pos_y, drawable_type.pony)
            {
                awesome_lvl = rand.Next(41);
            }
        }

        class Hen : Animal
        {
            private static Random rand = new Random();
            protected int nb_feathers;
            public Hen(int pos_x, int pos_y)
                   :base(2, pos_x, pos_y, drawable_type.hen)
            {
                nb_feathers = rand.Next(301, 2500);
            }
        }
    }
}
