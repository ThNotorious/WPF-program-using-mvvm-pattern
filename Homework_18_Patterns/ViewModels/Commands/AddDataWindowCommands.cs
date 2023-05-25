using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using System.Windows;

namespace Homework_18_Patterns.ViewModels.Commands
{
    internal class AddDataWindowCommands : MainWindowCommandViewModel
    {
        #region  Команды окон добавления данных в базу

        #region Свойства для создания нового класса

        /// <summary>
        /// Свойство привязанное к TextBox для получения названия нового класса
        /// </summary>
        internal string? ClassName { get; set; }

        #endregion

        #region Команда создания нового класса
       
        private readonly RelayCommand? _openAddClassWindowCommand;

        /// <summary>
        /// Команда создания нового класса
        /// </summary>
        internal RelayCommand AddNewClassWindowCommand
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
        public AnimalClass SpeciesClass { get; set; }

        #endregion

        #region Команда создания нового вида

        private readonly RelayCommand? _openAddSpeciesWindowCommand;

        /// <summary>
        /// Команда создания нового вида
        /// </summary>
        internal RelayCommand AddNewSpeciesWindowCommand
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
                    if (SpeciesClass == null)
                    {
                        MainMethods.ShowMessageToUser("Укажите класс!");
                    }
                    else
                    {
                        MainMethods.ShowMessageToUser(DataAnimal.CreateSpecies(SpeciesName, SpeciesClass));
                        window.Close();
                    }
                });
            }
        }

        #endregion


        #region Свойства для создания нового животного

        /// <summary>
        /// Свойство привязанное к TextBox для получения клички нового животного
        /// </summary>
        internal string? AnimalName { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения окраса нового животного
        /// </summary>
        internal string? Color { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения возраста нового животного
        /// </summary>
        internal int Age { get; set; }

        /// <summary>
        /// Свойство привязанное к TextBox для получения пола нового животного
        /// </summary>
        internal string? Gender { get; set; }

        /// <summary>
        /// Свойство для привязки жиотного к конкретному виду
        /// </summary>
        internal AnimalSpecies AnimalSpecies { get; set; }

        #endregion

        #region Команда создания нового животного
        
        private readonly RelayCommand? _openAddAnimalWindowCommand;

        /// <summary>
        /// Команда создания нового жиотного
        /// </summary>
        internal RelayCommand AddNewAnimalWindowCommand
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
                    if(AnimalSpecies == null)
                    {
                        MainMethods.ShowMessageToUser("Укажите вид!");
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
