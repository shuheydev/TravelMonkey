using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TravelMonkey.Models;
using TravelMonkey.Services;

namespace TravelMonkey.Data
{
    public static class SampleData
    {
        public static async Task<ObservableCollection<Message>> InitSampleMessages()
        {
            TranslationService _translationService = new TranslationService();

            var sampleMessages = new ObservableCollection<Message>
            {
                new Message
                {
                    SourceLangText="これはMock Message1",
                    TargetLangText=await _translationService.TranslateJaToEn("これはMock Message1"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText="This is Mock Message2",
                    TargetLangText=await _translationService.TranslateEnToJa("This is Mock Message2"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(2),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText="これはMock Message3:長いメッセージだ,いえーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーい",
                    TargetLangText=await _translationService.TranslateJaToEn("これはMock Message3:長いメッセージだ,いえーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーーい"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(3),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText="This is Mock Message4",
                    TargetLangText=await _translationService.TranslateEnToJa("This is Mock Message4"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(4),
                    SenderType=SenderType.Others,
                }
            };

            return sampleMessages;
        }
    }
}
