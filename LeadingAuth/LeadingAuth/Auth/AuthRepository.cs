/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：LeadingAuth.Auth
* 文件名： AuthRepository
* 版本号： V1.0.0.0
* 唯一标识： a8a5b7be-36a1-44ab-a40a-a90f34b3cc19
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/8/7 13:15:30

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/8/7 13:15:30
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using LeadingAuth.Entities;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LeadingAuth.Auth
{
    public class AuthRepository : IDisposable
    {
        private AuthContext _ctx;

        private UserManager<IdentityUser> _userManager;

        public AuthRepository()
        {
            _ctx = new AuthContext();
            _userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
        }

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="userModel"></param>
        /// <returns></returns>
        public async Task<IdentityResult> RegisterUser(UserModel userModel)
        {
            IdentityUser user = new IdentityUser
            {
                UserName = userModel.UserName
            };            
            var result = await _userManager.CreateAsync(user);
            return result;
        }

        /// <summary>
        /// 查询用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<IdentityUser> FindUser(string userName)
        {
            IdentityUser user = await _userManager.FindByNameAsync(userName);
            return user;
        }

        public void Dispose()
        {
            _ctx.Dispose();
            _userManager.Dispose();

        }
    }
}