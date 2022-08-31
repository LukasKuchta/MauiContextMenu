using CommunityToolkit.Maui.Extensions;

namespace MauiContextMenu.Controls.Triggers;

public class ItemTappedTriggerAction : TriggerAction<Grid>
{
    public uint Rate { get; set; }
    public uint Duration { get; set; }

    protected override async void Invoke(Grid sender)
    {
        var labelItemName = sender.FindByName<Label>("labelItemName");

        var invertedMenuItemText = (Color)Application.Current.Resources.MergedDictionaries.First()["InvertedMenuItemText"];


        var tappedColor = (Color)Application.Current.Resources.MergedDictionaries.First()["TappedColor"];

        await Task.WhenAny
        (
            labelItemName.TextColorTo(invertedMenuItemText, Rate, Duration),
            sender.BackgroundColorTo(tappedColor, Rate, Duration)
        );
    }
}
