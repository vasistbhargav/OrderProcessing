using OrderProcessingLibrary.Enums;

namespace OrderProcessingLibrary.Abstracts
{
    public abstract class AbstractMembership
    {
        public virtual bool SendEmailToOwner(MembershipType membershipType, string email)
        {
            return true;
        }
    }
    
}
