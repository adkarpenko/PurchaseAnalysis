using System;
using PurchaseAnalysis.UIElements;
using Xamarin.Forms;
using System.Collections.Generic;
namespace PurchaseAnalysis
{
    public class MainPage : UIContentPage
    {

        UIButton button = new UIButton("Click to scan code");
        Label text = new Label();
        List<PriceNode> list = new List<PriceNode>();
        //public static decimal sum = 0;
        UIButton1 button1 = new UIButton1("Click to show total sum");
        UILabel1 text1 = new UILabel1("Total: ");

        public MainPage()
        {
            button.Clicked += Scan;
            button1.Clicked += Total;
            Update();
        }

        void Update()
        {
            StackLayout sl = new StackLayout();
            sl.Children.Add(button);

            foreach (var n in list)
                sl.Children.Add(n);

            sl.Children.Add(button1);
            sl.Children.Add(text1);

            ScrollView scrollView = new ScrollView();
            scrollView.Content = sl;
            this.Content = scrollView;
            Content = scrollView;
        }

        double sum = 0;
        void Total(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in list)
                {
                    string str = item.Price.Replace('.', ',');
                    sum += double.Parse(str);
                    
                }

                text1.Text =sum.ToString() ;
                Update();
            }
            catch (Exception ex) { text1.Text = ex.Message; }
        }
        async void Scan(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                text.Text = result;
                int id = list.Count + 1;
                string price = result.Split('=')[2].Split('&')[0];
                list.Add(new PriceNode(id, price));

                Update();
            }
            catch { }
        }
    }
}
