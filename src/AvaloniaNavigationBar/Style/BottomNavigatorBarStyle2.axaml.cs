using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;

namespace AvaloniaNavigationBar.Style;

public class BottomNavigatorBarStyle2 : ListBox
{
    public BottomNavigatorBarStyle2()
    {
        this.SelectionChanged += (sender, args) =>
        {
            int idx = SelectedIndex;
            Canvas.SetLeft(_circle, idx * 80);
        };
    }

    private Ellipse _circle;
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        _circle = e.NameScope.Get<Ellipse>("PART_Circle");
        this.SelectedIndex = 0;
    }
}