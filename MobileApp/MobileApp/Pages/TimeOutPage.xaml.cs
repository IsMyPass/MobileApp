using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MobileApp.Pages
{
    public partial class TimeOutPage : ContentPage
    {
        public TimeOutPage()
        {
            InitializeComponent();
        }

        public void OnButtonTentarClicked(object sender, EventArgs e)
        {
            Base.Inicializar();
        }
    }
}
