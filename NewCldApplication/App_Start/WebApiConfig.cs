﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;
using WebApplication4.Models;

namespace WebApplication4
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            
            config.SuppressDefaultHostAuthentication();
            
            
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
           
            // Web API routes
            config.MapHttpAttributeRoutes();
            // config.MessageHandlers.Add(new BasicAuthenticationHandler());

            

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling
 = Newtonsoft.Json.ReferenceLoopHandling.Ignore; 
        }

       
    }
}
