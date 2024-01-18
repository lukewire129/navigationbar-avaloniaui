using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Media;

namespace AvaloniaNavigationBar;

public class MagicBar : ListBox
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
        };
    }

    private Grid _circle;
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);

        _circle = e.NameScope.Get<Grid>("PART_Circle");
        this.SelectedIndex = 0;
    }
}