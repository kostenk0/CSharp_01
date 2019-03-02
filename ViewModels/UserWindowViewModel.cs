using BCSharp_02.Tools;
using CSharp_02.Models;
using CSharp_02.Tools;
using CSharp_02.Tools.Menegers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace CSharp_02.ViewModels
{
    class UserWindowViewModel : BaseViewModel
    {
        private Person person;
        private RelayCommand<object> okCommand;
        private bool canStart = true;
        public Person People
        {
            get
            {
                return person;
            }
            set
            {
                person = value;
                OnPropertyChanged();
            }
        }

        public bool CanStart
        {
            get
            {
                return canStart;
            }
            set
            {
                canStart = value;
                OnPropertyChanged();
            }
        }

        public UserWindowViewModel()
        {
            person = new Person();
        }

        public RelayCommand<object> StartCommand
        {
            get
            {
                return okCommand ?? (okCommand = new RelayCommand<object>(
                          StartIplementation));
            }
        }

        private async void StartIplementation(object obj)
        {
            LoaderManeger.Instance.ShowLoader();
            People = new Person(person.DateOfBirth);
            if (People.Age > 135 && People.Age < 0)
                MessageBox.Show("Некоректні дані.Ваш вік повинен бути меншим 135");
            if (People.IsBirthday && People.Age <= 135 && People.Age >= 0)
                MessageBox.Show("З Днем Народження)))");
            
            await Task.Run(() => Thread.Sleep(2000));
            LoaderManeger.Instance.HideLoader();
        }
        
    }
}
