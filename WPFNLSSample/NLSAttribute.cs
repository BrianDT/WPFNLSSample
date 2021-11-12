// <copyright file="NLSAttribute.cs" company="Visual Software Systems Ltd.">Copyright (c) 2016 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;

    /// <summary>
    /// A National Language attribute.
    /// </summary>
    public class NLSAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NLSAttribute" /> class.
        /// </summary>
        /// <param name="key">The key to the language file.</param>
        public NLSAttribute(string key)
        {
            this.Key = key;
        }

        /// <summary>
        /// Gets the key to the language file.
        /// </summary>
        public string Key { get; private set; }
    }
}
