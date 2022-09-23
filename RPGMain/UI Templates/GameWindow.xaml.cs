using RPGMain.Controls;
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
using System.Windows.Shapes;

namespace RPGMain.UI_Templates
{
    /// <summary>
    /// Interaction logic for GameWindowContinueGame.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow(string sender)
        {
            InitializeComponent();

            switch (sender)
            {
                case "New Game":
                    _mainFrame.Navigate(new NewGameControl());
                    break;
                case "Continue Game":
                    _mainFrame.Navigate(new ContinueGameControl());
                    break;
            }
        }

    }
}
