using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApp.Pages
{
    public partial class TermsCondictionsPage : ContentPage
    {
        public TermsCondictionsPage()
        {
            InitializeComponent();
        }

        public void OnIgreeClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new RegistrationPage();
        }

        public async void OnLinkTermosClicked(object sender, EventArgs e)
        {
            TermsDescriptionPage terms = new TermsDescriptionPage();
            await Navigation.PushAsync(terms);
        }
    }
}
