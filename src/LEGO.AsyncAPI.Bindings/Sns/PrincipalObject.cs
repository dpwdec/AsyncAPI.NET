// Copyright (c) The LEGO Group. All rights reserved.

using LEGO.AsyncAPI.Models.Interfaces;

namespace LEGO.AsyncAPI.Bindings.Sns;

public class PrincipalObject : StringOrStringList
{
    public PrincipalObject(IAsyncApiAny value)
        : base(value)
    {
    }
}