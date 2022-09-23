using System.Windows;
using System.Windows.Input;
using RPGMain.UI_Templates;

namespace RPGMain
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

         /// <summary>
         /// User selected 'New Game' from main menu
         /// </summary>
        private void NewGame_OnClick(object sender, MouseButtonEventArgs e)
        {
            GameWindow newGameStart = new GameWindow("New Game");
            newGameStart.Show();
            this.Close(); // close main menu 
        }

        /// <summary>
        /// User selected 'Continue' from main menu
        /// </summary>
        private void ContinueGame_OnClick(object sender, MouseButtonEventArgs e)
        {
            GameWindow continueGameStart = new GameWindow("Continue Game");
            continueGameStart.Show();
            this.Close(); // close main menu 
        }

        /// <summary>
        /// User selected 'Credits' from main menu
        /// </summary>
        private void Credits_OnClick(object sender, MouseButtonEventArgs e)
        {
            Credits showCredits = new Credits();
            showCredits.Show();
            this.Close(); // close main menu 
        }

        /// <summary>
        /// User selected 'Exit' from main menu
        /// </summary>
        private void Exit_OnClick(object sender, MouseButtonEventArgs e)
        {
            this.Close(); // close program
        }
    }// end MainWindow

}// end namespace RPG
