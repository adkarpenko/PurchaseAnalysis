using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class PriceLabel1 : UILabel
    {
        public PriceLabel1(string text) : base(text)
        {
            HorizontalTextAlignment = TextAlignment.End;
        }
    }
}
