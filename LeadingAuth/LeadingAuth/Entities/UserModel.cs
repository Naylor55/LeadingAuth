/********************************************************************
* Copyright (c) 2019 ALL Rights Reserved.
* CLR版本：4.0.30319.42000
* 机器名称：NAYLOR
* 公司名称：
* 命名空间：LeadingAuth.Entities
* 文件名： UserModel
* 版本号： V1.0.0.0
* 唯一标识： 99027790-af85-428c-9664-fe0717227175
* 当前的用户域： NAYLOR
* 创建人： Cnayl
* 电子邮箱： cnaylor@163.com
* 创建时间： 2019/8/7 13:16:46

* 描述：
*
* ==================================================================
* 修改标记
* 修改时间： 2019/8/7 13:16:46
* 修改人： Cnayl
* 版本号： 
* 描述：
*
*
********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LeadingAuth.Entities
{
    public class UserModel
    {
        [Required]        
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
        [Display(Name = "UserModel name")]
        public string UserName { get; set; }
    }
}