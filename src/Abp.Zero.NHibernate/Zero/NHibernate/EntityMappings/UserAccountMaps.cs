using Abp.Authorization.Users;
using Abp.NHibernate.EntityMappings;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class UserAccountMap : EntityMap<UserAccount, long>
    {
        public UserAccountMap()
            : base("AbpUserAccounts")
        {
            Map(x => x.TenantId);
            Map(x => x.UserId);
            Map(x => x.UserLinkId);
            Map(x => x.UserName);
            Map(x => x.EmailAddress);
            Map(x => x.LastLoginTime);
        }
    }


}
