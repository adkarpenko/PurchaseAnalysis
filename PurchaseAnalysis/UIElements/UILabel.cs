using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class UILabel : Label
    {
        public UILabel(string text)
        {
            Text = text;
            FontSize = 18;
            FontAttributes = FontAttributes.Bold;
            TextColor = Color.Green;
            HorizontalOptions = LayoutOptions.FillAndExpand;
        }
    }
}
