using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.Views.Windows.ChangedData;

namespace Homework_18_Patterns.ViewModels.Commands
{
    internal class ChangedDataWindowCommands : MainWindowCommandViewModel
    {
        #region Свойства для редактирования животного

        /// <summary>
        /// Свойство привязанное к TextBox для получения новой клички животного
        /// </summary>
        public string? NewAnimalName { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения нового окраса животного
        /// </summary>
        public string? NewColor { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения нового возраста животного
        /// </summary>
        public int NewAge { get; set; }

        private static Animal OldAnimal { get; set; }

        #endregion

        #region Открытие окна редактирования животного

        private static ChangedAnimalWindow _changedEnimalWindow;

        /// <summary>
        /// Окно редактирования животного
        /// </summary>
        internal static void OpenChangedAnimalWindowMethod(Animal animal)
        {
            OldAnimal = animal;
            _changedEnimalWindow = new();
            MainMethods.SetCenterPositionAndOpen(_changedEnimalWindow);
        }

        #endregion

        #region Команда редактирования животного

        private readonly RelayCommand? _changedAnimal ;

        /// <summary>
        /// Команда изменения животного
        /// </summary>
        public RelayCommand ChangedAnimal
        {
            get
            {
                return _changedAnimal ?? new RelayCommand(obj =>
                {
                    string resultStr = "не выбрано животное";

                    if (OldAnimal != null)
                    {
                        resultStr = DataAnimal.ChangedAnimal(OldAnimal, NewAnimalName, NewColor, NewAge);
                        _changedEnimalWindow.Close();
                        MainMethods.ShowMessageToUser(resultStr);
                    }
                    else
                    {
                        MainMethods.ShowMessageToUser(resultStr);
                    }
                });
            }
        }

        #endregion
    }
}
