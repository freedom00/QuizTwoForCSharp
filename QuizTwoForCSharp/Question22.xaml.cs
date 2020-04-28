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
    /// Interaction logic for Question22.xaml
    /// </summary>
    public partial class Question22 : Window
    {
        public Question22()
        {
            InitializeComponent();
        }

        public Question22(String date)
        {
            InitializeComponent();
            lblDate.Content = date;
        }
    }
}