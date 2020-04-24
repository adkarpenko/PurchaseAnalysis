using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PurchaseAnalysis.UIElements;
using Xamarin.Forms;

namespace PurchaseAnalysis
{
    public class CommonPage : MainPage
    {

        public CommonPage(PriceCheck check)
        {
            UILabel la = new UILabel("");
            try
            {

            Content = new StackLayout { Children = { check } };
            }
            catch (Exception)
            {
                la.Text = "uhygtyd";
               
            }

        }


    }
}