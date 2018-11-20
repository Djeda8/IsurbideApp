using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Isurbide1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PendientesPage : ContentPage
	{
        private const string Url = "http://172.20.18.152/IsurbideWebAPI/api/GEN_ot/";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<GEN_OTModel> _post;

		public PendientesPage ()
		{
            //var listView = new ListView
            //{
            //    RowHeight = 200
            //};
            //listView.ItemsSource = new ParteTemp[] {
            //    new ParteTemp { Numero= 1, Serie = "COM", Tipo = "COMIDA",Cliente="Joaquin Moreno Casado",Direccion="C/Virgen del Olivar, 10", Fecha="12-09-2018", Estado="Pendiente", Hora="11:00" },
            //    new ParteTemp { Numero= 2, Serie = "FON", Tipo = "FONTANERIA",Cliente="Jose Ig. Olmo Ramírez",Direccion="C/Estacion, 20", Fecha="12-09-2018", Estado="Pendiente", Hora="13:00" }
            //};
            
            //listView.ItemsSource = 
            //listView.ItemTemplate = new DataTemplate(typeof(ParteTempCell));
            //Content = new StackLayout
            //{
            //    VerticalOptions = LayoutOptions.FillAndExpand,
            //   Children = { listView }
            //};
            //InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var listView = new ListView
            {
                RowHeight = 200
            };
            string content = await client.GetStringAsync(Url);
            List<GEN_OTModel> posts = JsonConvert.DeserializeObject<List<GEN_OTModel>>(content);
            _post = new ObservableCollection<GEN_OTModel>(posts);
            listView.ItemsSource = _post;
            listView.ItemTemplate = new DataTemplate(typeof(ParteTempCell));
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }
    }
}