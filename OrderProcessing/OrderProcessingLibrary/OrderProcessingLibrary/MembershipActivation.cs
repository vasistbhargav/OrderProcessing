using OrderProcessingLibrary.Abstracts;
using OrderProcessingLibrary.Enums;
using OrderProcessingLibrary.Interfaces;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class MembershipActivation : AbstractMembership, IProduct
    {
        public bool ProcessOrder(User user)
        {
            bool isMembershipActivated = ActivateMembership();
            bool isEmailSentToOwner = SendEmailToOwner(MembershipType.Activation, user.Email);
            return isMembershipActivated && isEmailSentToOwner;
        }
        public bool ActivateMembership()
        {
            return true;
        }
    }
}
