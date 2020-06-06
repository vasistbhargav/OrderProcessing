using OrderProcessingLibrary.Abstracts;
using OrderProcessingLibrary.Enums;
using OrderProcessingLibrary.Interfaces;
using OrderProcessingLibrary.Models;

namespace OrderProcessingLibrary
{
    public class MembershipUpgradation : AbstractMembership, IProduct
    {
        public bool ProcessOrder(User user)
        {
            bool isMembershipActivated = ApplyUpgrade();
            bool isEmailSentToOwner = SendEmailToOwner(MembershipType.Upgradation, user.Email);
            return isMembershipActivated && isEmailSentToOwner;
        }
        public bool ApplyUpgrade()
        {
            return true;
        }
    }
}
