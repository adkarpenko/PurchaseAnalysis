using System;
using System.ComponentModel;
using Xamarin.Forms;
namespace PurchaseAnalysis.UIElements
{
    public class PriceCheck : Frame
    {
        public PriceCheck(string price, string fiscalNumber, string fiscalDocument, string fiscalSign, string n, string date)
        {
            Price = price;
            FiscalNumber = fiscalNumber;
            FiscalDocument = fiscalDocument;
            FiscalSign = fiscalSign;
            N = n;
            Date = date;


            PriceLabel1 labelPrice = new PriceLabel1(Price);
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
        }
        //public string price { get; }
        //public string fiscalNumber { get; }
        //public string FiscalDocument { get; }
        //public string FiscalSign { get; }
        //public string N { get; }
        //public string Date { get; }

        private string price;
        private string fiscalNumber;
        private string fiscalDocument;
        private string fiscalSign;
        private string n;
        private string date;



        public string Price
        {
            get { return price; }
            set
            {
                if (price != value)
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        public string FiscalNumber
        {
            get { return fiscalNumber; }
            set
            {
                if (fiscalNumber != value)
                {
                    fiscalNumber = value;
                    OnPropertyChanged("FiscalNumber");
                }
            }
        }
        public string FiscalDocument
        {
            get { return fiscalDocument; }
            set
            {
                if (fiscalDocument != value)
                {
                    fiscalDocument = value;
                    OnPropertyChanged("FiscalDocument");
                }
            }
        }

        public string FiscalSign
        {
            get { return fiscalSign; }
            set
            {
                if (fiscalSign != value)
                {
                    fiscalSign = value;
                    OnPropertyChanged("FiscalSign");
                }
            }
        }

        public string N
        {
            get { return n; }
            set
            {
                if (n != value)
                {
                    n = value;
                    OnPropertyChanged("FiscalDocument");
                }
            }
        }

        public string Date
        {
            get { return date; }
            set
            {
                if (date != value)
                {
                    date = value;
                    OnPropertyChanged("FiscalDocument");
                }
            }
        }


    }
}

