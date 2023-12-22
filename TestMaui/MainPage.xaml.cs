using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Platform;

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
            var fruits = new List<Fruit>();
            var fruit = new Fruit
            {
                Id = 1,
                Name = "Bananas"
            };
            fruits.Add(fruit);
            fruit = new Fruit
            {
                Id = 2,
                Name = "Strawberries"
            };
            fruits.Add(fruit);
            fruit = new Fruit
            {
                Id = 3,
                Name = "Apples"
            };
            fruits.Add(fruit);
            fruit = new Fruit
            {
                Id = 4,
                Name = "Oranges"
            };
            fruits.Add(fruit);

            var popup = new SimpleListPopup(fruits);
            await Application.Current.MainPage.ShowPopupAsync(popup);

            // Ignore Code below. It's there to demonstrate an issue in SimpleTextEntryPopup
            //#if IOS
            //    KeyboardAutoManagerScroll.Disconnect();
            //#endif
            //            var popup = new SimpleTextEntryPopup("Test Popup", "Some Data Point", "The quick brown fox jumps over the lazy dog");
            //            var response = await Application.Current.MainPage.ShowPopupAsync(popup);
            //#if IOS
            //    KeyboardAutoManagerScroll.Connect();
            //#endif
        }
    }

}