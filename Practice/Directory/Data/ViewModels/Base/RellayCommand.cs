using System;
using System.Windows.Input;

namespace Practice;

public class RellayCommand : ICommand
{
    public event EventHandler CanExecuteChanged = (sender, e) =>{ };

    private Action mAction;

    public RellayCommand(Action action)
    {
        mAction = action;
    }

    #region Command Methods

    

    public bool CanExecute(object? parameter)
    {
        return true;
    }

    public void Execute(object? parameter)
    {
        mAction();
    }
    #endregion

}