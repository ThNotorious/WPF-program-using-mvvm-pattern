using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.ViewModels.Base;
using System.Windows;

namespace Homework_18_Patterns.ViewModels.Commands
{
    internal class AddDataWindowCommands : ViewModel
    {
        #region  Команды окон добавления данных в базу

        #region Свойства для создания нового класса

        /// <summary>
        /// Свойство привязанное к TextBox для получения названия нового класса
        /// </summary>
        public string? ClassName { get; set; }

        private readonly RelayCommand? _openAddClassWindowCommand;

        #endregion

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


        #region Свойства для создания нового вида

        /// <summary>
        /// Свойство привязанное к TextBox для получения названия нового Вида
        /// </summary>
        public string? SpeciesName { get; set; }
       
        /// <summary>
        /// Свойство для привязки вида к конкретному классу
        /// </summary>
        public AnimalClass AnimalClass { get; set; }

        private readonly RelayCommand? _openAddSpeciesWindowCommand;

        #endregion

        #region Команда создания нового класса

        /// <summary>
        /// Команда создания нового вида
        /// </summary>
        public RelayCommand AddNewSpeciesWindowCommand
        {
            get
            {
                return _openAddSpeciesWindowCommand ?? new RelayCommand(obj =>
                {
                    Window? window = obj as Window;


                    if (ClassName == null || ClassName.Replace(" ", "").Length == 0)
                    {
                        MainMethods.SetRedBlockControl(window, "NameBlock");
                    }
                    else
                    {
                        MainMethods.ShowMessageToUser(DataAnimal.CreateSpecies(SpeciesName, AnimalClass));
                        window.Close();
                    }
                });
            }
        }

        #endregion

       
        #region Свойства для создания нового животного

        /// <summary>
        /// Свойство привязанное к TextBox для получения клички нового Жиотного
        /// </summary>
        public string? AnimalName { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения окраса нового Жиотного
        /// </summary>
        public string? Color { get; set; }
    
        /// <summary>
        /// Свойство привязанное к TextBox для получения возраста нового Жиотного
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения пола нового Жиотного
        /// </summary>
        public string? Gender { get; set; }

        /// <summary>
        /// Свойство для привязки жиотного к конкретному виду
        /// </summary>
        public AnimalSpecies AnimalSpecies { get; set; }

        private readonly RelayCommand? _openAddAnimalWindowCommand;

        #endregion

        #region Команда создания нового животного

        /// <summary>
        /// Команда создания нового жиотного
        /// </summary>
        public RelayCommand AddNewAnimalWindowCommand
        {
            get
            {
                return _openAddAnimalWindowCommand ?? new RelayCommand(obj =>
                {
                    Window? window = obj as Window;

                    if (ClassName == null || ClassName.Replace(" ", "").Length == 0)
                    {
                        MainMethods.SetRedBlockControl(window, "NameBlock");
                    }
                    else
                    {
                        MainMethods.ShowMessageToUser(DataAnimal.CreateAnimal(AnimalName, Color, Age, Gender, AnimalSpecies));
                        window.Close();
                    }
                });
            }
        }

        #endregion

        #endregion
    }
}
