using System.Windows;

namespace PrismSample.Lib.Views
{
    public class DialogHelper : IDialogHelper
    {
        public DialogResult ShowDialog
        (
            string message,
            string caption,
            DialogButton button,
            DialogImage  image
        )
        {
            return (DialogResult)MessageBox.Show
            (
                message,
                caption,
                (MessageBoxButton)button,
                (MessageBoxImage )image
            );
        }
    }
}
