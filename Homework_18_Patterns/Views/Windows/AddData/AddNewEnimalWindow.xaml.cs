using Homework_18_Patterns.ViewModels;
using System.Windows;

namespace Homework_18_Patterns.Views.Windows.AddData
{
    public partial class AddNewEnimalWindow : Window
    {
        public AddNewEnimalWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
