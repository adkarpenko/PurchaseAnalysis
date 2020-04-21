using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class IdLabel : UILabel
    {
        public IdLabel(string text) : base(text)
        {
            HorizontalTextAlignment = TextAlignment.Start;
        }
    }
}
