using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExsalesMobileApp.pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StartPage : ContentPage
	{
		public StartPage ()
		{
			InitializeComponent ();

            //инициализация элементов формы
            logo_image.Source = @"logo.jpg";

            //данные локализации
            en_login.Placeholder = "Login";
            en_password.Placeholder = "Password";
            bt_sign_in.Text = "Sign In";
            label_register.Text = "Create new account?";
            bt_register.Text = "Register";

        }//c_tor
	}//class
}//namespace