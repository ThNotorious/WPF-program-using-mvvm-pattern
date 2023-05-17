using Homework_18_Patterns.ViewModels;
using System.Windows;

namespace Homework_18_Patterns
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
