using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using MobileApp.Models;

namespace MobileApp.Pages
{
    public partial class MenuPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MenuPage()
        {
            InitializeComponent();

            var menuPageItems = new List<MenuPageItem>();

            menuPageItems.Add(new MenuPageItem
            {
                Title = "Home",
                IconSource = "icon.png",
                TargetType = typeof(HomePage)
            });
            menuPageItems.Add(new MenuPageItem
            {
                Title = "Contato",
                IconSource = "icon.png",
                TargetType = typeof(ContactPage)
            });

            listView.ItemsSource = menuPageItems;
        }
    }
}
