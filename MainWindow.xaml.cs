using System.Windows;
using System.Windows.Controls;

namespace Tic_Tac_Toe
{
    public partial class MainWindow : Window
    {
        GameLogic game = new GameLogic();
        Dictionary<string, int[]> buttonsMap = new Dictionary<string, int[]>
        {
            {"topleft", new int[] {0,0} },
            {"topcenter",  new int[] {0,1} },
            {"topright",  new int[] {0,2} },
            {"midleft",  new int[] {1,0}},
            {"midcenter",  new int[] {1,1} },
            {"midright",  new int[] {1,2} },
            {"bottomleft",  new int[] {2,0} },
            {"bottomcenter",  new int[] {2,1} },
            {"bottomright",  new int[] {2,2} },
        };
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement element in MainGrid.Children)
            {
                if (element is Button button)
                {
                    button.Click += Button_Click;
                }
                RefreshField();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (game.playerTurn && !game.Gameover)
            {
                Button clickedButton = (Button)sender;
                if(buttonsMap.ContainsKey(clickedButton.Name))
                {
                    game.PlayerTurn(buttonsMap[clickedButton.Name]);
                }
            }
        }
        public void RefreshField()
        {
            foreach (UIElement element in MainGrid.Children)
            {
                if (element is Button button && buttonsMap.ContainsKey(button.Name))
                {
                    var point = game.field[buttonsMap[button.Name][0], buttonsMap[button.Name][1]];
                    if (point == 1)
                    {
                        button.Content = "O";
                        button.IsHitTestVisible = false;
                    }
                    if (point == 2)
                    {
                        button.Content = "X";
                        button.IsHitTestVisible = false;
                    }
                    if (point == 0)
                    {
                        button.Content = string.Empty;
                        button.IsHitTestVisible = true;
                    }
                }
            }
            var serializer = new Serializer();
            var stats = serializer.GetStats();
            if (stats == null) stats = new StatsModel();
            gamesTEXT.Text = "Games: " + stats.Games.ToString();
            winsTEXT.Text = "Wins: " + stats.Wins.ToString();
        }

        private void restartButt_Click(object sender, RoutedEventArgs e)
        {
            game = new GameLogic();
            game.GameStart();
            RefreshField();
        }
        private void startButt_Click(object sender, RoutedEventArgs e)
        {
            game.GameStart();
            startButt.IsEnabled = false;
            restartButt.IsEnabled = true;
            RefreshField();
        }
    }
}