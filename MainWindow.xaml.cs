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
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            var selectedDate = datePicker.SelectedDate;

            if (datePicker.SelectedDate == null) return;
            DateTime dateValue = (DateTime)selectedDate;

            var age = GetAge(dateValue);

            if (!CheckAge(age))
            {
                MessageBoxResult displayError = MessageBox.Show("Entered date cannot be a birthday.","ERROR");
            }
            else
            {
                MessageWindow ageWindow = new MessageWindow();
                ageWindow.tb1.Text += $" Your age: {age.ToString()}"; 
                if(CheckBirthday(dateValue)) ageWindow.tb1.Text += "\n Today is your b-day!";
               
                ageWindow.Show();

                MessageWindow westernZodiacWindow = new MessageWindow();
                westernZodiacWindow.tb1.Text += $" Your western zodiac sign:\n {GetWesternZodiac(dateValue)}";
                westernZodiacWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                westernZodiacWindow.Top = 300;
                westernZodiacWindow.Left = 420;

                westernZodiacWindow.Show();


                MessageWindow chineseZodiacWindow = new MessageWindow();
                chineseZodiacWindow.tb1.Text += $" Your chinese zodiac sign:\n {GetChineseZodiac(dateValue)}";
                chineseZodiacWindow.WindowStartupLocation = WindowStartupLocation.Manual;
                chineseZodiacWindow.Top = 300;
                chineseZodiacWindow.Left = 800;

                chineseZodiacWindow.Show();

            }


        }

        public int GetAge(DateTime birthDate)
        {
            var currentDate = DateTime.Today;

            int age = currentDate.Year - birthDate.Year;

            if (birthDate > currentDate.AddYears(-age))
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

        public string GetWesternZodiac(DateTime birthDate)
        {
            string[] zodiacSigns = {"Aries", "Taurus", "Gemini", "Cancer","Leo", "Virgo", "Libra",
                                     "Scorpio", "Sagittarius","Capricorn", "Aquarius", "Pisces"};

            var birthDay = birthDate.Day;
            var birthMonth = birthDate.Month;

            string zodiac = "";

            switch (birthMonth)
            {
                case 1:
                    if (birthDay >= 1 && birthDay <= 19) zodiac = zodiacSigns[9];
                    else zodiac = zodiacSigns[10];
                    break;
                case 2:
                    if (birthDay >= 1 && birthDay < 19) zodiac = zodiacSigns[10];
                    else zodiac = zodiacSigns[11];
                    break;
                case 3:
                    if (birthDay >= 1 && birthDay <= 20) zodiac = zodiacSigns[11];
                    else zodiac = zodiacSigns[0];
                    break;
                case 4:
                    if (birthDay >= 1 && birthDay < 20) zodiac = zodiacSigns[0];
                    else zodiac = zodiacSigns[1];
                    break;
                case 5:
                    if (birthDay >= 1 && birthDay <= 20) zodiac = zodiacSigns[1];
                    else zodiac = zodiacSigns[2];
                    break;
                case 6:
                    if (birthDay >= 1 && birthDay <= 20) zodiac = zodiacSigns[2];
                    else zodiac = zodiacSigns[3];
                    break;
                case 7:
                    if (birthDay >= 1 && birthDay <= 22) zodiac = zodiacSigns[3];
                    else zodiac = zodiacSigns[4];
                    break;
                case 8:
                    if (birthDay >= 1 && birthDay <= 22) zodiac = zodiacSigns[4];
                    else zodiac = zodiacSigns[5];
                    break;
                case 9:
                    if (birthDay >= 1 && birthDay <= 22) zodiac = zodiacSigns[5];
                    else zodiac = zodiacSigns[6];
                    break;
                case 10:
                    if (birthDay >= 1 && birthDay <= 22) zodiac = zodiacSigns[6];
                    else zodiac = zodiacSigns[7];
                    break;
                case 11:
                    if (birthDay >= 1 && birthDay <= 21) zodiac = zodiacSigns[7];
                    else zodiac = zodiacSigns[8];
                    break;
                case 12:
                    if (birthDay >= 1 && birthDay <= 21) zodiac = zodiacSigns[8];
                    else zodiac = zodiacSigns[9];
                    break;
                default:
                    break;
            }
            return zodiac;
        }

        public string GetChineseZodiac(DateTime birthDate)
        {

            string[] zodiacSigns = {"Monkey", "Rooster", "Dog", "Pig","Rat", "Ox", "Tiger",
                                     "Hare", "Dragon","Snake", "Horse", "Sheep"};

            var birthYear = birthDate.Year;

            int N = birthYear % 12;
            string zodiac = zodiacSigns[N];

            return zodiac;
        }
    }
}
