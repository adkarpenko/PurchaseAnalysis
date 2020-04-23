using System;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class PriceCheck : Frame
    {
        public PriceCheck(string price, string fiscalNumber, string fiscalDocument, string fiscalSign, string n, string date)
        {
            PriceLabel1 labelPrice = new PriceLabel1(price);
            PriceLabel1 labelPrice1 = new PriceLabel1(fiscalNumber);
            PriceLabel1 labelPrice2 = new PriceLabel1(fiscalDocument);
            PriceLabel1 labelPrice3 = new PriceLabel1(fiscalSign);
            PriceLabel1 labelPrice4 = new PriceLabel1(n);
            PriceLabel1 labelPrice5 = new PriceLabel1(date);
            Content = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    labelPrice,labelPrice1,labelPrice2,labelPrice3,labelPrice4,labelPrice5

                }
            };

            BorderColor = Color.Green;
            Price = price;
            FiscalNumber = fiscalNumber;
            FiscalDocument = fiscalDocument;
            FiscalSign = fiscalSign;
            N = n;
            Date = date;
        }
        public string Price { get; }
        public string FiscalNumber { get; }
        public string FiscalDocument { get; }
        public string FiscalSign { get; }
        public string N { get; }
        public string Date { get; }
    }
}
