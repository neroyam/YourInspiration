using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TutorialsPage : ContentPage
	{
		public TutorialsPage()
		{
			InitializeComponent();

			new[]
			{
				new
				{
					ImagePath = "human_hand.jpg",
					Description = "Поэтапное рисование кисти человека"
				},
				new
				{
					ImagePath = "human_had.jpg",
					Description = "Варианты положения головы человека"
				},
				new
				{
					ImagePath = "emotion.jpg",
					Description = "Эмоции"
				},
				new
				{
					ImagePath = "human_body_anatomy.jpg",
					Description = "Анатомия человеческого тела"
				},
			}
			.ToList()
			.ForEach(x =>
			{
				mainStackLayout.Children.Add(new Image
				{
					Aspect = Aspect.AspectFit,
					Source = ImageSource.FromFile(x.ImagePath),
				});

				mainStackLayout.Children.Add(new Label
				{
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
					Margin = new Thickness(0, 0, 0, 20),
					FontSize = 16,
					FontFamily = "Lobster-Regular",
					TextColor = Color.Black,
					Text = x.Description,
				});
			});
		}
	}
}