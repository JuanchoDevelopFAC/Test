using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Test.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private string entryEmail;
        private string entryPassword;
        private string image="img1.png";
        private string date;

        public ICommand LoginCommand { get; set; }

        public INavigation Navigation { get; set; }

        private string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

        public string EntryEmail
        {          
            get { return entryEmail; }
            set 
            { 
                entryEmail = value;

                if (Regex.Match(entryEmail, emailPattern).Success) image = "img2.png";
                else image = "img1.png";
                OnPropertyChanged("Image");
            }
        }

        public string EntryPassword
        {
            get { return entryPassword; }
            set { entryPassword = value; OnPropertyChanged(); }
        }

        public string Image
        {
            get { return image; }
            set { image = value; OnPropertyChanged(); }
        }

        public string Date
        {
            get { return date; }
            set { date = value; OnPropertyChanged("Date"); }
        }

        public UserViewModel(INavigation navigation)
        {
            Navigation = navigation;
            LoginCommand = new Command(LoginSystem);
        }

        private async void LoginSystem()
        {
            date = DateTime.Now.ToString("yyyyMMdd");
            if (entryPassword == date) await Navigation.PushAsync(new Test.Views.ListCurrencyView(), true);
            else Console.WriteLine("Constraseña incorrecta");
        }

    }
}
