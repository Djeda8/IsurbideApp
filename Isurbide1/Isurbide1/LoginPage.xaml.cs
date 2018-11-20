using Isurbide1.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Isurbide1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}
        
        void OnSalir(object sender, EventArgs e)
        {
            
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrectAsync(user);
            if (await isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        public async Task<bool> AreCredentialsCorrectAsync(User user)
        {
            
            GEN_USUARIOSModel userBBDD = await DameUserAsync(user.Username);

            //return user.Username == Constants.Username && user.Password == Constants.Password;
            return user.Username == userBBDD.LOGIN && user.Password == userBBDD.PWD;
        }

        public async Task<GEN_USUARIOSModel> DameUserAsync(string Username)
        {
            
            string baseAddress = "http://172.20.18.152/IsurbideWebAPI/api/GEN_USUARIOS?login="+Username;

            using (var httpClient = new HttpClient())
            {
                string json = await httpClient.GetStringAsync(baseAddress);
                GEN_USUARIOSModel instance = JsonConvert.DeserializeObject<GEN_USUARIOSModel>(json);
                return instance;
            }
            
            
        }


    }
}