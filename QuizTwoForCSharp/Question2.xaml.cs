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
    /// Interaction logic for Question2.xaml
    /// </summary>
    public partial class Question2 : Window
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, RoutedEventArgs e)
        {
            if (!calChoose.SelectedDate.HasValue)
            {
                MessageBox.Show(this, "Please select a date", "Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            new Question22(calChoose.SelectedDate.Value.ToString()).Show();
        }
    }
}