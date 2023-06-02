// Copyright (c) The LEGO Group. All rights reserved.

using LEGO.AsyncAPI.Models.Interfaces;

namespace LEGO.AsyncAPI.Bindings.Sns;

public class ActionObject : StringOrStringList
{
    public ActionObject(IAsyncApiAny value)
        : base(value)
    {
    }
}