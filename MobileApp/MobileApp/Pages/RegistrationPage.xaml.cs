using MobileApp.Helpers;
using MobileApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApp.Pages
{
    public partial class RegistrationPage : ContentPage
    {
        private bool enviouPhone = false;

        public RegistrationPage()
        {
            InitializeComponent();
        }

        public void OnEnviarConfimarClicked(object sender, EventArgs e)
        {
            if(!enviouPhone)
            {
                EnviarNumeroPhone();
            }
            else
            {
                ConfirmarRecebimento();
            }
        }

        private void EnviarNumeroPhone()
        {
            entryPhone.IsEnabled = false;
            entryCodigo.IsEnabled = true;

            btnEnviarConfirmar.Text = "CONFIRMAR";

            entryCodigo.Focus();
            enviouPhone = true;
        }

        private void ConfirmarRecebimento()
        {
            UserInfo objUserInfo = new UserInfo();
            objUserInfo.Phone = entryPhone.Text;

            string strPhoneNumber = JsonConvert.SerializeObject(objUserInfo);

            FileHelper fileHelper = new FileHelper();
            fileHelper.WriteTextAsync("UserInfo", strPhoneNumber);

            var principalPage = new NavigationPage(new PrincipalPage());
            principalPage.BarBackgroundColor = AppConstants.CorPrincipal;

            App.Current.MainPage = principalPage;
        }
    }
}
