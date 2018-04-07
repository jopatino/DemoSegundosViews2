using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoSegundosViews
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        //private void pickMusic_Changed(object sender, EventArgs e)
        //{
        //    var elementoSeleccionado = pickMusic.SelectedItem.ToString();
        //    DisplayAlert("Música", elementoSeleccionado, "Aceptar");

        //}

        //private void btnSimular_Clicked(object sender, EventArgs e)
        //{
        //    var progreso = progProceso.Progress;
        //    if(progreso == 1)
        //    {
        //        progProceso.ProgressTo(.1, 250, Easing.Linear);
        //    }
        //    else
        //    {
        //        progProceso.ProgressTo(1, 250, Easing.Linear);
        //    }

        //}

        //private void sbNombre_Pressed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Search Bar", "Estoy buscando...", "Aceptar");
        //}
        //private void sbNombre_Changed(object sender, EventArgs e)
        //{
        //    DisplayAlert("Search Bar", "Estoy escribiendo...", "Aceptar");
        //}

        //private void sldEdad_Changed(object sender, EventArgs e)
        //{
        //    lbEdad.Text = sldEdad.Value.ToString();
        //}

        //private void stpCantidad_Changed(object sender, EventArgs e)
        //{
        //    lbCantidad.Text = stpCantidad.Value.ToString();
        //}

        //private void swiDec_Toggle(object sender, EventArgs e)
        //{
        //    if (swiDec.IsToggled)
        //    {
        //        DisplayAlert("Mensaje", "Está Activado", "Aceptar");
        //    }
        //    else
        //    {
        //        DisplayAlert("Mensaje", "Está Desactivado", "Aceptar");
        //    }
        //}


        private async void wvActualidadP_Navigated(object sender, EventArgs e)
        {
            
           await DisplayAlert("WebView", "Ha finalizado la carga de la página", "Aceptar");

        }
    }
}
