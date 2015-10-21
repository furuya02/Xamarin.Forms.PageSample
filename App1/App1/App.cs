using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1 {
    
    ////////////////////////////////////////////////////
    //
    // ContentPageのサンプル
    //
    ////////////////////////////////////////////////////
    public class App : Application {
        public App() {
            // MyContentPagePageを継承したクラスを生成してMainPageとする
            MainPage = new MyContentPage();
        }
    }


    class MyContentPage : ContentPage {
        public MyContentPage() {
            //iPhoneにおいて、ステータスバーとの重なりを防ぐためパディングを調整する
            Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);
            //ラベルを１つ生成
            var label1 = new Label {
                FontSize = 40,
                Text = "Developers.IO"
            };
            // 生成したラベルをこのビューの子要素とする
            Content = label1;
        }
    }
    
    /*
    ////////////////////////////////////////////////////
    //
    // CarouselPageのサンプル
    //
    ////////////////////////////////////////////////////
    public class App : Application {
        public App() {
            // CarouselPageをMainPageとしてセットする
            MainPage = new CarouselPage() {
                Children = {
                new MyPage(Color.Green),
                new MyPage(Color.Red),
                new MyPage(Color.Aqua)
            }
            };
        }
    }

    class MyPage : ContentPage {
        public MyPage(Color color) {
            //ページの区切りが分かりやすいように背景色を設定する
            BackgroundColor = color;
            //ラベルを生成
            var label1 = new Label {
                FontSize=40,
                //ビューの中央に配置
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = string.Format("RGB({0:0},{1:0},{2:0})", color.R, color.G, color.B)
            };
            Content = label1;//ラベルのみを配置する
        }
    }
    */

    /*
    ////////////////////////////////////////////////////
    //
    // TabbedPageのサンプル
    //
    ////////////////////////////////////////////////////
    public class App : Application {
        public App() {
            // TabbedPageをMainPageとしてセットする
            MainPage = new TabbedPage() {
                Children = {
                    new MyPage("Tab1"),
                    new MyPage("Tab2"),
                    new MyPage("Tab3")
                }
            };
        }
    }

    class MyPage : ContentPage {
        public MyPage(string title) {
            //タブに表示される文字列
            Title = title;
            //ラベルを生成
            var label1 = new Label {
                FontSize = 40,
                //ビューの中央に配置
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                Text = title
            };
            Content = label1;//ラベルのみを配置する
        }
    }
    */


    /*
    ////////////////////////////////////////////////////
    //
    // NavigationPageのサンプル
    //
    ////////////////////////////////////////////////////
    public class App : Application {
        public App() {
            // NavigationPageを使用して最初のページを表示する
            MainPage = new NavigationPage(new MainPage()) {
                //  タイトルバーの背景色や文字色は、NavigationPageのプロパティをセットする
                BarBackgroundColor = Color.FromRgba(0.2, 0.6, 0.86, 1),
                BarTextColor = Color.White
            };
        }
    }


    //メインのページ
    class MainPage : ContentPage {
        public MainPage() {
            Title = "MainPage"; //ページのタイトル

            //ボタンを生成
            var button1 = new Button { Text = "NextPageへ移動" };
            //ボタンクリック時の処理
            button1.Clicked += async (s, a) => {
                //ページを遷移する
                await Navigation.PushAsync(new NextPage());
            };

            Content = button1;
        }
    }

    //遷移後のページ
    class NextPage : ContentPage {
        public NextPage() {
            Title = "NextPage"; //ページのタイトル
        }
    }
    */


    /*
    ////////////////////////////////////////////////////
    //
    // MasterDetailPageのサンプル
    //
    ////////////////////////////////////////////////////
    public class App : Application {
        public App() {
            // MasterDetailPageを継承したクラスを生成してMainPageとする
            MainPage = new MyMasterDetailPage();
        }
    }

    class MyMasterDetailPage : MasterDetailPage {
        public MyMasterDetailPage() {
            var ar = new[] { "Ietm1", "Item2", "Item3" };

            ListView listView = new ListView {
                ItemsSource = ar,
                BackgroundColor = Color.Transparent

            };

            //  マスターページ
            this.Master = new ContentPage {
                BackgroundColor = Color.FromRgba(0.86,0.91,0.94,0.5),
                //iPhoneにおいて、ステータスバーとの重なりを防ぐためパディングを調整する
                Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0),
                Title = "Master", // 必須
                Icon = "menu.png",
                Content = listView
            };

            listView.ItemSelected += (s, a) => {
                Detail = new NavigationPage(new DetailPage(a.SelectedItem.ToString())) {
                    //  タイトルバーの背景色や文字色は、NavigationPageのプロパティをセットする
                    BarBackgroundColor = Color.FromRgba(0.2, 0.6, 0.86, 1),
                    BarTextColor = Color.White
                };
                IsPresented = false;//  Detailページを表示する
            };

            listView.SelectedItem = ar[0];// 必須　最初のページをセットする

        }
    }

    //詳細ページ
    class DetailPage : ContentPage {
        public DetailPage(string title) {
            Title = title;
            Content = new Label {
                //テキストを中央に表示する
                Text = title,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
    */


}
