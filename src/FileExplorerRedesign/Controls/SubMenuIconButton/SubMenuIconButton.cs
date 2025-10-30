using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FileExplorerRedesign.Controls;

public class SubMenuIconButton : Button
{
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(
            nameof(Icon),
            typeof(PathGeometry),
            typeof(SubMenuIconButton)
        );

    public PathGeometry Icon
    {
        get => (PathGeometry)GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }
}