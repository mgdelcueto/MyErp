namespace MyErp.Resources
{
    using System.Globalization;
    using System.Reflection;

    using Microsoft.Extensions.Localization;

    public class LocService
    {
        private readonly IStringLocalizer _localizer;

        public LocService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("SharedResource", assemblyName.Name);
        }

        public LocalizedString GetLocalizedHtmlString(string key)
        {
            string traduce = (string)_localizer[key];
            string culture = CultureInfo.CurrentCulture.Name;
            return _localizer[key];
        }
    }
}