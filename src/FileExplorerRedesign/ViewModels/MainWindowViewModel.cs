using System.Windows;
using Toolkit.Mvvm.ComponentModel;
using Toolkit.Mvvm.Input;

namespace FileExplorerRedesign.ViewModels;

public class MainWindowViewModel : ObservableObject
{
    private IRelayCommand _closeCommand;
    private IRelayCommand _maximizeCommand;
    private IRelayCommand _minimizeCommand;
    private WindowState _windowState;

    public MainWindowViewModel()
    {
    }

    public IRelayCommand CloseCommand => _closeCommand ??= new RelayCommand(Close);

    public IRelayCommand MaximizeCommand => _maximizeCommand ??= new RelayCommand(Maximize);

    public IRelayCommand MinimizeCommand => _minimizeCommand ??= new RelayCommand(Minimize);

    public WindowState WindowState
    {
        get => _windowState;
        set => SetProperty(ref _windowState, value);
    }

    private void Close()
    {
        Application.Current.MainWindow.Close();
    }

    private void Maximize()
    {
        if (WindowState == WindowState.Maximized)
        {
            WindowState = WindowState.Normal;
        }
        else
        {
            WindowState = WindowState.Maximized;
        }
    }

    private void Minimize()
    {
        WindowState = WindowState.Minimized;
    }
}