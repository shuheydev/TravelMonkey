using System;
using System.Collections.Generic;
using System.Text;

namespace TravelMonkey.Models
{
    public class Message
    {
        public string SourceLangText { get; set; }
        public string TargetLangText { get; set; }
        public DateTimeOffset SendDateTime { get; set; }
        public SenderType SenderType { get; set; }
    }

    public enum SenderType
    {
        Me,
        Others,
    }
}
