using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Statistics
    {
        private DateTime birthDate;
        private int age;

        //constructor
        public Statistics(DateTime birthDate)
        {
            this.birthDate = birthDate;
            this.age = GetAge();

        }
        //calculating age from birth date
        public int GetAge()
        {
            var currentDate = DateTime.Today;

            int age = currentDate.Year - birthDate.Year;

            if (birthDate > currentDate.AddYears(-age))
                age--;

            return age;
        }

        //checking if age is valid
        public bool CheckAge()
        {
            if (age < 0 || age > 135) return false;
            return true;
        }

        //checking if today is a birthday
        public bool CheckBirthday()
        {
            var currentDate = DateTime.Today;
            if (birthDate.Month == currentDate.Month && birthDate.Day == currentDate.Day) return true;
            return false;
        }

        //getting western zodiac sign
        public string GetWesternZodiac()
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

        //calculating chinese zodiac sign
        public string GetChineseZodiac()
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
