using System.Windows;

namespace PrismSample.Lib.Views
{
    public enum DialogButton
    {
        OK          = MessageBoxButton.OK,
        OKCancel    = MessageBoxButton.OKCancel,
        YesNo       = MessageBoxButton.YesNo,
        YesNoCancel = MessageBoxButton.YesNoCancel
    }

    public enum DialogImage
    {
        None        = MessageBoxImage.None,
        Information = MessageBoxImage.Information,
        Question    = MessageBoxImage.Question,
        Warning     = MessageBoxImage.Warning,
        Error       = MessageBoxImage.Error
    }

    public enum DialogResult
    {
        None   = MessageBoxResult.None,
        OK     = MessageBoxResult.OK,
        Cancel = MessageBoxResult.Cancel,
        Yes    = MessageBoxResult.Yes,
        No     = MessageBoxResult.No
    }

    public interface IDialogHelper
    {
        DialogResult ShowDialog
        (
            string message,
            string caption      = "Information",
            DialogButton button = DialogButton.OK,
            DialogImage  image  = DialogImage.None
        );
    }
}
