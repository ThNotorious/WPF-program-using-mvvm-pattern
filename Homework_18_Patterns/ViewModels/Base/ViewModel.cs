using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Homework_18_Patterns.ViewModels.Base
{
    internal abstract class ViewModel : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        /// <summary>
        /// Обновление значения свойства
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="value"></param>
        /// <param name="PropertyName"></param>
        /// <returns></returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? PropertyName = null)
        {
            if(Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(PropertyName);
            return true;
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private bool _disposed;
      
        /// <summary>
        /// Освобождение управляемых ресурсов
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || _disposed) return;
        }
    } 
}
