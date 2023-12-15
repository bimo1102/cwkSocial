using CwkSocial.Domain.Aggregates.UserProfileAggregate;

namespace CwkSocial.Domain.Aggregates.UserProfileAggregare
{
    public class UserProfile
    {
        public Guid UserProfileId { get; set; }
        public string IdentityId { get; set; }
        public BasicInfo BasicInfo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        private UserProfile() { }
        public static UserProfile CreateUserProfile(string identifyId, BasicInfo basicInfo)
        {
            //do validation, error handling strategies, error notification strategies
            return new UserProfile
            {
                IdentityId = identifyId,
                BasicInfo = basicInfo,
                DateCreated = DateTime.UtcNow,
                LastModified = DateTime.UtcNow
            };
        }
        public void UpdateBasicInfo(BasicInfo NewBasicInfo)
        {
            BasicInfo = NewBasicInfo;
            LastModified = DateTime.UtcNow;
        }

    }
}
