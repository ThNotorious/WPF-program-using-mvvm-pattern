using Homework_18_Patterns.Views.Windows.AddData;

namespace Homework_18_Patterns.ViewModels
{
    internal class OpenAddWindowMethods : MainMethods
    {
        #region Методы открытия окон добавления

        /// <summary>
        /// Окно добавления класса
        /// </summary>
        internal static void OpenAddClassWindowMethod()
        {
            AddNewClassWindow addNewClassWindow = new();
            SetCenterPositionAndOpen(addNewClassWindow);
        }

        /// <summary>
        /// Окно добавления вида
        /// </summary>
        internal static void OpenAddSpeciesWindowMethod()
        {
            AddNewSpeciesWindow addNewSpeciesWindow = new();
            SetCenterPositionAndOpen(addNewSpeciesWindow);
        }

        /// <summary>
        /// Окно добавления животного
        /// </summary>
        internal static void OpenAddAnimalWindowMethod()
        {
            AddNewAnimalWindow addNewEnimalWindow = new();
            SetCenterPositionAndOpen(addNewEnimalWindow);
        }

        #endregion
    }
}
