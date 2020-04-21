using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class PriceLabel : UILabel
    {
        public PriceLabel(string text) : base(text)
        {
            HorizontalTextAlignment = TextAlignment.End;
        }
    }
}
