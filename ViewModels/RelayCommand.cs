using System.Windows.Input;
using System;

namespace StudentManager.ViewModels;

public class RelayCommand : ICommand
{
    private readonly Action _execute;

    public RelayCommand(Action execute)
    {
        _execute = execute;
    }

    public bool CanExecute(object? parameter) => true;

    public void Execute(object? parameter) => _execute();

    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }
}
