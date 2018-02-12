﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System.Numerics;
using SixLabors.ImageSharp.ColorSpaces.Conversion.Implementation.Icc.Calculators;
using SixLabors.ImageSharp.MetaData.Profiles.Icc;
using Xunit;

namespace SixLabors.ImageSharp.Tests.Colorspaces.Icc.Calculators
{
    /// <summary>
    /// Tests ICC <see cref="LutABCalculator"/>
    /// </summary>
    public class LutABCalculatorTests
    {
        [Theory]
        [MemberData(nameof(IccConversionDataLutAB.LutAToBConversionTestData), MemberType = typeof(IccConversionDataLutAB))]
        internal void LutABCalculator_WithLutAToB_ReturnsResult(IccLutAToBTagDataEntry lut, Vector4 input, Vector4 expected)
        {
            var calculator = new LutABCalculator(lut);

            Vector4 result = calculator.Calculate(input);

            VectorAssert.Equal(expected, result, 4);
        }

        [Theory]
        [MemberData(nameof(IccConversionDataLutAB.LutBToAConversionTestData), MemberType = typeof(IccConversionDataLutAB))]
        internal void LutABCalculator_WithLutBToA_ReturnsResult(IccLutBToATagDataEntry lut, Vector4 input, Vector4 expected)
        {
            var calculator = new LutABCalculator(lut);

            Vector4 result = calculator.Calculate(input);

            VectorAssert.Equal(expected, result, 4);
        }
    }
}