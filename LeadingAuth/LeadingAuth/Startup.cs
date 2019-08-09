/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：LeadingAuth
* 文件名： Startup
* 版本号： V1.0.0.0
* 唯一标识： d0ff3ea7-929f-4b70-9078-d05b28dd0d36
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/8/7 13:31:32

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/8/7 13:31:32
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using LeadingAuth.Providers;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(LeadingAuth.Startup))]
namespace LeadingAuth
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseCors(CorsOptions.AllowAll);      //允许跨域请求
            ConfigureOAuth(app);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,                                       //允许客户端使用http协议请求
                TokenEndpointPath = new PathString("/token"),                   //token请求的地址
                AccessTokenExpireTimeSpan = TimeSpan.FromSeconds(30),              //token过期时间
                Provider = new AuthorizationServerProvider(),                   //获取Token             
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }
    }
}