using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpDemoThree.Localization
{
    public static class AbpDemoThreeLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpDemoThreeConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpDemoThreeLocalizationConfigurer).GetAssembly(),
                        "AbpDemoThree.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
