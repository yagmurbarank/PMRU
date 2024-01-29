namespace PMRU.BlazorUI.Localization
{
    public class LocalizerSettings
    {

        public static CultureWithName NeutralCulture =
            new CultureWithName("Turkish", "tr-TR");

        public static readonly List<CultureWithName> SupportedCulturesWithName =
            new List<CultureWithName>()
            {
                new CultureWithName("Turkish", "tr-TR"),
                new CultureWithName("English(US)", "en-US")
            };
    }
}
