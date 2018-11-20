using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Isurbide1
{
    class ParteTempCell :ViewCell
    {
        public ParteTempCell() {

            var idLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            idLabel.SetBinding(Label.TextProperty, "ID");

            var numeroLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            numeroLabel.SetBinding(Label.TextProperty, "NUMERO");

            var serieLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            serieLabel.SetBinding(Label.TextProperty, "SERIE");

            var tipoLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            tipoLabel.SetBinding(Label.TextProperty, "TIPOPARTE");

            var clienteLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            clienteLabel.SetBinding(Label.TextProperty, "CLIENTENOMBRE");

            var direccionLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            direccionLabel.SetBinding(Label.TextProperty, "CLIENTEDIRECCION");

            var fechaLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            fechaLabel.SetBinding(Label.TextProperty, "FECHAINTERVENCION");

            var horaLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            horaLabel.SetBinding(Label.TextProperty, "FECHAINTERVENCION");

            var estadoLabel = new Label
            {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            estadoLabel.SetBinding(Label.TextProperty, "GEN_ESTADOModel.DESCRIPCION");

            var viewLayout = new StackLayout() {
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Vertical,
                Children = { numeroLabel, serieLabel, tipoLabel,clienteLabel,direccionLabel,fechaLabel,horaLabel,estadoLabel }
                };
            View = viewLayout;
        }
    }
}
