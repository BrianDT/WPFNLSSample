// <copyright file="Things.cs" company="Visual Software Systems Ltd.">Copyright (c) 2021 All rights reserved</copyright>

namespace WPFNLSSample
{
    using System;

    /// <summary>
    /// An enumeration of codes that have locale specific descriptions.
    /// </summary>
    [Flags]
    public enum Things
    {
        [NLS("Thing_Alligator")]
        A = 1,

        [NLS("Thing_Bull_Finch")]
        B = 2,

        [NLS("Thing_Chinchilla")]
        C = 4,

        [NLS("Thing_Diplodocus")]
        D = 8
    }
}
