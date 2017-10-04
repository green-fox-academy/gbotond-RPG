using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GreenFox;
using System.Windows;

namespace RPG
{
    class Area
    {
        public static string floorTile = @"./Assets/floor.png";
        public static string wallTile = @"./Assets/wall.png";
        
        public void DrawFloor(FoxDraw foxDraw)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    foxDraw.AddImage(floorTile, i * 50, j * 50);
                }
            }
        }

        public List<Point> wallCoordinates = new List<Point>()
        {
            new Point (0, 200),
            new Point (50, 100),
            new Point (50, 200),
            new Point (50, 250),
            new Point (50, 300),
            new Point (50, 400),
            new Point (50, 500),
            new Point (100, 100),
            new Point (100, 200),
            new Point (100, 400),
            new Point (150, 0),
            new Point (150, 50),
            new Point (150, 100),
            new Point (150, 200),
            new Point (150, 250),
            new Point (150, 300),
            new Point (150, 400),
            new Point (150, 450),
            new Point (150, 500),
            new Point (250, 0),
            new Point (250, 50),
            new Point (250, 100),
            new Point (250, 150),
            new Point (250, 200),
            new Point (250, 300),
            new Point (250, 350),
            new Point (250, 450),
            new Point (250, 500),
            new Point (300, 200),
            new Point (300, 300),
            new Point (300, 350),
            new Point (300, 450),
            new Point (350, 50),
            new Point (350, 100),
            new Point (350, 200),
            new Point (400, 50),
            new Point (400, 100),
            new Point (400, 200),
            new Point (400, 250),
            new Point (400, 300),
            new Point (400, 350),
            new Point (400, 400),
            new Point (400, 450)

        };

        public void DrawWall(FoxDraw foxDraw)
        {
            foreach (Point point in wallCoordinates)
            {
                foxDraw.AddImage(wallTile, point.X, point.Y);
            }           
        }
    }
}
