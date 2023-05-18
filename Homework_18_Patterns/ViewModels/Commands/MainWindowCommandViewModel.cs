using Homework_18_Patterns.Infrastructure.Commands;
using Homework_18_Patterns.Models;
using Homework_18_Patterns.ViewModels.Base;
using System.Collections.Generic;
using System.Windows;

namespace Homework_18_Patterns.ViewModels.Commands
{
    internal class MainWindowCommandViewModel : ViewModel
    {
        #region  Команды главного окна

        #region Команды открытия окон добавления

        private readonly RelayCommand? _openAddClassWindowCommand;

        /// <summary>
        /// Команда открытия окна добавления класса
        /// </summary>
        public RelayCommand OpenAddClassWindowCommand
        {
            get { return _openAddClassWindowCommand ?? new RelayCommand(obj => OpenAddWindowMethods.OpenAddClassWindowMethod()); }
        }


        private readonly RelayCommand? _openAddSpeciesWindowCommand;

        /// <summary>
        /// Команда открытия окна добавления вида
        /// </summary>
        public RelayCommand OpenAddSpeciesWindowCommand
        {
            get { return _openAddSpeciesWindowCommand ?? new RelayCommand(obj => OpenAddWindowMethods.OpenAddSpeciesWindowMethod()); }
        }


        private readonly RelayCommand? _openAddAnimalWindowCommand;

        /// <summary>
        /// Команда открытия окна добавления животного
        /// </summary>
        public RelayCommand OpenAddAnimalWindowCommand
        {
            get { return _openAddAnimalWindowCommand ?? new RelayCommand(obj => OpenAddWindowMethods.OpenAddAnimalWindowMethod()); }
        }

        #endregion

        #region Команды открытия окон изменения

        private readonly RelayCommand? _openChangedAnimalWindowCommand;

        /// <summary>
        /// Команда открытия окна изменения животного
        /// </summary>
        public RelayCommand OpenChangedAnimalWindowCommand
        {
            get { return _openChangedAnimalWindowCommand ?? new RelayCommand(obj => OpenChangedAnimalWindowMethods.OpenChangedAnimalWindowMethod()); }
        }
        #endregion

        #region Свойства привязки базы данных к DataGrid

        /// <summary>
        /// Получить все классы
        /// </summary>
        private List<AnimalClass> _allAnimalClasses = DataAnimal.GetAllClasses();
        public List<AnimalClass> AllAnimalClasses
        {
            get => _allAnimalClasses;
            set
            {
                if (_allAnimalClasses != value)
                {
                    _allAnimalClasses = value;
                    OnPropertyChanged(nameof(AllAnimalClasses));
                }
            }
        }

        /// <summary>
        /// Получить все виды
        /// </summary>
        private List<AnimalSpecies> _allAnimalSpecieses = DataAnimal.GetAllSpecies();
        public List<AnimalSpecies> AllAnimalSpecieses
        {
            get => _allAnimalSpecieses;
            set
            {
                if (_allAnimalSpecieses != value)
                {
                    _allAnimalSpecieses = value;
                    OnPropertyChanged(nameof(AllAnimalSpecieses));
                }
            }
        }

        /// <summary>
        /// Получить всех животных
        /// </summary>
        private List<Animal> _allAnimals = DataAnimal.GetAllAnimals();
        public List<Animal> AllAnimals
        {
            get => _allAnimals;
            set
            {
                if (_allAnimals != value)
                {
                    _allAnimals = value;
                    OnPropertyChanged(nameof(AllAnimals));
                }
            }
        }

        #endregion


        #endregion


    }
}
