using System;
using System.Collections.Generic;
using System.Text;
using TravelMonkey.Models;
using Xamarin.Forms;

namespace TravelMonkey.TemplateSelector
{
    public class MessageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MyMessageTemplate { get; set; }
        public DataTemplate OthersMessageTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Message)item).SenderType == SenderType.Me ? MyMessageTemplate : OthersMessageTemplate;
        }
    }
}
