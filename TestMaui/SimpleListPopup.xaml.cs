using CommunityToolkit.Maui.Views;

namespace TestMaui;

public partial class SimpleListPopup : Popup
{
	public SimpleListPopup(List<Fruit> fruits)
	{
		InitializeComponent();

		FruitsCollection.ItemsSource = fruits;
	}
}