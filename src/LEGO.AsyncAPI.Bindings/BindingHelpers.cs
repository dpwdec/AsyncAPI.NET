// Copyright (c) The LEGO Group. All rights reserved.

namespace LEGO.AsyncAPI.Bindings
{
    using LEGO.AsyncAPI.Readers.ParseNodes;

    public static class BindingHelpers
    {
        public static T ParseMap<T>(this ParseNode node, FixedFieldMap<T> fixedFieldMap)
            where T : new()
        {
            var mapNode = node.CheckMapNode(node.Context.GetLocation());
            if (mapNode == null)
            {
                return default(T);
            }

            var instance = new T();

            foreach (var propertyNode in mapNode)
            {
                propertyNode.ParseField(instance, fixedFieldMap, null);
            }

            return instance;
        }
    }
}