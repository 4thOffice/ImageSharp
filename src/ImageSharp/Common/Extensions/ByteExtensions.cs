﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Runtime.CompilerServices;
using SixLabors.ImageSharp.PixelFormats;

namespace SixLabors.ImageSharp
{
    /// <summary>
    /// Extension methods for the <see cref="byte"/> struct buffers.
    /// </summary>
    internal static class ByteExtensions
    {
        /// <summary>
        /// Returns a reference to the given position of the array unsafe casted to <see cref="ImageSharp.PixelFormats.Rgb24"/>.
        /// </summary>
        /// <param name="bytes">The byte array.</param>
        /// <param name="offset">The offset in bytes.</param>
        /// <returns>The <see cref="ImageSharp.PixelFormats.Rgb24"/> reference at the given offset.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Rgb24 GetRgb24(this byte[] bytes, int offset)
        {
            DebugGuard.MustBeLessThan(offset + 2, bytes.Length, nameof(offset));

            return ref Unsafe.As<byte, Rgb24>(ref bytes[offset]);
        }

        /// <summary>
        /// Returns a reference to the given position of the span unsafe casted to <see cref="ImageSharp.PixelFormats.Rgb24"/>.
        /// </summary>
        /// <param name="bytes">The byte span.</param>
        /// <param name="offset">The offset in bytes.</param>
        /// <returns>The <see cref="ImageSharp.PixelFormats.Rgb24"/> reference at the given offset.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Rgb24 GetRgb24(this Span<byte> bytes, int offset)
        {
            DebugGuard.MustBeLessThan(offset + 2, bytes.Length, nameof(offset));

            return ref Unsafe.As<byte, Rgb24>(ref bytes[offset]);
        }

        /// <summary>
        ///  Returns a reference to the given position of the buffer pointed by `baseRef` unsafe casted to <see cref="ImageSharp.PixelFormats.Rgb24"/>.
        /// </summary>
        /// <param name="baseRef">A reference to the beginning of the buffer</param>
        /// <param name="offset">The offset in bytes.</param>
        /// <returns>The <see cref="ImageSharp.PixelFormats.Rgb24"/> reference at the given offset.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref Rgb24 GetRgb24(ref byte baseRef, int offset)
        {
            return ref Unsafe.As<byte, Rgb24>(ref Unsafe.Add(ref baseRef, offset));
        }
    }
}