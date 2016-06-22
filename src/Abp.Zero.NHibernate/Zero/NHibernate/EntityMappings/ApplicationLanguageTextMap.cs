using Abp.Localization;
using Abp.NHibernate.EntityMappings;

namespace Abp.Zero.NHibernate.EntityMappings
{
    public class ApplicationLanguageTextMap : EntityMap<ApplicationLanguageText, long>
    {
        public ApplicationLanguageTextMap()
            : base("AbpLanguageTexts")
        {
            Map(x => x.TenantId);
            Map(x => x.LanguageName);
            Map(x => x.Source);
            Map(x => x.Key).Column("[Key]");
            Map(x => x.Value);
            
            this.MapAudited();
        }
    }
}