﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoNavigationPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            DisplayActionSheet();
		}
        public async void SiguienteButton_Clicked(Object sender, EventArgs args) {
            await Navigation.PushAsync(new Pagina2());
        }

        private void DisplayActionSheet()
        {
            throw new NotImplementedException();
        }
    }
}
