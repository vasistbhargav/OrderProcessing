using OrderProcessingLibrary;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class Book : PhysicalProduct
    {
        public override bool ProcessOrder(User user)
        {
            bool isPackingSlipGenerated = GeneratePackingSlipForShipping();
            bool isCommissionGenerated = GenerateCommissionPaymentToAgent();
            bool isDuplicatePackingSlipCreated = CreateDuplicatePackingSlipForRoyaltyDepartment();
            return isPackingSlipGenerated && isPackingSlipGenerated && isDuplicatePackingSlipCreated;
        }
        public bool CreateDuplicatePackingSlipForRoyaltyDepartment()
        {
            return true;
        }
    }
}
