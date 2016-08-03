﻿using System;
using SuccincT.Options;

namespace SuccincT.Parsers
{
    /// <summary>
    /// Defines a set of string extension methods for parsing float, double and decimal
    /// values in an elegant fashion (avoiding exception throwing and out parameters).
    /// </summary>
    public static class FloatParsers
    {
        /// <summary>
        /// Parses the current string for a 32 bit float value and returns an Option{float} with None or the value.
        /// </summary>
        public static Option<float> TryParseFloat(this string source) => ReflectionBasedParser.Parse<float>(source);

        /// <summary>
        /// Parses the current string for a 64 bit float value and returns an Option{double} with None or the value.
        /// </summary>
        public static Option<double> TryParseDouble(this string source) => ReflectionBasedParser.Parse<double>(source);

        /// <summary>
        /// Parses the current string for a 128 bit float value and returns an Option{decimal} with None or the value.
        /// </summary>
        public static Option<decimal> TryParseDecimal(this string source) => ReflectionBasedParser.Parse<decimal>(source);

        /// <summary>
        /// Parses the current string for a 32 bit float value and returns an Option{float} with None or the value.
        /// </summary>
        [Obsolete("ParseFloat has been replaced with TryParseFloat and will be removed in v2.1.")]
        // ReSharper disable once UnusedMember.Global - Obsolete
        public static Option<float> ParseFloat(this string source) => ReflectionBasedParser.Parse<float>(source);

        /// <summary>
        /// Parses the current string for a 64 bit float value and returns an Option{double} with None or the value.
        /// </summary>
        [Obsolete("ParseDouble has been replaced with TryParseDouble and will be removed in v2.1.")]
        // ReSharper disable once UnusedMember.Global - Obsolete
        public static Option<double> ParseDouble(this string source) => ReflectionBasedParser.Parse<double>(source);

        /// <summary>
        /// Parses the current string for a 128 bit float value and returns an Option{decimal} with None or the value.
        /// </summary>
        [Obsolete("ParseDecimal has been replaced with TryParseDecimal and will be removed in v2.1.")]
        // ReSharper disable once UnusedMember.Global - Obsolete
        public static Option<decimal> ParseDecimal(this string source) => ReflectionBasedParser.Parse<decimal>(source);
    }
}