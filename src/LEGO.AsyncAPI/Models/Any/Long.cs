﻿// Copyright (c) The LEGO Group. All rights reserved.

namespace LEGO.AsyncAPI.Any
{
    /// <summary>
    /// Async API null.
    /// </summary>
    public struct Long : PrimitiveValue<long?>
    {
        /// <summary>
        /// The type of <see cref="IOpenApiAny"/>.
        /// </summary>
        public PrimitiveType PrimitiveType { get; } = PrimitiveType.Long;
        
        public AnyType AnyType => AnyType.Primitive;

        public long? Value { get; set; }

        public static explicit operator long?(Long l) => l.Value;

        public static explicit operator Long(long l) => new () { Value = l };
    }
}