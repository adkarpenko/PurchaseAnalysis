using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class UILabel1 : Label
    {
        public UILabel1(string text)
        {
            Text = text;
            FontSize = 18;
            FontAttributes = FontAttributes.Bold;
            TextColor = Color.Green;
            HorizontalOptions = LayoutOptions.FillAndExpand;
            VerticalOptions = LayoutOptions.CenterAndExpand;
            HorizontalOptions = LayoutOptions.CenterAndExpand;
        }
    }
}
