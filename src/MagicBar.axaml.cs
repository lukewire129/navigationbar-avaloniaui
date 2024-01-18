using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;

namespace AvaloniaNavigationBar;

public class MagicBar : ListBox
{ 
    private static readonly FuncTemplate<Panel?> DefaultPanel =
        new(() => new UniformGrid()
        {
            Columns = 5
        });
    static MagicBar()
    {
        ItemsPanelProperty.OverrideDefaultValue<MagicBar>(DefaultPanel);
    }
    public MagicBar()
    {
    }
}