using OrderProcessingLibrary.Abstracts;
using OrderProcessingLibrary.Interfaces;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class PhysicalProduct : AbstractPhysicalProduct, IProduct
    {
        public virtual bool ProcessOrder(User user)
        {
            bool isPackingSlipGenerated =  GeneratePackingSlipForShipping();
            bool isCommissionGenerated =  GenerateCommissionPaymentToAgent();
            return isPackingSlipGenerated && isPackingSlipGenerated;
        }
    }
}
