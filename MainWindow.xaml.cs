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

namespace WPF___TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int turns = 0;
        public int player = 2;
        public int input = 0;
        public bool inputCorrect = true;
        public bool playerWon = false;
        public MainWindow()
        {
            InitializeComponent();
            do
            {
                if(player == 2)
                {
                    player = 1;
                }
            }
        }

        private void TopLeft_Click(object sender, RoutedEventArgs e)
        {
            TopLeft.Content = "X";
        }
    }
}
