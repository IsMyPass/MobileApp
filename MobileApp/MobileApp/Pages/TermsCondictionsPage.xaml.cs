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

        public async void OnIgreeClicked(object sender, EventArgs e)
        {
            RegistrationPage registrationPage = new RegistrationPage();
            await Navigation.PushAsync(registrationPage);
        }

        public async void OnLinkTermosClicked(object sender, EventArgs e)
        {
            TermsDescriptionPage termsPage = new TermsDescriptionPage();
            await Navigation.PushAsync(termsPage);
        }
    }
}
