using System;
using Avalonia.Controls;
using AvaloniaNavigationBar.Interface;

namespace AvaloniaNavigationBar.Style;

public class Navibar : ListBox, INavigationAdapter
{
    public Action<int> ChangedSelectedIndex { get; set; }
}