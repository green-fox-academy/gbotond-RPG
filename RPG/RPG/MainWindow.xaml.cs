using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using GreenFox;


namespace RPG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        FoxDraw foxDraw;
        Hero myHero;
        Area gameArea;
        Character character;

        public MainWindow()
        {
            InitializeComponent();
            foxDraw = new FoxDraw(canvas);
            gameArea = new Area();
            character = new Character();
            myHero = new Hero(0, 0);

            gameArea.DrawFloor(foxDraw);
            gameArea.DrawWall(foxDraw);
            character.PlaceHero(foxDraw);
        }

        public void WindowKeyDown(object sender, KeyEventArgs e)
        {
            gameArea.DrawFloor(foxDraw);
            gameArea.DrawWall(foxDraw);

            if (e.Key == Key.Left)
            {
                Console.WriteLine("To the left!");
                myHero.HeroToLeft();
                foxDraw.AddImage("./Assets/hero-left.png", myHero.GetPositionX(), myHero.GetPositionY());
            }

            if (e.Key == Key.Right)
            {
                Console.WriteLine("To the right");
                myHero.HeroToRight();
                foxDraw.AddImage("./Assets/hero-right.png", myHero.GetPositionX(), myHero.GetPositionY());
            }

            if (e.Key == Key.Up)
            {
                Console.WriteLine("Up!");            
                myHero.HeroUp();
                foxDraw.AddImage("./Assets/hero-up.png", myHero.GetPositionX(), myHero.GetPositionY());
            }

            if (e.Key == Key.Down)
            {
                Console.WriteLine("Down!");
                myHero.HeroDown();
                foxDraw.AddImage("./Assets/hero-down.png", myHero.GetPositionX(), myHero.GetPositionY());
            }
        }
    }
}
