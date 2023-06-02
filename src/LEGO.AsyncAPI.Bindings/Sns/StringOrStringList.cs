// Copyright (c) The LEGO Group. All rights reserved.

using System;
using LEGO.AsyncAPI.Models.Any;
using LEGO.AsyncAPI.Models.Interfaces;

namespace LEGO.AsyncAPI.Bindings.Sns;

public class StringOrStringList : IAsyncApiElement
{
    public StringOrStringList(IAsyncApiAny value)
    {
        this.Value = value switch
        {
            AsyncApiArray => value,
            AsyncApiPrimitive<string> => value,
            _ => throw new ArgumentOutOfRangeException($"{nameof(PrincipalObject)} value is invalid.")
        };
    }
        
    public IAsyncApiAny Value { get; }
}