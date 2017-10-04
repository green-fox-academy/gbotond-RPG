using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows.Input;
using System.Windows.Controls;

namespace RPG
{
    class Character : Area
    {
        public double positionX = 0;
        public double positionY = 0;

        public void PlaceHero(FoxDraw foxDraw)
        {
            foxDraw.AddImage("./Assets/hero-down.png", positionX, positionY);
        }
    }
}
