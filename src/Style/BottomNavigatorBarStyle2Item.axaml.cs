using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Material.Icons;
using Material.Icons.Avalonia;

namespace AvaloniaNavigationBar.Style;

public class BottomNavigatorBarStyle2Item : ListBoxItem
{
    public static readonly StyledProperty<MaterialIconKind> KindProperty = AvaloniaProperty.Register<BottomNavigatorBarStyle2Item, MaterialIconKind>(nameof (Kind), MaterialIconKind.Abacus, false, BindingMode.OneWay, (Func<MaterialIconKind, bool>) null, (Func<AvaloniaObject, MaterialIconKind, MaterialIconKind>) null, false);

    public MaterialIconKind Kind
    {
        get => this.GetValue<MaterialIconKind>(BottomNavigatorBarStyle2Item.KindProperty);
        set
        {
            this.SetValue<MaterialIconKind>(BottomNavigatorBarStyle2Item.KindProperty, value, BindingPriority.LocalValue);
        }
    }
}