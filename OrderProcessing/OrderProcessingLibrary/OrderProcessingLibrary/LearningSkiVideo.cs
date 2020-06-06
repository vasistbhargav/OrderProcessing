using OrderProcessingLibrary.Abstracts;
using OrderProcessingLibrary.Interfaces;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class LearningSkiVideo : AbstractVideoProduct, IProduct
    {
        public bool ProcessOrder(User user)
        {
            bool isFirstAidVideoAdded = AddFirstAidVideoToPackingSlip();
            bool isPackingSlipGenerated = GeneratePackingSlip();
            return isFirstAidVideoAdded && isPackingSlipGenerated;
        }
        public bool AddFirstAidVideoToPackingSlip()
        {
            return true;
        }
    }
}
