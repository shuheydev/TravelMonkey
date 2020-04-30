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

            string[] sampleText = new string[]{
                "今度サンフランシスコに行くよ!",
                "Really? When?",
                "明日.JALで行くよ",
                "Do you need a ride to the airport?",
                "いや,大丈夫.タクシーに乗るよ.サンフランシスコに行ったことある?",
                "Yes. I have been there several times. There are many interesting places that you can visit, such as the Golden Gate Bridge.",
                "Fisherman's Wharfはどうだった?",
                "Oh, that’s one of my favorites! There are lots of seafood restaurants you can sit at for lunch. Where are you going to stay?",
                "Pacific Tradewinds Hostelを予約したよ.",
                "How long are you going to be there?",
                "3日間だけ",
                "Why don’t you stay longer?",
                "友達に会いにニューヨークに行く予定なんだ.",
                "Have you booked the flight?",
                "予約してあるよ",
            };

            var sampleMessages = new ObservableCollection<Message>
            {
                new Message
                {
                    SourceLangText=sampleText[0],
                    TargetLangText=await _translationService.TranslateTo(sampleText[0],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[1],
                    TargetLangText=await _translationService.TranslateTo(sampleText[1],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[2],
                    TargetLangText=await _translationService.TranslateTo(sampleText[2],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[3],
                    TargetLangText=await _translationService.TranslateTo(sampleText[3],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[4],
                    TargetLangText=await _translationService.TranslateTo(sampleText[4],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[5],
                    TargetLangText=await _translationService.TranslateTo(sampleText[5],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[6],
                    TargetLangText=await _translationService.TranslateTo(sampleText[6],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[7],
                    TargetLangText=await _translationService.TranslateTo(sampleText[7],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                                new Message
                {
                    SourceLangText=sampleText[8],
                    TargetLangText=await _translationService.TranslateTo(sampleText[8],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[9],
                    TargetLangText=await _translationService.TranslateTo(sampleText[9],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[10],
                    TargetLangText=await _translationService.TranslateTo(sampleText[10],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[11],
                    TargetLangText=await _translationService.TranslateTo(sampleText[11],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[12],
                    TargetLangText=await _translationService.TranslateTo(sampleText[12],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
                new Message
                {
                    SourceLangText=sampleText[13],
                    TargetLangText=await _translationService.TranslateTo(sampleText[13],"ja"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Others,
                },
                new Message
                {
                    SourceLangText=sampleText[14],
                    TargetLangText=await _translationService.TranslateTo(sampleText[14],"en"),
                    SendDateTime=DateTimeOffset.Now.AddMinutes(1),
                    SenderType=SenderType.Me,
                },
            };

            return sampleMessages;
        }
    }
}
