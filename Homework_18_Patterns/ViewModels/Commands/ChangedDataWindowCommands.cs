using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using System.Windows;

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

        #endregion


        #region Команда редактирования позиции

        private readonly RelayCommand? _changedAnimal;

        /// <summary>
        /// Команда изменения позиции
        /// </summary>
        public RelayCommand ChangedAnimal
        {
            get
            {
                return _changedAnimal ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;

                    string resultStr = "не выбрано животное";

                    if(SelectedAnimal != null)
                    {
                        resultStr = DataAnimal.ChangedAnimal(SelectedAnimal, NewAnimalName, NewColor, NewAge);
                        MainMethods.ShowMessageToUser(resultStr);
                        window.Close();
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
