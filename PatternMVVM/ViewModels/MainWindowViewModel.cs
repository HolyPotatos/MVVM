using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using PatternMVVM.Models.Commands;
using PatternMVVM.ViewModels.Base;

namespace PatternMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна

        /// <summary> Заголовок окна </summary>
        private string _Title = "Анализ статистики";
        /// <summary> Заголовок окна </summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Команды

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }
        private void OnCloseApplicationCommandExecuted(object p) => Application.Current.Shutdown();
        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion

        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = 
                new RelayCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }
    }
}
