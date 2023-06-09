﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfControls.ViewModels
{
    public partial class InputBoxViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _title = string.Empty;

        [ObservableProperty]
        private string _prompt = string.Empty;

        [ObservableProperty]
        private string _response = string.Empty;

        [RelayCommand]
        private void Ok(Window window)
        {
            window.DialogResult = true;
        }

        public InputBoxViewModel(string title, string prompt, string defaultInputMessage)
        {
            Title = title;
            Prompt = prompt;
            Response = defaultInputMessage;
        }
    }
}
