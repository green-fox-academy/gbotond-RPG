using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;

namespace RPG
{
    class Hero : Character
    {
        
        public Hero(double posX, double posY)
        {
            positionX = posX;
            positionY = posY;
        }

        public double GetPositionX()
        {
            return this.positionX;
        }

        public double GetPositionY()
        {
            return this.positionY;
        }

        public double HeroToRight()
        {
            if (positionX == 450) 
            {
                return positionX;
            }

            foreach (Point point in wallCoordinates)
            {
                if (positionX + 50 == point.X)
                {
                    if (positionY == point.Y)
                    {
                        return positionX;
                    }
                }
            }
            
            this.positionX = positionX + 50;
            return positionX;
        }

        public double HeroToLeft()
        {
            if (positionX == 0)
            {
                return positionX;
            }

            foreach (Point point in wallCoordinates)
            {
                if (positionX - 50 == point.X)
                {
                    if (positionY == point.Y)
                    {
                        return positionX;
                    }
                }
            }

            this.positionX = positionX - 50;
            return positionX;
        }

        public double HeroUp()
        {
            if (positionY == 0)
            {
                return positionY;
            }

            foreach (Point point in wallCoordinates)
            {
                if (positionX == point.X)
                {
                    if (positionY -50 == point.Y)
                    {
                        return positionX;
                    }
                }
            }

            this.positionY = positionY - 50;
            return positionY;
        }

        public double HeroDown()
        {
            if (positionY == 500)
            {
                return positionY;
            }

            foreach (Point point in wallCoordinates)
            {
                if (positionX  == point.X)
                {
                    if (positionY + 50 == point.Y)
                    {
                        return positionX;
                    }
                }
            }

            this.positionY = positionY + 50;
            return positionY;
        }
    }
}
