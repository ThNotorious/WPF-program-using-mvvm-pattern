using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Homework_18_Patterns.ViewModels
{
    internal class MainMethods 
    {
        #region Метод открытия окна

        /// <summary>
        /// Метод открытия окна
        /// </summary>
        internal static void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        #endregion

        /// <summary>
        /// Метод окрашивания ячейки ввода в красный
        /// </summary>
        /// <param name="window"></param>
        /// <param name="blockName"></param>
        internal static void SetRedBlockControl(Window window, string blockName)
        {
            Control? block = window.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }

        /// <summary>
        /// Метод вывода окна оповещения
        /// </summary>
        /// <param name="message"></param>
        internal static void ShowMessageToUser(string message)
        {
           MessageBox.Show(message, "Уведомление", MessageBoxButton.OK, MessageBoxImage.Asterisk);
        }


        internal static void UpdateMainWindowView()
        {
            MainWindow window = new();
            window.InitializeComponent();
        }
    }
}
