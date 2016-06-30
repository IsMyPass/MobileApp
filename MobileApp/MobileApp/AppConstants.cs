using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileApp
{
    public static class AppConstants
    {
        public static readonly Font Title = Font.SystemFontOfSize(42);
        public static readonly Font Header = Font.SystemFontOfSize(Device.OnPlatform(16, 16, 26));
        public static readonly Font Subheader = Font.SystemFontOfSize(Device.OnPlatform(12, 14, 24));
        public static readonly Font Standard = Font.SystemFontOfSize(Device.OnPlatform(12, 12, 22));
        public static readonly Font Small = Font.SystemFontOfSize(Device.OnPlatform(10, 10, 16));
        public static readonly Font Button = Font.SystemFontOfSize(Device.OnPlatform(11, 11, 18));


        public static readonly Color CorPrincipal = Color.FromHex("#ff5722");
    }
}
