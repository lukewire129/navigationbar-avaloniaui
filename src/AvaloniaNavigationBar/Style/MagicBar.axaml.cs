using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using AvaloniaNavigationBar.Interface;

namespace AvaloniaNavigationBar.Style;

public class MagicBar : ListBox, INavigationAdapter
{ 
    static MagicBar()
    {
    }
    public MagicBar()
    {
        this.SelectionChanged += (sender, args) =>
        {
            int idx = SelectedIndex;
            Canvas.SetLeft(_circle, idx * 80);
            this.ChangedSelectedIndex?.Invoke(idx);
        };
    }

    private Grid _circle;
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        _circle = e.NameScope.Get<Grid>("PART_Circle");
        this.SelectedIndex = 0;
    }

    public Action<int> ChangedSelectedIndex { get; set; }
}