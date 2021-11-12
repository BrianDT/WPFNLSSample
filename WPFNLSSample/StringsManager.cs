// <copyright file="StringsManager.cs" company="Visual Software Systems Ltd.">Copyright (c) 2016 - 2021 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Resources;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// A helper class for string resources.
    /// </summary>
    public class StringsManager
    {
        /// <summary>
        /// A resource string resource source.
        /// </summary>
        private ResourceManager resourceManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringsManager"/> class.
        /// </summary>
        /// <param name="resourceManager">The resource source.</param>
        public StringsManager(ResourceManager resourceManager)
        {
            this.resourceManager = resourceManager;
        }

        /// <summary>
        /// Finds a national language string resource.
        /// </summary>
        /// <param name="key">The string resource name.</param>
        /// <returns>The string.</returns>
        public string GetNLSString(string key)
        {
            return this.resourceManager.GetString(key);
        }

        /// <summary>
        /// Finds a national language string resource from the attribute on an enum.
        /// </summary>
        /// <param name="value">The enum.</param>
        /// <returns>The string.</returns>
        public string FindStringFromEnumNLS(Enum value)
        {
            var enumType = value.GetType();
            var name = Enum.GetName(enumType, value);
            NLSAttribute attribute = enumType.GetField(name).GetCustomAttributes(false).OfType<NLSAttribute>().SingleOrDefault();
            return this.GetNLSString(attribute.Key);
        }
    }
}
