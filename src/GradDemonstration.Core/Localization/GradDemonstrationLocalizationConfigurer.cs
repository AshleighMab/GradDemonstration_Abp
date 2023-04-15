using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace GradDemonstration.Localization
{
    public static class GradDemonstrationLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(GradDemonstrationConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(GradDemonstrationLocalizationConfigurer).GetAssembly(),
                        "GradDemonstration.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
