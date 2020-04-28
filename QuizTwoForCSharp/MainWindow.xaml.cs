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

namespace QuizTwoForCSharp
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

        private void btQuestion1_Click(object sender, RoutedEventArgs e)
        {
            new Question1().Show();
        }

        private void btQuestion2_Click(object sender, RoutedEventArgs e)
        {
            new Question2().Show();
        }

        private void btQuestion3_Click(object sender, RoutedEventArgs e)
        {
            new Question3().Show();
        }

        private void btQuestion4_Click(object sender, RoutedEventArgs e)
        {
            new Question4().Show();
        }

        private void btQuestion5_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}