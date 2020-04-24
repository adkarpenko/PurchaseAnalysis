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
        UILabel1 text1 = new UILabel1("Total: ");
        public CommonPage(List<PriceCheck> list1)
        {
            StackLayout sp = new StackLayout();
            sp.Children.Add(text1);
            //foreach (var n in list1)
            //    sp.Children.Add(n);

        }


    }
}