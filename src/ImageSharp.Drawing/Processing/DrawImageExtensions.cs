// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing.Processors.Drawing;
using SixLabors.Primitives;

namespace SixLabors.ImageSharp.Processing
{
    /// <summary>
    /// Adds extensions that allow the drawing of images to the <see cref="Image{TPixel}"/> type.
    /// </summary>
    public static class DrawImageExtensions
    {
        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, Point.Empty, GraphicsOptions.Default.ColorBlendingMode, GraphicsOptions.Default.AlphaCompositionMode, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="colorBlending">The blending mode.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, PixelColorBlendingMode colorBlending, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, Point.Empty, colorBlending, GraphicsOptions.Default.AlphaCompositionMode, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="colorBlending">The color blending mode.</param>
        /// <param name="alphaComposition">The alpha composition mode.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, PixelColorBlendingMode colorBlending, PixelAlphaCompositionMode alphaComposition, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, Point.Empty, colorBlending, alphaComposition, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="options">The options, including the blending type and blending amount.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, GraphicsOptions options)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, Point.Empty, options.ColorBlendingMode, options.AlphaCompositionMode, options.BlendPercentage));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="location">The location to draw the blended image.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, Point location, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, location, GraphicsOptions.Default.ColorBlendingMode, GraphicsOptions.Default.AlphaCompositionMode, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="location">The location to draw the blended image.</param>
        /// <param name="colorBlending">The color blending to apply.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, Point location, PixelColorBlendingMode colorBlending, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, location, colorBlending, GraphicsOptions.Default.AlphaCompositionMode, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="location">The location to draw the blended image.</param>
        /// <param name="colorBlending">The color blending to apply.</param>
        /// <param name="alphaComposition">The alpha composition mode.</param>
        /// <param name="opacity">The opacity of the image to blend. Must be between 0 and 1.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, Point location, PixelColorBlendingMode colorBlending, PixelAlphaCompositionMode alphaComposition, float opacity)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, location, colorBlending, alphaComposition, opacity));

        /// <summary>
        /// Draws the given image together with the current one by blending their pixels.
        /// </summary>
        /// <typeparam name="TPixel">The pixel format.</typeparam>
        /// <param name="source">The image this method extends.</param>
        /// <param name="image">The image to blend with the currently processing image.</param>
        /// <param name="location">The location to draw the blended image.</param>
        /// <param name="options">The options containing the blend mode and opacity.</param>
        /// <returns>The <see cref="Image{TPixel}"/>.</returns>
        public static IImageProcessingContext<TPixel> DrawImage<TPixel>(this IImageProcessingContext<TPixel> source, Image<TPixel> image, Point location, GraphicsOptions options)
            where TPixel : struct, IPixel<TPixel>
            => source.ApplyProcessor(new DrawImageProcessor<TPixel>(image, location, options.ColorBlendingMode, options.AlphaCompositionMode, options.BlendPercentage));
    }
}