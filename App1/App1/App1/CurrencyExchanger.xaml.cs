﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CreditCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CurrencyExchanger : ContentPage
    {
        public CurrencyExchanger()
        {
            InitializeComponent();
        }

        private void USDChanged (object sender, TextChangedEventArgs e)
        {
          
        }
    }
}