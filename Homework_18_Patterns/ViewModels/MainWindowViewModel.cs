using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.ViewModels.Base;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace Homework_18_Patterns.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _title = "Анализ Статистики Homework_18_Patterns";

        #region Заголовок окна

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _title;
            //set
            //{
            //    if (Equals(_title, value)) return;
            //    _title = value;
            //    OnPropertyChanged();
            //}
            set => Set(ref _title, value);
        }
        #endregion

        #region Статус программы
        private string  _status = "Готов!";

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

        #region  CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private bool OnCloseApplicationCommandExecuted(object p) => true;

        private void CanCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();
        }

        #endregion
        
        #endregion


        public MainWindowViewModel()
        {
            #region  Команды 
            
            CloseApplicationCommand = new RelayCommand(CanCloseApplicationCommandExecute, OnCloseApplicationCommandExecuted);

            #endregion
        }

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
        private List<AnimalSpecies> allAnimalSpecies = DataAnimal.GetAllSpecies();
        public List<AnimalSpecies> AllAnimalSpecies
        {
            get => allAnimalSpecies;
            set => Set(ref allAnimalSpecies, value);
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
    }
}
