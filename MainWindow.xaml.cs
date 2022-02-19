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
        //button click logic
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = datePicker.SelectedDate;

            if (datePicker.SelectedDate == null) return;
            DateTime dateValue = (DateTime)selectedDate;

            Statistics statistics = new Statistics(dateValue);
            var age = statistics.GetAge();

            if (!statistics.CheckAge())
            {
                MessageBoxResult displayError = MessageBox.Show("Entered date cannot be a birthday.", "ERROR");
            }
            else
            {

                MessageWindow ageWindow = new MessageWindow();
                ageWindow.tb1.Text += $" Your age: {age.ToString()}.";
                if (statistics.CheckBirthday()) ageWindow.tb1.Text += " Today is your b-day!";
               
                ageWindow.Show();

                MessageWindow westernZodiacWindow = new MessageWindow();
                westernZodiacWindow.tb1.Text += $" Your western zodiac sign:\n {statistics.GetWesternZodiac()}";
                westernZodiacWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                westernZodiacWindow.Top = 300;
                westernZodiacWindow.Left = 420;

                westernZodiacWindow.Show();


                MessageWindow chineseZodiacWindow = new MessageWindow();
                chineseZodiacWindow.tb1.Text += $" Your chinese zodiac sign:\n {statistics.GetChineseZodiac()}";
                chineseZodiacWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                chineseZodiacWindow.Top = 300;
                chineseZodiacWindow.Left = 800;

                chineseZodiacWindow.Show();

            }


        }

    }
}
