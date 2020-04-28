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
    /// Interaction logic for Question1.xaml
    /// </summary>
    public partial class Question1 : Window
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void btResset_Click(object sender, RoutedEventArgs e)
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNumber.Text = "";
        }

        private void btSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this, $"First Name: {tbFirstName.Text}; Last Name: {tbLastName.Text}; Phone Number: {tbPhoneNumber.Text}", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}