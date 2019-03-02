using CSharp_02.Tools;
using System;

namespace CSharp_02.Models
{
    class Person : BaseViewModel
    {
     
        private DateTime dateOfBirth = DateTime.Today;
        private readonly int age;
        private readonly string sunSign;
        private readonly string chineseSign;
        private readonly bool isBirthday;

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public string SunSign
        {
            get
            {
                return sunSign;
            }
        }

        public string ChineseSign
        {
            get
            {
                return chineseSign;
            }
          
        }

        public bool IsBirthday
        {
            get
            {
                return isBirthday;
            }
        }

        public Person (DateTime date)
        {
            dateOfBirth = date;
            sunSign = GetSunSign(date);
            chineseSign = GetChineseSign(date);
            isBirthday = GetIsBirthday(date);
            age = GetAge(date);
        }

        public Person()
        {
        }

        public string GetSunSign(DateTime date)
        {
            int day = date.Day;
            int age = GetAge(date);
            if (age <= 135 && age >= 0)
            {
                switch (date.Month)
                {
                    case 1:
                        if (day < 21)
                            return "Козоріг";
                        return "Водолій";
                    case 2:
                        if (day < 21)
                            return "Водолій";
                        return "Риби";
                    case 3:
                        if (day < 21)
                            return "Риби";
                        return "Овен";
                    case 4:
                        if (day < 21)
                            return "Овен";
                        return "Телець";
                    case 5:
                        if (day < 21)
                            return "Телець";
                        return "Близнюки";
                    case 6:
                        if (day < 22)
                            return "Близнюки";
                        return "Рак";
                    case 7:
                        if (day < 23)
                            return "Рак";
                        return "Лев";
                    case 8:
                        if (day < 24)
                            return "Лев";
                        return "Діва";
                    case 9:
                        if (day < 23)
                            return "Діва";
                        return "Терези";
                    case 10:
                        if (day < 24)
                            return "Терези";
                        return "Скорпіон";
                    case 11:
                        if (day < 23)
                            return "Скорпіон";
                        return "Стрілець";
                    case 12:
                        if (day < 21)
                            return "Стрілець";
                        return "Риби";
                }
            }
            return "Error";
        }

        public string GetChineseSign(DateTime date)
        {
            int startYear = 1876;
            int year = date.Year;
            int age = GetAge(date);

            while ((year - startYear) >= 12)
            {
                startYear += 12;
            }

            int resultNumber = year - startYear + 1;
            if (age <= 135 && age >= 0)
            {
                switch (resultNumber)
                {
                    case 1:
                        return "Щур";
                    case 2:
                        return "Бик";
                    case 3:
                        return "Тигр";
                    case 4:
                        return "Заєць";
                    case 5:
                        return "Дракон";
                    case 6:
                        return "Змія";
                    case 7:
                        return "Кінь";
                    case 8:
                        return "Вівця";
                    case 9:
                        return "Мавпа";
                    case 10:
                        return "Півень";
                    case 11:
                        return "Собака";
                    case 12:
                        return "Свиня";
                }
            }
            return "Error";
        }

        public bool GetIsBirthday(DateTime date)
        {
            if (date.Day == DateTime.Today.Day && date.Month == DateTime.Today.Month)
                return true;
            return false;
        }

        public int GetAge(DateTime date)
        {
            int age = DateTime.Today.Year - date.Year;
            return age;
        }
    }


}
