using OrderProcessingLibrary.Interfaces;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class OrderProcessing
    {
        IProduct _product;
        User _user;
        public OrderProcessing(IProduct product, User user)
        {
            _product = product;
            _user = user;
        }

        public bool ProcessOrder()
        {
            return _product.ProcessOrder(_user);
        }
    }
}
