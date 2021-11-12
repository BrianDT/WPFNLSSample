// <copyright file="App.xaml.cs" company="Visual Software Systems Ltd.">Copyright (c) 2021 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Globalization;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;

    /// <summary>
    /// Interaction logic for App.xaml.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        public App()
        {
            // Creates and initializes the CultureInfo which uses the international sort.
            // Force culture change for testing
            CultureInfo culture = new CultureInfo("fr-FR", false);
            System.Threading.Thread.CurrentThread.CurrentUICulture = culture;
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;
        }
    }
}
