﻿using Veises.Common.Service;
using Veises.Common.Service.Versionning;
using Veises.Common.Services.Swagger;

namespace Veises.SocialNet.Message
{
    public class Program
    {
        public static void Main()
        {
            using (var serviceHost = ServiceHost.Create()
                .WithDefaultConfigFile()
                .WithLogging()
                .WithApiVersionning()
                .WithSwagger("SocialNet Messages .", "Veises SocialNet message microservice.")
                .Build())
            {
                serviceHost.Run();
            }
        }
    }
}