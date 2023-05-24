using Homework_18_Patterns.Views.Windows.ChangedData;

namespace Homework_18_Patterns.ViewModels
{
    internal class OpenChangedAnimalWindowMethods : MainMethods
    {
        #region Методы открытия окна редактирования

        /// <summary>
        /// Окно редактирования животного
        /// </summary>
        internal static void OpenChangedAnimalWindowMethod()
        {
            ChangedEnimalWindow changedEnimalWindow = new();
            SetCenterPositionAndOpen(changedEnimalWindow);
        }

        #endregion
    }
}
