﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(TestingSystem.WEB.Startup))]
namespace TestingSystem.WEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}