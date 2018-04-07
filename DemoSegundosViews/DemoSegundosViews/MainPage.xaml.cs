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
        private void pickMusic_Changed(object sender, EventArgs e)
        {
            var elementoSeleccionado = pickMusic.SelectedItem.ToString();
            DisplayAlert("Música", elementoSeleccionado, "Aceptar");

        }

        private void btnSimular_Clicked(object sender, EventArgs e)
        {
            var progreso = progProceso.Progress;
            if(progreso == 1)
            {
                progProceso.ProgressTo(.1, 250, Easing.Linear);
            }
            else
            {
                progProceso.ProgressTo(1, 250, Easing.Linear);
            }
            
        }

    }
}
