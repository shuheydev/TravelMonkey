using System;
using System.ComponentModel;
using System.Threading.Tasks;
using TravelMonkey.ViewModels;
using Xamarin.Forms;

namespace TravelMonkey.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = _mainPageViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _mainPageViewModel.StartSlideShow();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            _mainPageViewModel.StopSlideShow();
        }

        private async void AddNewPicture_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddPicturePage());
        }

        private async void Entry_Completed(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TranslateTextEntry.Text))
            {
                await DisplayAlert("No text entered", "You didn't enter any text!", "OK");
                return;
            }

            await Navigation.PushModalAsync(new TranslationResultPage(TranslateTextEntry.Text));
            TranslateTextEntry.Text = "";
        }

        private async void Button_Navigate_to_ChatPage_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ChatPage());
        }
    }
}