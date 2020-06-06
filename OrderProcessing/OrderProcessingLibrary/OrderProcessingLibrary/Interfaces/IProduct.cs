using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary.Interfaces
{
    public interface IProduct
    {
        bool ProcessOrder(User user);
    }
}
