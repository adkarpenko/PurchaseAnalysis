using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class PriceNode : Frame
    {
        public PriceNode(int id, string price)
        {
            IdLabel labelID = new IdLabel(id.ToString());
            PriceLabel labelPrice = new PriceLabel(price);
            Content = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    labelID,
                    labelPrice
                }
            };
            BorderColor = Color.Green;
            Price = price;
        }
        public string Price { get; }
    }
}
