using Xamarin.Forms;

namespace cameraTest
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new cameraTestPage()
			{
				Content = new Label
				{
					Text = "Hello, Forms !",
					VerticalOptions = LayoutOptions.CenterAndExpand,
					HorizontalOptions = LayoutOptions.CenterAndExpand,
				},
			};

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
