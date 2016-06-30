using ModernHttpClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MobileApp.WebService;
using MobileApp.Models;
using MobileApp.Pages;
using MobileApp.Helpers;
using Xamarin.Forms;

namespace MobileApp
{
    public class Base
    {
        public static UserInfo _UserInfo;

        public static async void Inicializar()
        {
            App.Current.MainPage = new SplashPage();
            
            FileHelper fileHelper = new FileHelper();

            bool exists = await fileHelper.ExistsAsync("UserInfo");

            if (exists)
            {
                string strUserInfo = await fileHelper.ReadTextAsync("UserInfo");

                if (strUserInfo != string.Empty)
                {
                    if (_UserInfo == null)
                    {
                        _UserInfo = new UserInfo();
                    }

                    _UserInfo = JsonConvert.DeserializeObject<UserInfo>(strUserInfo);


                    App.Current.MainPage = new NavigationPage(new PrincipalPage());
                }
            }
            else
            {
                var newPage = new NavigationPage(new TermsCondictionsPage());
                newPage.BarBackgroundColor = AppConstants.CorPrincipal;

                App.Current.MainPage = newPage;
            }
        }

        /*
        /// <summary>
        /// Consulta Web Service para verificar se o número está cadastrado, serve para testar conexão
        /// </summary>
        public static async void Inicializar()
        {
            //Página de Inicialização do Aplicativo até efetuar a consulta do WebService
            App.Current.MainPage = new SplashPage();
            
            bool numberRegistred = false;

            try
            {
                numberRegistred = await Base.IsPhoneNumberRegistred();

                if (numberRegistred)
                {
                    App.Current.MainPage = new PrincipalPage();
                }
                else
                {
                    App.Current.MainPage = new TermsCondictionsPage();
                }
            }
            catch (Exception)
            {
                App.Current.MainPage = new TimeOutPage();
            }
        }

    */

        public static async Task<bool> IsPhoneNumberRegistred()
        {
            try
            {
                HttpWebService _httpWebService = new HttpWebService();
                var response = await _httpWebService.GetAsync("");

                Usuario user = new Usuario();
                user = await _httpWebService.ReadContentAsync<Usuario>(response);

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
