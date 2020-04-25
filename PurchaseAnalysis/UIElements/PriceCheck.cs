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


            
            //Content = new StackLayout
            //{
            //    Orientation = StackOrientation.Horizontal,
            //    Children =
            //    {
            //        labelPrice,labelPrice1,labelPrice2,labelPrice3,labelPrice4,labelPrice5

            //    }
            //};

            BorderColor = Color.Green;
        }
        //public string Price { get; }
        //public string FiscalNumber { get; }
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

