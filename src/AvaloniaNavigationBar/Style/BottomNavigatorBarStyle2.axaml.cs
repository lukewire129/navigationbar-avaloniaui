using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Shapes;
using AvaloniaNavigationBar.Interface;

namespace AvaloniaNavigationBar.Style;

public class BottomNavigatorBarStyle2 : ListBox,INavigationAdapter
{
    public BottomNavigatorBarStyle2()
    {
        this.SelectionChanged += (sender, args) =>
        {
            int idx = SelectedIndex;
            Canvas.SetLeft(_circle, idx * 80);
            this.ChangedSelectedIndex?.Invoke(idx);
        };
    }

    private Ellipse _circle;
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        _circle = e.NameScope.Get<Ellipse>("PART_Circle");
        this.SelectedIndex = 0;
    }

    public Action<int> ChangedSelectedIndex { get; set; }
}