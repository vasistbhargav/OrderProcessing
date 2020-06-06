
namespace OrderProcessingLibrary.Abstracts
{
    public abstract class AbstractPhysicalProduct
    {
        public virtual bool GeneratePackingSlipForShipping()
        {
            return true;
        }
        public virtual bool GenerateCommissionPaymentToAgent()
        {
            return true;
        }
    }
}
