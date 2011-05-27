﻿using System.Web;
using Glimpse.Core.Configuration;
using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Validator
{
    [GlimpseValidator]
    internal class HttpHandlerValidator:IGlimpseValidator
    {
        public bool IsValid(HttpApplication application, GlimpseConfiguration configuration, LifecycleEvent lifecycleEvent)
        {
            if (lifecycleEvent == LifecycleEvent.BeginRequest)
                return true;

            return !(application.Context.Handler is IGlimpseHandler);
        }
    }
}
