using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using TravelMonkey.Data;
using TravelMonkey.Models;
using TravelMonkey.Services;
using Xamarin.Forms;

namespace TravelMonkey.ViewModels
{
    public class ChatPageViewModel : BaseViewModel
    {
        private readonly TranslationService _translationService = new TranslationService();

        private string _bindingTest = "This is Binding test.";
        public string BindingTest
        {
            get => _bindingTest;
            set => Set(ref _bindingTest, value);
        }

        private ObservableCollection<Message> _messages;
        public ObservableCollection<Message> Messages
        {
            get => _messages;
            set => Set(ref _messages, value);
        }

        private string _inputMessage;
        public string InputMessage
        {
            get => _inputMessage;
            set => Set(ref _inputMessage, value);
        }

        private List<Language> _sourceLanguages;
        public List<Language> SourceLanguages
        {
            get => _sourceLanguages;
            set => Set(ref _sourceLanguages, value);
        }
        private Language _selectedSourceLanguage;
        public Language SelectedSourceLanguage
        {
            get => _selectedSourceLanguage;
            set => Set(ref _selectedSourceLanguage, value);
        }

        private List<Language> _targetLanguages;
        public List<Language> TargetLanguages
        {
            get => _targetLanguages;
            set => Set(ref _targetLanguages, value);
        }
        private Language _selectedTargetLanguage;
        public Language SelectedTargetLanguage
        {
            get => _selectedTargetLanguage;
            set => Set(ref _selectedTargetLanguage, value);
        }

        public Command SendMessageCommand { get; }

        public ChatPageViewModel()
        {
            this.Messages = MockDataStore.Messages;

            this.SourceLanguages = LanguageProvider.GetLanguages();
            this.SelectedSourceLanguage = this.SourceLanguages.FirstOrDefault(lang => lang.Code == "ja");

            this.TargetLanguages = LanguageProvider.GetLanguages();
            this.SelectedTargetLanguage = this.TargetLanguages.FirstOrDefault(lang => lang.Code == "en");

            SendMessageCommand = new Command(async () =>
            {
                if (string.IsNullOrWhiteSpace(this.InputMessage))
                {
                    return;
                }

                this.Messages.Add(new Message
                {
                    SourceLangText = this.InputMessage,
                    TargetLangText = await _translationService.TranslateTo(this.InputMessage, this.SelectedTargetLanguage.Code),
                    SendDateTime = DateTimeOffset.Now,
                    SenderType = SenderType.Me,
                });

                this.InputMessage = "";
            });
        }
    }
}
