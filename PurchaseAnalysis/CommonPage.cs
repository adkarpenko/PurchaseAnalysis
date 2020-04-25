using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PurchaseAnalysis.UIElements;
using Xamarin.Forms;

namespace PurchaseAnalysis
{
    public class CommonPage : UIContentPage
    {
        
        public CommonPage(List<PriceCheck> list1)
        {
            StackLayout sp = new StackLayout();

            foreach (var n in list1)
            {
                sp.Children.Add(new IdLabel(n.Price));
                sp.Children.Add(new IdLabel(n.Date));
                sp.Children.Add(new IdLabel(n.FiscalNumber));
                sp.Children.Add(new IdLabel(n.FiscalDocument));
                sp.Children.Add(new IdLabel(n.FiscalSign));
                sp.Children.Add(new IdLabel(n.N));
            }
            Content = sp;

        }


    }
}