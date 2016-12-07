using System;
using Xamarin.Forms;

namespace cameraTest
{
	public partial class App : Application
	{
		// Appクラスとプラットフォーム固有のコードとのやりとりを容易にするために静的instanceに格納
		public static App Instance;
		// 画像表示用のメンバ
		readonly Image image = new Image();

		public App()
		{
			Instance = this;

			// カメラを起動するためのボタン宣言部
			var button = new Button
			{
				Text = "Snap!",
				Command = new Command(o => ShouldTakePicture()),
			};

			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					// ボタンと撮影後の画像を真ん中に配置
					VerticalOptions = LayoutOptions.Center,
					Children = {
						button,
						image,
					},
				},
			};

		}

		// カメラ起動部分はOSごとに書いてね
		public event Action ShouldTakePicture = () => { };

		// 画像pathをもらい表示する
		public void ShowImage(string filepath)
		{
			image.Source = ImageSource.FromFile(filepath);
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
