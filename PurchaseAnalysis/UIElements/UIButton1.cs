using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PurchaseAnalysis.UIElements
{
    class UIButton1:Button
    {
        public UIButton1(string text)
        {
            Text = text;
            BackgroundColor = Color.Green;
            TextColor = Color.White;
            VerticalOptions = LayoutOptions.CenterAndExpand;
            HorizontalOptions = LayoutOptions.CenterAndExpand;
        }
    }
}
