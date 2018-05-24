﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using System.Linq;

namespace Geb.Image.Formats.MetaData.Profiles.Icc
{
    /// <summary>
    /// This type represents an array of doubles (from 32bit values).
    /// </summary>
    internal sealed class IccUFix16ArrayTagDataEntry : IccTagDataEntry, IEquatable<IccUFix16ArrayTagDataEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IccUFix16ArrayTagDataEntry"/> class.
        /// </summary>
        /// <param name="data">The array data</param>
        public IccUFix16ArrayTagDataEntry(float[] data)
            : this(data, IccProfileTag.Unknown)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IccUFix16ArrayTagDataEntry"/> class.
        /// </summary>
        /// <param name="data">The array data</param>
        /// <param name="tagSignature">Tag Signature</param>
        public IccUFix16ArrayTagDataEntry(float[] data, IccProfileTag tagSignature)
            : base(IccTypeSignature.U16Fixed16Array, tagSignature)
        {
            Guard.NotNull(data, nameof(data));
            this.Data = data;
        }

        /// <summary>
        /// Gets the array data.
        /// </summary>
        public float[] Data { get; }

        /// <inheritdoc/>
        public override bool Equals(IccTagDataEntry other)
        {
            return other is IccUFix16ArrayTagDataEntry entry && this.Equals(entry);
        }

        /// <inheritdoc/>
        public bool Equals(IccUFix16ArrayTagDataEntry other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return base.Equals(other) && this.Data.SequenceEqual(other.Data);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj is IccUFix16ArrayTagDataEntry other && this.Equals(other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ (this.Data?.GetHashCode() ?? 0);
            }
        }
    }
}