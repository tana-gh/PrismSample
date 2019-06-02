using Prism.Events;
using Prism.Mvvm;
using Reactive.Bindings;
using Unity.Attributes;
using PrismSample.Lib.Models;
using PrismSample.Lib.Views;

namespace PrismSample.Lib.ViewModels
{
    public class AnswerViewModel : BindableBase
    {
        [Dependency]
        public IDialogHelper DialogHelper { get; set; }

        [Dependency]
        public IModel Model { get; set; }

        public ReactiveProperty<string> Answer { get; }

        public ReactiveCommand<object> ShowDialogCommand { get; }

        public AnswerViewModel(IEventAggregator eventAggregator)
        {
            Answer = new ReactiveProperty<string>("4");
            
            eventAggregator
                .GetEvent<PubSubEvent<double>>()
                .Subscribe(CalculateAnswer);
            
            ShowDialogCommand = new ReactiveCommand()
                .WithSubscribe(_ => DialogHelper.ShowDialog($"N^2 = {Answer.Value}"));
        }

        private void CalculateAnswer(double operand)
        {
            Answer.Value = Model.Calculate(operand).ToString();
        }
    }
}
