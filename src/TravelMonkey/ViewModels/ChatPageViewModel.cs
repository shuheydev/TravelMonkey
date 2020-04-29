using System;
using System.Collections.Generic;
using System.Text;

namespace TravelMonkey.ViewModels
{
    public class ChatPageViewModel:BaseViewModel 
    {
        private string _bindingTest="This is Binding test.";
        public string BindingTest
        {
            get => _bindingTest;
            set => Set(ref _bindingTest, value);
        }
    }
}
