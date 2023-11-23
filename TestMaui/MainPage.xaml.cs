using CommunityToolkit.Maui.Views;

namespace TestMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            var popup = new SimpleTextEntryPopup("Test Popup", "Some Data Point", "The quick brown fox jumps over the lazy dog");
            var response = await Application.Current.MainPage.ShowPopupAsync(popup);
        }
    }

}