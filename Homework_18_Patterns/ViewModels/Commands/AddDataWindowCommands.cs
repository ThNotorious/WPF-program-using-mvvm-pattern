using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.ViewModels.Base;
using System.Windows;

namespace Homework_18_Patterns.ViewModels.Commands
{
    internal class AddDataWindowCommands : ViewModel
    {

        #region  Команды окон добавления данных в базу

        /// <summary>
        /// Свойство привязанное к TextBox для получения имени нового класса
        /// </summary>
        public string? ClassName { get; set; }

        private readonly RelayCommand? _openAddClassWindowCommand;

        #region Команда создания нового класса

        /// <summary>
        /// Команда создания нового класса
        /// </summary>
        public RelayCommand AddNewClassWindowCommand
        {
            get
            {
                return _openAddClassWindowCommand ?? new RelayCommand(obj =>
                {
                    Window? window = obj as Window;

                    if (ClassName == null || ClassName.Replace(" ", "").Length == 0)
                    {
                        MainMethods.SetRedBlockControl(window, "NameBlock");
                    }
                    else
                    {
                        MainMethods.ShowMessageToUser(DataAnimal.CreateClass(ClassName));
                        window.Close();
                    }
                });
            }
        }
     
        #endregion

        #endregion
    }
}
