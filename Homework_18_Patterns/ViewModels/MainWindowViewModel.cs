using Homework_18_Patterns.ViewModels.Base;

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
    }
}
