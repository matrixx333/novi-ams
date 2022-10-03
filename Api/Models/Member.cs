using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Models
{
    public class Member
    {
       public string UniqueID { get; set; }
        public string TenantID { get; set; }
        public string ParentCustomerUniqueID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Suffix { get; set; }
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public object Website { get; set; }
        public string County { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public ShippingAddress ShippingAddress { get; set; }
        public string PersonalEmail { get; set; }
        public object PersonalPhone { get; set; }
        public object PersonalMobile { get; set; }
        public PersonalAddress PersonalAddress { get; set; }
        public object Notes { get; set; }
        public object FacebookUrl { get; set; }
        public object LinkedInUrl { get; set; }
        public string InstagramHandle { get; set; }
        public string TwitterHandle { get; set; }
        public string MemberProfile { get; set; }
        public string JobTitle { get; set; }
        public string Image { get; set; }
        public DateTime? OriginalJoinDate { get; set; }
        public object MemberSince { get; set; }
        public object MembershipExpires { get; set; }
        public string MemberStatus { get; set; }
        public object MemberSubStatus { get; set; }
        public bool HideOnWebsite { get; set; }
        public bool HideContactInformation { get; set; }
        public bool UnsubscribeFromEmails { get; set; }
        public bool Approved { get; set; }
        public bool AutoRenew { get; set; }
        public bool AutoPay { get; set; }
        public object MemberType { get; set; }
        public string CustomerType { get; set; }
        public CustomFields CustomFields { get; set; }
        public List<string> SpecifiedSystemFields { get; set; }
        public string QuickBooksID { get; set; }
        public List<Group> Groups { get; set; }
    }
}