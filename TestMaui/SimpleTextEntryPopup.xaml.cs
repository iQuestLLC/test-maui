using CommunityToolkit.Maui.Views;

namespace TestMaui;

public partial class SimpleTextEntryPopup : Popup
{
	public SimpleTextEntryPopup(string titleLabel, string entryLabel, string entryValue)
	{
		InitializeComponent();

        if (!string.IsNullOrEmpty(titleLabel))
            TitleLabel.Text = titleLabel;

        if (!string.IsNullOrEmpty(entryLabel))
            EntryLabel.Text = entryLabel;

        if (!string.IsNullOrEmpty(entryValue))
            StringEntry.Text = entryValue;
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var value = string.IsNullOrWhiteSpace(StringEntry.Text)
            ? string.Empty
            : StringEntry.Text.Trim();
        Close(value);
    }
}