using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FileExplorerRedesign.Controls;

public class DriveAndFolderButton : RadioButton
{
    public static readonly DependencyProperty IconProperty =
        DependencyProperty.Register(
            nameof(Icon),
            typeof(PathGeometry),
            typeof(DriveAndFolderButton)
        );

    public PathGeometry Icon
    {
        get { return (PathGeometry)GetValue(IconProperty); }
        set { SetValue(IconProperty, value); }
    }
}