using System.Windows;

namespace Tic_Tac_Toe
{
    class GameLogic
    {
        public int[,] field = new int[3, 3];
        public bool playerTurn;
        public bool Gameover{ get; private set; }
        
        int moves;
        public void GameStart()
        {
            Serializer serializer = new Serializer();
            serializer.Serialize(1, 0);
            Random random = new();
            playerTurn = random.Next(0, 2) == 0 ? true : false;
            NextTurn();
        }
        void NextTurn()
        {
            if (!playerTurn && !Gameover)
            {
                ComputerTurn();
            }
        }
        public void PlayerTurn(int[] buttonNum)
        {
            FillArray(buttonNum, 1);

            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.RefreshField();

            playerTurn = false;
            NextTurn();
        }
        async void ComputerTurn()
        {
            await Task.Delay(500);

            FillArray(ComputerLogic.TakePoint(moves, field), 2);
            playerTurn = true;
        }
        void FillArray(int[] buttonNum, int numPlayerOrComp)
        {
            field[buttonNum[0], buttonNum[1]] = numPlayerOrComp;
            WinnerCheck();
        }
        void WinnerCheck()
        {
            moves++;
            MainWindow? mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow?.RefreshField();
            int winner = 0;
            for (int i = 0; i < 3; i++)
            {
                if (field[i, 1] != 0 && field[i, 1] == field[i, 0] && field[i, 1] == field[i, 2])
                {
                    winner = field[i, 1];
                    Gameover = true;
                }
                if (field[1, i] != 0 && field[1, i] == field[0, i] && field[1, i] == field[2, i])
                {
                    winner = field[1, i];
                    Gameover = true;
                }
            }
            if (field[1, 1] != 0 && ((field[1, 1] == field[0, 0] && field[1, 1] == field[2, 2])
                                || (field[1, 1] == field[0, 2] && field[1, 1] == field[2, 0])))
            {
                winner = field[1, 1];
                Gameover = true;
            }
            if (Gameover)
            {
                MessageBox.Show(winner == 1 ? "Ты победил" : "Ты проиграл");
                if (winner == 1)
                {
                    Serializer serializer = new Serializer();
                    serializer.Serialize(0, 1);
                } 
            }
            else
            {
                if (moves > 8)
                {
                    Gameover = true;
                    MessageBox.Show("Ничья");
                }
            }
        }
    }
}
