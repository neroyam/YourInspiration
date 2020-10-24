using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Todo
{
	public class LoadingPage : ContentPage
	{
		private readonly Image _splashImage;

		public LoadingPage()
		{
			NavigationPage.SetHasNavigationBar(this, false);

			var sub = new AbsoluteLayout();
			_splashImage = new Image
			{
				Source = "background.jpg",
			};

			AbsoluteLayout.SetLayoutFlags(_splashImage, AbsoluteLayoutFlags.PositionProportional);
			AbsoluteLayout.SetLayoutBounds(_splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

			sub.Children.Add(_splashImage);
			Content = sub;
		}

		protected override async void OnAppearing()
		{
			await _splashImage.ScaleTo(1, 2200);

			base.OnAppearing();

			Application.Current.MainPage = new AppShell();
		}
	}
}
