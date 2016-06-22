using Abp.Authorization.Users;
using Abp.NHibernate.EntityMappings;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class UserLoginAttemptMap : EntityMap<UserLoginAttempt, long>
    {
        public UserLoginAttemptMap()
            : base("AbpUserLoginAttempts")
        {
            Map(x => x.UserId);
            Map(x => x.UserNameOrEmailAddress);
            Map(x => x.ClientIpAddress);
            Map(x => x.ClientName);
            Map(x => x.BrowserInfo);
            Map(x => x.Result).CustomType<AbpLoginResultType>();
            Map(x => x.CreationTime).Default("getdate()");
        }
    }
}
