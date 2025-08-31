using Avalonia.Controls;
using SimpleTodoList.ViewModels;

namespace SimpleTodoList.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel(); // <--- THIS IS REQUIRED
    }
}