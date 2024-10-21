using System;

namespace AvaloniaNavigationBar.Interface;

public interface INavigationAdapter
{
    Action<int> ChangedSelectedIndex { get; set; }
}