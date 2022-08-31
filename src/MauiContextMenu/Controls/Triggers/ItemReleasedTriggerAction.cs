using CommunityToolkit.Maui.Extensions;

namespace MauiContextMenu.Controls.Triggers;

public class ItemReleasedTriggerAction : TriggerAction<Grid>
{    
    public static readonly BindableProperty OriginalTextColorProperty =
    BindableProperty.CreateAttached("OriginalTextColor", typeof(Color), typeof(ItemReleasedTriggerAction),Colors.Cyan,BindingMode.TwoWay);

    public static Color GetOriginalTextColor(BindableObject view)
    {
        return (Color)view.GetValue(OriginalTextColorProperty);
    }

    public static void SetOriginalTextColor(BindableObject view, Color value)
    {
        view.SetValue(OriginalTextColorProperty, value);
    }

    public uint Rate { get; set; }
    public uint Duration { get; set; }    

    protected override async void Invoke(Grid sender)
    {
        var labelItemName = sender.FindByName<Label>("labelItemName");

        var originalBackgroundColor = (Color)Application.Current.Resources.MergedDictionaries.First()["MenuItemBackground"];

        
        Color OriginalTextColor = (Color)sender.GetValue(OriginalTextColorProperty);

        await Task.WhenAny
        (            
            labelItemName.TextColorTo(OriginalTextColor, Rate, Duration),
            sender.BackgroundColorTo(originalBackgroundColor, Rate, Duration)
        );
    }
}
