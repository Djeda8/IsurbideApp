using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Isurbide1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        void OnJornadaButtonClicked(object sender, EventArgs e)
        {

        }

        async void OnPendientesButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PendientesPage());
        }

        void OnFinalizadasButtonClicked(object sender, EventArgs e)
        {

        }

        void OnAgendaClicked(object sender, EventArgs e)
        {

        }

    }
}
