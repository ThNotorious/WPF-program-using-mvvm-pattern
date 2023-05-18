using Homework_18_Patterns.ViewModels;
using System.Windows;

namespace Homework_18_Patterns.Views.Windows.AddData
{
    public partial class AddNewSpeciesWindow : Window
    {
        public AddNewSpeciesWindow()
        {
            InitializeComponent();
            DataContext = new MainMethods();
        }
    }
}
