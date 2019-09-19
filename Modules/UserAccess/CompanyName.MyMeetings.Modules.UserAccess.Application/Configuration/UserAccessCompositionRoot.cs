﻿using System;
using System.Collections.Generic;
using System.Text;
using Autofac;

namespace CompanyName.MyMeetings.Modules.UserAccess.Application.Configuration
{
    internal static class UserAccessCompositionRoot
    {
        private static IContainer _container;

        internal static void SetContainer(IContainer container)
        {
            _container = container;
        }

        internal static ILifetimeScope BeginLifetimeScope()
        {
            return _container.BeginLifetimeScope();
        }
    }
}