// <copyright file="MainViewModel.cs" company="Visual Software Systems Ltd.">Copyright (c) 2021 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The main view model for the sample.
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// A helper service for obtaining string resources.
        /// </summary>
        private StringsManager stringsManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            this.stringsManager = new StringsManager(Strings.Resources.ResourceManager);

            this.Items = new List<ThingItem>();
            foreach (var enumValue in typeof(Things).GetEnumValues().OfType<Things>())
            {
                var name = this.stringsManager.FindStringFromEnumNLS(enumValue);
                var item = new ThingItem(enumValue, name);
                this.Items.Add(item);
            }
        }

        /// <summary>
        /// Gets the collection of things to be displayed.
        /// </summary>
        public List<ThingItem> Items { get; private set; }

        /// <summary>
        /// Gets some text obtainded from the NLS strings.
        /// </summary>
        public string FromCode
        {
            get
            {
                return this.stringsManager.GetNLSString("Example2");
            }
        }
    }
}
