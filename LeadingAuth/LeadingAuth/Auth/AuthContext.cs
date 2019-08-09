/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：LeadingAuth.Auth
* 文件名： AutnContext
* 版本号： V1.0.0.0
* 唯一标识： ec1f59d1-112b-4bbc-a6d6-1f9b455a9c20
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/8/7 13:14:20

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/8/7 13:14:20
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeadingAuth.Auth
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("AuthContext")
        {

        }
    }
}