
namespace PrismSample.Lib.Models
{
    public class Model : IModel
    {
        public double Calculate(double operand)
        {
            return operand * operand;
        }
    }
}
