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

namespace Lab1
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

        public int GetAge(DateTime birthDate)
        {
            var currentDate = DateTime.Today;

            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || 
                (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
                age--;

            return age;
        }

        public bool CheckAge(int age)
        {
            if (age < 0 || age > 135) return false;
            return true;
        }

        public bool CheckBirthday(DateTime birthDate)
        {
            var currentDate = DateTime.Today;
            if (birthDate.Month == currentDate.Month && birthDate.Day == currentDate.Day) return true;
            return false;
        }

        public string GetWesternZodiac()
        {
            return "";
        }
    }
}
