using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XConceptOne
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Padding = Device.OnPlatform(
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10));

            convertButton.Clicked += ConvertButton_Clicked;
        }

        private async void ConvertButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bolivarEntry.Text))
            {
                await DisplayAlert("Error", "Debes ingresar un valor en pesos", "Aceptar");
                return;
            }
            decimal bolivares = decimal.Parse(bolivarEntry.Text);
            decimal dollars = bolivares / 1024.93M;
            decimal euros = bolivares / 1153.05M;
            decimal pesos = bolivares * 2.38M;

            dollarsEntry.Text = string.Format("{0:N2}", dollars);
            eurosEntry.Text = string.Format("{0:N2}", euros);
            pesosEntry.Text = string.Format("{0:N2}", pesos);
        }
    }
}
