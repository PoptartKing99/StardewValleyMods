﻿using ButcherMod.meats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButcherMod.animals
{
    public enum Animal
    {
        [Meat(Meat.Beef)]
        Cow,
        [Meat(Meat.Pork)]
        Pig,
        [Meat(Meat.Chicken)]
        Chicken,
        [Meat(Meat.Duck)]
        Duck,
        [Meat(Meat.Rabbit)]
        Rabbit,
        [Meat(Meat.Mutton)]
        Sheep,
        [Meat(Meat.Mutton)]
        Goat
    }
}
