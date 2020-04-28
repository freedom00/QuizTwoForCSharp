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
    /// Interaction logic for Question4.xaml
    /// </summary>
    public partial class Question4 : Window
    {
        private List<Student> listStudnts;
        private List<Student> listAddedStudents;

        public Question4()
        {
            listStudnts = new List<Student>();
            for (int i = 1; i < 6; i++)
            {
                listStudnts.Add(new Student(i, "Name" + i, false));
            }
            InitializeComponent();
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            int id;
            if (!int.TryParse(tbId.Text, out id))
            {
                MessageBox.Show(this, "Id is not a number", "Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                tbId.Text = "";
                return;
            }
            if (id < 1 || id > 5)
            {
                MessageBox.Show(this, "User is not in the list", "Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                tbId.Text = "";
                return;
            }
            var student = (from s in listStudnts where s.Id == id select s).First();
            if (student.isAdded)
            {
                MessageBox.Show(this, "User already is in the list", "Operation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                tbId.Text = "";
                return;
            }
            lbStudents.Items.Add(student);
            student.isAdded = true;
            tbId.Text = "";
        }
    }
}