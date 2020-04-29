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

namespace QuizTwoForCSharp
{
    /// <summary>
    /// Interaction logic for Question5.xaml
    /// </summary>
    public partial class Question5 : Window
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            if (btAdd.Background == Brushes.Red)
            {
                btAdd.Background = Brushes.Blue;
            }
            else
            {
                btAdd.Background = Brushes.Red;
            }
        }
    }
}