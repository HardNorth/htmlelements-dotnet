﻿using System;
using Common.Logging;
using HtmlElements.Test.Services;
using System.Configuration;
using HtmlElements.Test.Screens;
using HtmlElements.Test.Browsers;
using Ninject;
using Ninject.Modules;
using NUnit.Framework;
using System.Reflection;

namespace HtmlElements.Test.Tests
{
    public class BaseTest
    {
        private readonly IKernel context = new StandardKernel(new ConfigModule());

        private readonly ILog _log = LogManager.GetLogger(typeof(BaseTest));

        public BaseTest()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.CanWrite)
                {
                    object binding = context.Get(property.PropertyType);
                    if (binding != null)
                    {
                        property.SetValue(this, binding, null);
                    }
                }
            }
        }

        [TestFixtureTearDown]
        protected void OnTearDown()
        {
            if (bool.Parse(ConfigurationManager.AppSettings["Context.Dispose"]))
            {
                context.Dispose();
            }
        }
    }

    public class ConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IBrowserFactory>().To<BrowserFactory>().InSingletonScope()
                .WithConstructorArgument("browserType", Properties.Settings.Default.browser_type)
                .WithPropertyValue("LoadTimeout", Properties.Settings.Default.browser_loadTimeout)
                .WithPropertyValue("PollingInterval", Properties.Settings.Default.browser_pollingInterval);

            Bind<IYandexGuiService>().To<YandexGuiService>()
                .WithPropertyValue("BaseUrl", Properties.Settings.Default.yandex_service_baseurl);
        }
    }
}