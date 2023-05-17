using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.ViewModels.Base;
using Homework_18_Patterns.Views.Windows.AddData;
using Homework_18_Patterns.Views.Windows.ChangedData;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Homework_18_Patterns.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {

        #region Заголовок окна
        
        private string _title = "База данных животных";

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _title;
            set => Set(ref _title, value);
        }
        #endregion
     
        #region Статус программы
       
        private string  _status = "";

        /// <summary>
        /// Статус программы
        /// </summary>
        public string Status
        { 
            get => _status; 
            set => Set(ref _status, value); 
        }

        #endregion



        #region  Команды 

        #region Команды открытия окон

        private readonly RelayCommand? _openAddClassWindowCommand;
       
        /// <summary>
        /// Команда открытия окна добавления класса
        /// </summary>
        public RelayCommand OpenAddClassWindowCommand
        {
            get { return _openAddClassWindowCommand ?? new RelayCommand(obj => OpenAddClassWindowMethod()); }
        }

        
        private readonly RelayCommand? _openAddSpeciesWindowCommand;

        /// <summary>
        /// Команда открытия окна добавления класса
        /// </summary>
        public RelayCommand OpenAddSpeciesWindowCommand
        {
            get { return _openAddSpeciesWindowCommand ?? new RelayCommand(obj => OpenAddSpeciesWindowMethod()); }
        }

      
        private readonly RelayCommand? _openAddAnimalWindowCommand;

        /// <summary>
        /// Команда открытия окна добавления животного
        /// </summary>
        public RelayCommand OpenAddAnimalWindowCommand
        {
            get { return _openAddAnimalWindowCommand ?? new RelayCommand(obj => OpenAddAnimalWindowMethod()); }
        }


        private readonly RelayCommand? _openChangedAnimalWindowCommand;

        /// <summary>
        /// Команда открытия окна изменения животного
        /// </summary>
        public RelayCommand OpenChangedAnimalWindowCommand
        {
            get { return _openChangedAnimalWindowCommand ?? new RelayCommand(obj => OpenChangedAnimalWindowMethod()); }
        }
        #endregion

        private readonly RelayCommand? _addNewClassWindowCommand;
        public string ClassName { get; set; }

        /// <summary>
        /// Команда открытия окна добавления класса
        /// </summary>
        public RelayCommand AddNewClassWindowCommand
        {
            get
            {
                return _addNewClassWindowCommand ?? new RelayCommand(obj =>
                {
                    Window window = obj as Window;
                    string result = "";

                    if (ClassName == null || ClassName.Replace(" ", "").Length == 0)
                    {
                        SetRedBlockControl(window, "NameBlock");
                    }
                    else
                    {
                        result = DataAnimal.CreateClass(ClassName);
                    }
                });
            }
        }


        #endregion

        #region Получение данных

        /// <summary>
        /// Получить все классы
        /// </summary>
        private List<AnimalClass> allAnimalClasses = DataAnimal.GetAllClasses();
        public List<AnimalClass> AllAnimalClasses
        {
            get => allAnimalClasses;
            set => Set(ref allAnimalClasses, value);
        }

        /// <summary>
        /// Получить все виды
        /// </summary>
        private List<AnimalSpecies> allAnimalSpecieses = DataAnimal.GetAllSpecies();
        public List<AnimalSpecies> AllAnimalSpecieses
        {
            get => allAnimalSpecieses;
            set => Set(ref allAnimalSpecieses, value);
        }

        /// <summary>
        /// Получить все виды
        /// </summary>
        private List<Animal> allAnimals = DataAnimal.GetAllAnimals();
        public List<Animal> AllAnimals
        {
            get => allAnimals;
            set => Set(ref allAnimals, value);
        }
       
        #endregion

        #region Методы открытия окон

        /// <summary>
        /// Метод открытия окна
        /// </summary>
        private void SetCenterPositionAndOpen(Window window)
        {
            window.Owner = Application.Current.MainWindow;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }

        #region Окна добавления

        /// <summary>
        /// Окно добавления класса
        /// </summary>
        private void OpenAddClassWindowMethod()
        {
            AddNewClassWindow addNewClassWindow = new AddNewClassWindow();
            SetCenterPositionAndOpen(addNewClassWindow);
        } 
        
        /// <summary>
        /// Окно добавления вида
        /// </summary>
        private void OpenAddSpeciesWindowMethod()
        {
            AddNewSpeciesWindow addNewSpeciesWindow = new AddNewSpeciesWindow();
            SetCenterPositionAndOpen(addNewSpeciesWindow);
        } 
        
        /// <summary>
        /// Окно добавления животного
        /// </summary>
        private void OpenAddAnimalWindowMethod()
        {
            AddNewEnimalWindow addNewEnimalWindow = new AddNewEnimalWindow();
            SetCenterPositionAndOpen(addNewEnimalWindow);
        }

        #endregion
       
        #region Окна редактирования
        
        /// <summary>
        /// Окно редактирования животного
        /// </summary>
        private void OpenChangedAnimalWindowMethod()
        {
            ChangedEnimalWindow changedEnimalWindow = new ChangedEnimalWindow();
            SetCenterPositionAndOpen(changedEnimalWindow);
        }

        #endregion

        #endregion


        private void SetRedBlockControl(Window window, string blockName)
        {
            Control block = window.FindName(blockName) as Control;
            block.BorderBrush = Brushes.Red;
        }
    }
}
