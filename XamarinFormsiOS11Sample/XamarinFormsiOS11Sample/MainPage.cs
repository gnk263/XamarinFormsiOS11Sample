using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamarinFormsiOS11Sample
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "テスト画面";


            // iOS用のSetUseSafeArea設定
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);


            // ListView用のデータを作成
            var listData = Enumerable.Range(1, 100)
                                .Select(i => $"item {i}")
                                .ToList();
            
            // ListViewを作成
            var listView = new ListView
            {
                ItemsSource = listData,
                BackgroundColor = Color.LightSkyBlue
            };

            Content = new StackLayout
            {
                Children =
                {
                    listView
                }
            };
        }
    }
}