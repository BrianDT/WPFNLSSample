// <copyright file="ThingItem.cs" company="Visual Software Systems Ltd.">Copyright (c) 2021 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The backing for an item in the displayed list of things.
    /// </summary>
    public class ThingItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThingItem"/> class.
        /// </summary>
        /// <param name="thing">The enum value.</param>
        /// <param name="name">The locale specific name.</param>
        public ThingItem(Things thing, string name)
        {
            this.Name = name;
            this.Thing = thing;
        }

        /// <summary>
        /// Gets the locale specific name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the enum value.
        /// </summary>
        public Things Thing { get; private set; }
    }
}
